using Microsoft.EntityFrameworkCore;
using StajIletisimApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// DbContext ekle (MSSQL bağlantısı)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Default route: direkt Contacts/Create sayfası açılır
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Contacts}/{action=Create}/{id?}");

app.Run();
