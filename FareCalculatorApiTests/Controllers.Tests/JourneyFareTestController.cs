using DataContracts;
using FareCalculatorApi;
using FareCalculatorApi.Controllers;
using FareCalculatorApi.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Xunit;

namespace FareCalculatorApiTests.Controllers.Tests
{
    public class JourneyFareTestController
    {
        private readonly JourneyFareController jc;

        public JourneyFareTestController()
        {
            var builder = new DbContextOptionsBuilder<ApiDbContext>();
            builder.UseInMemoryDatabase("TestDB");
            DbContextOptions<ApiDbContext> options = builder.Options;
            IFareCalculator service = new FareCalculatorService(options);
            jc = new JourneyFareController(service);
        }

        [Fact]
        public void GetFare_IntraZone2_Weekend_Journey_Returns_DefaultFare_20()
        {
            List<JourneyContract> journeys = JourneyDataSetup.GetIntraZone2WeekendOffJourney();

            int fare = jc.GetTotalFare(journeys);
            Assert.Equal(20, fare);
        }


        [Fact]
        public void GetFare_InterZone_Weekday_Journey_Returns_PeakFare_35()
        {
            List<JourneyContract> journeys = JourneyDataSetup.GetInterZone12WeekdayPeakJourney();

            int fare = jc.GetTotalFare(journeys);
            Assert.Equal(35, fare);
        }

        [Fact]
        public void GetFare_IntraZone1_Weekend_Journeys_Returns_LessThan_DailyCap_100()
        {
            List<JourneyContract> journeys = JourneyDataSetup.GetIntraZone1WeekendPeakJourneys();

            int fare = jc.GetTotalFare(journeys);
            Assert.True(fare < 100);
        }

        [Fact]
        public void GetFare_InterZone_Weekday_Journeys_Returns_DailyCap_120()
        {
            List<JourneyContract> journeys = JourneyDataSetup.GetDailyCapAsTotalFareForInterZoneJourneys();

            int fare = jc.GetTotalFare(journeys);
            Assert.Equal(120, fare);
        }

        [Fact]
        public void GetFare_TotalFare_145_For_Journeys_TueAndWed()
        {
            List<JourneyContract> journeys = JourneyDataSetup.GetTotalFareAs145ForInterZoneJourneys();

            int fare = jc.GetTotalFare(journeys);
            Assert.Equal(145, fare);
        }

        [Fact]
        public void GetFare_InterZone_Weekdays_Journeys_Returns_TwoDailyCap_240()
        {
            List<JourneyContract> journeys = JourneyDataSetup.GetTotalFareAs240ForInterZoneJourneys();

            int fare = jc.GetTotalFare(journeys);
            Assert.Equal(240, fare);
        }

        [Fact]
        public void GetFare_InterZone_Weekfull_Journeys_Returns_WeeklyCap_600()
        {
            List<JourneyContract> journeys = JourneyDataSetup.GetWeeklyCapAsTotalFareForInterZoneJourneys();

            int fare = jc.GetTotalFare(journeys);
            Assert.Equal(600, fare);
        }

        [Fact]
        public void GetFare_InterZone_Monthly_Journeys_Returns_MoreThan_WeeklyCap_600()
        {
            List<JourneyContract> journeys = JourneyDataSetup.GetMoreThanWeeklyCapAsTotalFareForInterZoneJourneys();

            int fare = jc.GetTotalFare(journeys);
            Assert.True(fare > 600);
        }

        [Fact]
        public void GetFare_IntraZone2_Weekfull_Journeys_Returns_WeeklyCap_400()
        {
            List<JourneyContract> journeys = JourneyDataSetup.GetWeeklyCapAsTotalFare400ForIntraZone2Journeys();

            int fare = jc.GetTotalFare(journeys);
            Assert.Equal(400, fare);
        }
    }
}
