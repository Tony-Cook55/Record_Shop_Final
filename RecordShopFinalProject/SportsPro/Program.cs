using Microsoft.EntityFrameworkCore;
using RecordShop.Models;

var builder = WebApplication.CreateBuilder(args);


//  ccccccc COOKIES/SESSIONS ccccccc  \\
// Enables this to allow sessions to store session id to server and ram
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
//  ccccccc COOKIES/SESSIONS ccccccc  \\



builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
    options.AppendTrailingSlash = true;
});


// Add services to the container.
builder.Services.AddControllersWithViews();




// ADDING EF core Dependency Injection
// Allows us to work with or Products context files to query the data
builder.Services.AddDbContext<RecordShopContextModel>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RecordStoreConnection"))); // This is the ConnectionStrings in appsettings.json


// Makes everything in the url lowercase and adds a / to the end of the url
builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
    options.AppendTrailingSlash = true;
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


// Serve static files from the wwwroot directory
app.UseStaticFiles();



app.UseRouting();

app.UseAuthorization();


//  ccccccc COOKIES/SESSIONS ccccccc  \\
app.UseSession();
//  ccccccc COOKIES/SESSIONS ccccccc  \\



// ADDING ROUTES BELOW

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
