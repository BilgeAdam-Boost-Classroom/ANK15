var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();


//Bir MVC projes ilk basta nugetManger dan entitiy paketlerini yuklememiz lazim
// Sonrasinda context klasourumuzu acip dbContexten kalitim aldirmamiz lazim
//Overrider methodu ile de connetionStringimizi eklememiz lazim
//Eger connetionstringi appsettings ice yazarsak program cs icine servis ekler gibi db contextimizi ekleyim di ile de konstractirdan injette etmemiz lazim

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
