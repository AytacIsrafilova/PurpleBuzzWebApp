

using Microsoft.EntityFrameworkCore;
using PurpleBuzzWebApp.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(opt=>
{
    opt.UseSqlServer("Server=.;database=FirstWeb;Trusted_connection=true;Integrated security=true;Encrypt=false");
});
var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute(

name:"default",
pattern:"{controller=home}/{action=index}/{Id?}"

);

app.Run();
