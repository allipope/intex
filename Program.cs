using intex.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using intex.Models;

var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ebdbContext>(options =>
    options.UseNpgsql(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();


//Link ASP User Classes:
var connectionStringAuth = builder.Configuration.GetConnectionString("AuthLink");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionStringAuth));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();




builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    //.AddDefaultTokenProviders
    //.AddRoles<IdentityRole>
    .AddEntityFrameworkStores<ApplicationDbContext>();


builder.Services.AddScoped<IebdbContextRepository, EFebdbContextRepository>();
//builder.Services.AddScoped<IColorRepository, EFColorRepository>();
//builder.Services.AddScoped<ITextileRepository, EFTextileRepository>();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddHsts(options =>
{
    options.MaxAge = TimeSpan.FromDays(365);
    options.IncludeSubDomains = true;
});

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None;
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseCookiePolicy();

app.UseRouting();

app.UseAuthentication();
//app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
