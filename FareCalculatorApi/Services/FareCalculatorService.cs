using FareCalculatorApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FareCalculatorApi.Services
{
    public class FareCalculatorService : IFareCalculator
    {
        private readonly ApiDbContext dbContext;

        public FareCalculatorService(DbContextOptions<ApiDbContext> options)
        {
            this.dbContext = new ApiDbContext(options);
            //seed the db with relevant data for fare and peak timings
            dbContext.Seed();
        }

        //Calculate the total fare for all journeys after applying daily and weekly cap as applicable
        public int GetTotalFare(List<Journey> journeys)
        {
            //sort the journeys date wise
            journeys.Sort((x, y) => x.StartDateTime.Date.CompareTo(y.StartDateTime.Date));

            //based on daily cap come up with daywise total fare for journeys
            Dictionary<DateTime, int> dayTotalFare = ApplyDailyCapToFare(journeys);

            //update the daywise total fares now based on weekly cap limit
            ApplyWeeklyCapToFare(dayTotalFare);

            //finally calculate total value of all journeys grouped daywise
            int totalFare = 0;
            foreach (var kvp in dayTotalFare)
            {
                totalFare += kvp.Value;
            }

            return totalFare;
        }

        private Dictionary<DateTime, int> ApplyDailyCapToFare(List<Journey> journeys)
        {
            //Dictionary for day wise grouping of journeys with day wise total of fares is stored
            Dictionary<DateTime, int> dayTotalFare = new Dictionary<DateTime, int>();
            int dailyCap = 0;

            foreach (Journey journey in journeys)
            {
                //Calculate the cost of a trip without any cap
                var cost = CalculateFare(journey);

                //based on current journey update the daily cap value if needed
                int currentDailyCap = GetDailyCap(journey.FromZone, journey.ToZone);
                if (dailyCap < currentDailyCap)
                    dailyCap = currentDailyCap;

                if (dayTotalFare.ContainsKey(journey.StartDateTime.Date))
                {
                    int currValue = dayTotalFare[journey.StartDateTime.Date];

                    if (currValue + cost <= dailyCap)
                    {
                        dayTotalFare[journey.StartDateTime.Date] += cost;
                    }
                    else
                    {
                        dayTotalFare[journey.StartDateTime.Date] = dailyCap;
                    }
                }
                else
                {
                    dayTotalFare.Add(journey.StartDateTime.Date, cost);
                }
            }

            return dayTotalFare;
        }

        private void ApplyWeeklyCapToFare(Dictionary<DateTime, int> dayTotalFare)
        {
            //based on the first day of the journey fetch that week's sunday as last day of week
            var firstDate = dayTotalFare.Keys.First().Date;
            var firstDay = firstDate.DayOfWeek;
            var currWeekendDate = firstDate.AddDays(7 - (int)firstDay);

            //get the weekly cap for the first week. a weekly cap of 0 means the daily cap was not reached for that date
            int weeklyCap = GetWeeklyCap(dayTotalFare.First().Value);

            int total = 0;

            //since you cannot modify a dicionary value in a foreach loop, create a new list with it's keyvalue pairs
            List<KeyValuePair<DateTime, int>> dictList = dayTotalFare.ToList();
            foreach (var kvp in dictList)
            {
                if (kvp.Key.Date <= currWeekendDate.Date)
                {
                    if (weeklyCap == 0 || (total + kvp.Value) <= weeklyCap)
                    {
                        total += kvp.Value;
                    }
                    else
                    {
                        dayTotalFare[kvp.Key] = weeklyCap - total;
                    }
                }
                else
                {
                    //this date now indicates a start of a new week and weekly cap alongwith weekend date needs to be updated
                    firstDate = kvp.Key.Date;
                    firstDay = firstDate.DayOfWeek;
                    currWeekendDate = firstDate.AddDays(7 - (int)firstDay);
                    weeklyCap = GetWeeklyCap(kvp.Value);

                    total = kvp.Value;
                }
            }
        }

        //Fare calculation is done on the basis of FromZone, ToZone and Journey day and time
        private int CalculateFare(Journey journey)
        {
            string time = journey.StartDateTime.ToString("HH:mm");
            string dayType = GetDayType(journey.StartDateTime.DayOfWeek.ToString().ToLower());
            ZoneType zoneType = journey.FromZone == journey.ToZone ? ZoneType.Intra : ZoneType.Inter;

            bool isPeakFare = dbContext.PeakTimings.Where(x => x.Day == dayType && x.ZoneType == zoneType
            && TimeSpan.Parse(time) >= TimeSpan.Parse(x.StartTime) && TimeSpan.Parse(time) <= TimeSpan.Parse(x.EndTime)).Any();

            Fare item = dbContext.FareDetails.FirstOrDefault(x => x.FromZone == journey.FromZone && x.ToZone == journey.ToZone);

            return isPeakFare ? item.PeakFare : item.DefaultFare;
        }

        //get day type based on particular day i.e. weekend/weekday
        private string GetDayType(string day)
        {
            List<string> weekends = new List<string> { "sunday", "saturday" };

            if (weekends.Contains(day)) return "weekend";
            else return "weekday";
        }

        //Daily cap calculation is done on the basis of FromZone and ToZone
        private int GetDailyCap(int fromZone, int toZone)
        {
            Fare item = dbContext.FareDetails.FirstOrDefault(x => x.FromZone == fromZone && x.ToZone == toZone);
            return item.DailyCap;
        }

        //Weekly cap is fetched on the basis of Daily cap
        private int GetWeeklyCap(int dailyCap)
        {
            Fare item = dbContext.FareDetails.FirstOrDefault(x => x.DailyCap == dailyCap);
            if (item != null)
                return item.WeeklyCap;
            else return 0;//return 0 for Invalid Daily Cap
        }
    }
}
