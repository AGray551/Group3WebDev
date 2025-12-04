using Microsoft.EntityFrameworkCore;
namespace WebAppFinal.Models;


public class ApplicationDbContext : DbContext {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<DirtBike> DirtBikes { get; set; }
    public DbSet<DistanceRunning> DistanceRunnings { get; set; }
    public DbSet<VideoGame> VideoGames { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DirtBike>().HasData(
            new DirtBike { DirtBikeId = 1, Make = "Honda", Model = "CR80", Year = "1998", Displacement = "80cc", 
               Description = "This was my first introduction to dirt bikes, I have great memories of riding this bike around my parents front yard." +
                             " They probably didn't like all the tracks it left in the yard."},
            new DirtBike { DirtBikeId = 2, Make = "Honda", Model = "XR100", Year = "2004", Displacement = "100cc", 
                Description = "My second bike. This one was not as thrilling as the previous. " +
                              "CR80, but my CR80 ended up blowing up and at the time, I didn't have the knowledge or funds to repair it. " +
                              "The XR100 was still a good bike, but I was beginning to get too big for it."},
            new DirtBike { DirtBikeId = 3, Make = "Honda", Model = "XR200", Year = "2002", Displacement = "200cc",
                Description = "This was my first 'full size' bike. This bike had much more power than the previous XR100, but it wasn't crazy fast by any means. " +
                              "I was just happy to have a bigger bike at this point."},
            new DirtBike { DirtBikeId = 4, Make = "Honda", Model = "XR250R",Year = "1999", Displacement = "250cc",
                Description = "This bike was a step up from the XR200, but for whatever reason it wasn't very reliable so I ended up selling it pretty quickly."},
            new DirtBike { DirtBikeId = 5, Make = "Honda", Model = "CR125",Year = "2001", Displacement = "125cc",
                Description = "This bike was very fun but it didn't have much torque which became a problem since I mostly rode it in areas with steep hills and tight trails."},
            new DirtBike { DirtBikeId = 6, Make = "Kawasaki", Model = "KX250",Year = "1999", Displacement = "250cc",
                Description = "This my first 'Fast' bike. I had a lot of fun on it but it wasn't in the best shape when I bought it so it didn't last long before it started having issues."},
            new DirtBike { DirtBikeId = 7, Make = "Yamaha", Model = "YZ250",Year = "2004", Displacement = "250cc",
                Description = "My current bike. I purchased it from a guy that took great care of it and it runs great. I've had it for 4 years now and it's never let me down. " +
                              "I plan to keep this bike for a long time and rebuild it when the time comes."}
        );

        modelBuilder.Entity<DistanceRunning>().HasData(
            new DistanceRunning { DistanceRunningId = 1, Date = new DateTime(2025, 10, 15), Distance = 5.2, Time = 45, MaxHeartRate = 165 },
            new DistanceRunning { DistanceRunningId = 2, Date = new DateTime(2025, 10, 18), Distance = 8.5, Time = 72, MaxHeartRate = 172 },
            new DistanceRunning { DistanceRunningId = 3, Date = new DateTime(2025, 10, 22), Distance = 10.0, Time = 88, MaxHeartRate = 178 },
            new DistanceRunning { DistanceRunningId = 4, Date = new DateTime(2025, 10, 25), Distance = 6.8, Time = 58, MaxHeartRate = 168 },
            new DistanceRunning { DistanceRunningId = 5, Date = new DateTime(2025, 10, 28), Distance = 12.0, Time = 105, MaxHeartRate = 180 }
        );

        modelBuilder.Entity<VideoGame>().HasData(
            new VideoGame { VideoGameId = 1, Title = "Mario 64", ReleaseDate = new DateTime(1996, 6, 23), Genre = "Platformer", Platforms = "Nintendo 64", Rating = 3.5 },
            new VideoGame { VideoGameId = 2, Title = "Devil May Cry 3", ReleaseDate = new DateTime(2005, 2, 17), Genre = "Action", Platforms = "PS2, PC", Rating = 4.5 },
            new VideoGame { VideoGameId = 3, Title = "Portal 2", ReleaseDate = new DateTime(2011, 4, 19), Genre = "Puzzle", Platforms = "PC, PS3, Xbox 360", Rating = 5 },
            new VideoGame { VideoGameId = 4, Title = "Disco Elysium", ReleaseDate = new DateTime(2019, 10, 15), Genre = "RPG", Platforms = "PC, PS4, PS5, Xbox One", Rating = 4.8 }
        );

    }
}