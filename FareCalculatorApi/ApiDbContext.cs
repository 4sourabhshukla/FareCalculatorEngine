using FareCalculatorApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FareCalculatorApi
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext()
        {

        }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        public DbSet<PeakTiming> PeakTimings { get; set; }

        public DbSet<Fare> FareDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PeakTiming>().HasKey(p => p.ID);
            builder.Entity<Fare>().HasKey(p => p.ID);
        }

        public void Seed()
        {
            AddPeakTimings();
            AddFareDetails();
        }

        private void AddPeakTimings()
        {
            PeakTimings.Add(new PeakTiming { Day = "weekday", ZoneType = ZoneType.Intra, StartTime = "07:00", EndTime = "10:30" });
            PeakTimings.Add(new PeakTiming { Day = "weekday", ZoneType = ZoneType.Inter, StartTime = "17:00", EndTime = "20:30" });
            PeakTimings.Add(new PeakTiming { Day = "weekday", ZoneType = ZoneType.Intra, StartTime = "17:00", EndTime = "20:30" });
            PeakTimings.Add(new PeakTiming { Day = "weekend", ZoneType = ZoneType.Intra, StartTime = "09:00", EndTime = "11:00" });
            PeakTimings.Add(new PeakTiming { Day = "weekend", ZoneType = ZoneType.Inter, StartTime = "18:00", EndTime = "22:00" });
            PeakTimings.Add(new PeakTiming { Day = "weekend", ZoneType = ZoneType.Intra, StartTime = "18:00", EndTime = "22:00" });
            SaveChanges();
        }

        private void AddFareDetails()
        {
            FareDetails.Add(new Fare { FromZone = 1, ToZone = 1, DefaultFare = 25, PeakFare = 30, DailyCap = 100, WeeklyCap = 500 });
            FareDetails.Add(new Fare { FromZone = 1, ToZone = 2, DefaultFare = 30, PeakFare = 35, DailyCap = 120, WeeklyCap = 600 });
            FareDetails.Add(new Fare { FromZone = 2, ToZone = 1, DefaultFare = 30, PeakFare = 35, DailyCap = 120, WeeklyCap = 600 });
            FareDetails.Add(new Fare { FromZone = 2, ToZone = 2, DefaultFare = 20, PeakFare = 25, DailyCap = 80, WeeklyCap = 400 });
            SaveChanges();
        }
    }
}
