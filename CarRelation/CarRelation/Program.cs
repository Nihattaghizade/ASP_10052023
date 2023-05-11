using Microsoft.EntityFrameworkCore;
using CarRelation.DataAccessLayer;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer("Server=DESKTOP-I2J3A2U\\SQLEXPRESS;Database=CarRelationDb;Trusted_Connection=true;");
});
var app = builder.Build();

app.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");

app.Run();
 