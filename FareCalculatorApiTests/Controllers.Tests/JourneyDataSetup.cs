using DataContracts;
using System.Collections.Generic;

namespace FareCalculatorApiTests.Controllers.Tests
{
    public static class JourneyDataSetup
    {
        public static List<JourneyContract> GetInterZone12WeekdayPeakJourney()
        {
            List<JourneyContract> journeys = new List<JourneyContract>();
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 2, StartDateTime = "2021-03-03 19:00" });

            return journeys;
        }

        public static List<JourneyContract> GetIntraZone2WeekendOffJourney()
        {
            List<JourneyContract> journeys = new List<JourneyContract>();
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-06 01:30" });

            return journeys;
        }

        public static List<JourneyContract> GetIntraZone1WeekendPeakJourneys()
        {
            List<JourneyContract> journeys = new List<JourneyContract>();
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-07 19:30" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-07 19:30" });

            return journeys;
        }

        public static List<JourneyContract> GetDailyCapAsTotalFareForInterZoneJourneys()
        {
            List<JourneyContract> journeys = new List<JourneyContract>();
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-02 01:30" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 2, StartDateTime = "2021-03-02 09:40" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-02 21:05" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-02 18:30" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-02 10:00" });

            return journeys;
        }

        public static List<JourneyContract> GetTotalFareAs145ForInterZoneJourneys()
        {
            List<JourneyContract> journeys = new List<JourneyContract>();
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-02 01:30" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 2, StartDateTime = "2021-03-02 09:40" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-02 21:05" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-02 18:30" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-02 10:00" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-02 10:00" });

            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-03 10:00" });

            return journeys;
        }


        public static List<JourneyContract> GetTotalFareAs240ForInterZoneJourneys()
        {
            List<JourneyContract> journeys = new List<JourneyContract>();
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-02 01:30" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 2, StartDateTime = "2021-03-02 09:40" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-02 21:05" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-02 18:30" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-02 10:00" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-02 10:00" });

            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-03 10:00" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-03 11:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-03 10:55" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-03 05:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-03 12:55" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 2, StartDateTime = "2021-03-03 15:40" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-03 18:25" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-03 19:00" });

            return journeys;
        }

        public static List<JourneyContract> GetWeeklyCapAsTotalFareForInterZoneJourneys()
        {
            List<JourneyContract> journeys = new List<JourneyContract>();
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-02 01:30" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 2, StartDateTime = "2021-03-02 09:40" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-02 21:05" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-02 18:30" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-02 10:00" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-02 10:00" });

            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-03 10:00" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-03 11:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-03 10:55" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-03 05:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-03 12:55" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 2, StartDateTime = "2021-03-03 15:40" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-03 18:25" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-03 19:00" });

            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-04 10:00" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-04 11:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-04 10:55" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-04 05:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-04 12:55" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 2, StartDateTime = "2021-03-04 15:40" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-04 18:25" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-04 19:00" });

            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-05 10:00" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-05 11:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-05 18:25" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-05 19:00" });

            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-06 11:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-06 10:55" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-06 10:00" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-06 11:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-06 18:25" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-06 19:00" });

            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-01 11:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-01 10:55" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-01 10:00" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-01 11:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-01 18:25" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-01 19:00" });

            return journeys;
        }

        public static List<JourneyContract> GetMoreThanWeeklyCapAsTotalFareForInterZoneJourneys()
        {
            List<JourneyContract> journeys = new List<JourneyContract>();
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-02 01:30" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 2, StartDateTime = "2021-03-02 09:40" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-02 21:05" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-02 18:30" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-02 10:00" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-02 10:00" });

            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-03 10:00" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-03 11:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-03 10:55" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-03 05:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-03 12:55" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 2, StartDateTime = "2021-03-03 15:40" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-03 18:25" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-03 19:00" });

            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-04 10:00" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-04 11:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-04 10:55" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-04 05:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-04 12:55" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 2, StartDateTime = "2021-03-04 15:40" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-04 18:25" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-04 19:00" });

            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-05 10:00" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-05 11:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-05 18:25" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-05 19:00" });

            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-06 11:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-06 10:55" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-06 10:00" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-06 11:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-06 18:25" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-06 19:00" });

            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-01 11:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-01 10:55" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-01 10:00" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-01 11:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-01 18:25" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 1, StartDateTime = "2021-03-01 19:00" });

            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-11 10:00" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-12 11:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-13 10:55" });
            journeys.Add(new JourneyContract { FromZone = 1, ToZone = 1, StartDateTime = "2021-03-14 05:00" });

            return journeys;
        }

        public static List<JourneyContract> GetWeeklyCapAsTotalFare400ForIntraZone2Journeys()
        {
            List<JourneyContract> journeys = new List<JourneyContract>();
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-01 09:30" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-01 15:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-01 19:30" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-01 20:00" });

            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-02 10:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-02 17:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-02 16:30" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-02 19:00" });

            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-03 01:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-03 09:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-03 19:35" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-03 19:00" });

            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-04 12:00" });

            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-05 13:30" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-05 19:00" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-05 19:30" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-05 19:00" });

            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-06 23:30" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-06 17:45" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-06 19:30" });
            journeys.Add(new JourneyContract { FromZone = 2, ToZone = 2, StartDateTime = "2021-03-06 19:00" });

            return journeys;
        }
    }
}
