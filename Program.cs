using Microsoft.EntityFrameworkCore;
using TodoApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register the DbContext with SQL Server (ApplicationDbContext)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add other services you may need, like Razor Pages, if applicable
// builder.Services.AddRazorPages(); // Uncomment if you're using Razor Pages too

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // Ensure HSTS is only enabled in production
}

app.UseHttpsRedirection();
app.UseStaticFiles();  // Ensure that static files are served

app.UseRouting();

// Authentication and Authorization middleware (if needed)
app.UseAuthorization();  // Add this if you have any authorization logic

// Set up default routing (HomeController is the default)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Todo}/{action=Index}/{id?}"); // Make "Todo" the default controller instead of "Home"

// Optionally, you can add a fallback route if necessary
// app.MapRazorPages(); // Uncomment if you're using Razor Pages

app.Run();
