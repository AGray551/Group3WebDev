using Microsoft.EntityFrameworkCore;
using WebAppFinal.Models;
using WebAppFinal.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DirtBikeContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DirtBikeContext")));

builder.Services.AddScoped<IDirtBikeRepository, DirtBikeRepository>();

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<DirtBikeContext>();
    context.Database.Migrate();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();