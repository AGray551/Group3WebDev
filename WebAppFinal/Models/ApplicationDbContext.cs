using Microsoft.EntityFrameworkCore;
namespace WebAppFinal.Models;


public class ApplicationDbContext : DbContext {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<DirtBike> DirtBikes { get; set; }
    public DbSet<DistanceRunning> DistanceRunnings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DirtBike>().HasData(
            new DirtBike { DirtBikeId = 1, Make = "Honda", Model = "CR250", Year = "1995", Displacement = "249cc"},
            new DirtBike { DirtBikeId = 2, Make = "Yamaha", Model = "YZ250", Year = "2004", Displacement = "249cc"},
            new DirtBike { DirtBikeId = 3, Make = "Suzuki", Model = "RM250", Year = "1999", Displacement = "249cc"}
        );

        modelBuilder.Entity<DistanceRunning>().HasData(
            new DistanceRunning { DistanceRunningId = 1, Date = new DateTime(2025, 10, 15), Distance = 5.2, Time = 45, MaxHeartRate = 165 },
            new DistanceRunning { DistanceRunningId = 2, Date = new DateTime(2025, 10, 18), Distance = 8.5, Time = 72, MaxHeartRate = 172 },
            new DistanceRunning { DistanceRunningId = 3, Date = new DateTime(2025, 10, 22), Distance = 10.0, Time = 88, MaxHeartRate = 178 },
            new DistanceRunning { DistanceRunningId = 4, Date = new DateTime(2025, 10, 25), Distance = 6.8, Time = 58, MaxHeartRate = 168 },
            new DistanceRunning { DistanceRunningId = 5, Date = new DateTime(2025, 10, 28), Distance = 12.0, Time = 105, MaxHeartRate = 180 }
        );
    }
}