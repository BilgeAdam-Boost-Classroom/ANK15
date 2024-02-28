using EsyaMvc.Context;
using EsyaMvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<EsyaDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("EsyaSql")));
//builder.Services.AddMvc(opt =>
//{
//    opt.Filters.Add(new ConsoleActionFilter("Program.cs"));
//});
builder.Services.AddControllers(opt =>
{
    opt.Filters.Add(new ConsoleActionFilter("Program.cs",2));
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//Action filter controllerdan once calisan filtrelerdir.
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
