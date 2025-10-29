using Microsoft.EntityFrameworkCore;
namespace WebAppFinal.Models;


public class DirtBikeContext : DbContext {
    public DirtBikeContext(DbContextOptions<DirtBikeContext> options)
        : base(options) { }

    public DbSet<DirtBike> DirtBikes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DirtBike>().HasData(
            new DirtBike { DirtBikeId = 1, Make = "Honda", Model = "CR250", Year = "1995", Displacement = "249cc"},
            new DirtBike { DirtBikeId = 2, Make = "Yamaha", Model = "YZ250", Year = "2004", Displacement = "249cc"},
            new DirtBike { DirtBikeId = 3, Make = "Suzuki", Model = "RM250", Year = "1999", Displacement = "249cc"}
        );
    }
}