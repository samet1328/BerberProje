var builder = WebApplication.CreateBuilder(args);

// MVC (Controllers + Views)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Ortam ayarlarý (örnek)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// HTTPS, Statik dosyalar, Routing
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

// MVC route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
