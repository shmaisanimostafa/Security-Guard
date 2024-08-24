using Microsoft.EntityFrameworkCore;
//using Security_Guard.Models;
using OfficeOpenXml;
using Microsoft.AspNetCore.Identity;
using Shared.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add Roles 
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddHttpClient<FastApiService>();

// Add Policies
// builder.Services.AddAuthorization(options =>
// {
// 	options.AddPolicy("PostArticlePolicy", policy =>
// 		policy.RequireClaim("Permission", "PostArticle"));
// });

builder.Services.AddIdentity<User, IdentityRole>(options =>
{
	options.Password.RequiredLength = 8;
	options.Password.RequireUppercase = true;
	options.Password.RequireLowercase = true;
	options.Password.RequireDigit = true;
})
	.AddEntityFrameworkStores<DBContext>()
	.AddDefaultTokenProviders();

builder.Services.AddDbContext<DBContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("dbContext")));

var app = builder.Build();

// Configure EPPlus license context for non-commercial use
ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


// Area Routing
app.MapControllerRoute(
	name: "areas",
	pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

// Default Routing
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


////
/////
/////
/////
/////
/////
/////

