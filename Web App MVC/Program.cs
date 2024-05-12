using Microsoft.EntityFrameworkCore;
using Security_Guard.Models;
using OfficeOpenXml;
using Microsoft.AspNetCore.Identity;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
//var scopefactory = app.services
//.getrequiredservice<iservicescopefactory>();
//using (var scope = scopefactory.createscope())
//{
//    await configureidentity.createadminuserasync(
//    scope.serviceprovider);
//}

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


//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;
//using Security_Guard.Models;
//using OfficeOpenXml;



//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();

//// Add services to the container.
//builder.Services.AddControllersWithViews();

//builder.Services.AddIdentity<User, IdentityRole>(options =>
//{
//    options.Password.RequiredLength = 8;
//    options.Password.RequireUppercase = true;
//    options.Password.RequireLowercase = true;
//    options.Password.RequireDigit = true;
//})
//    .AddEntityFrameworkStores<DBContext>()
//    .AddDefaultTokenProviders();


//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<DBContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("dbContext")));

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<DBContext>();

//builder.Services.AddAuthorization();

//var app = builder.Build();

//// Configure EPPlus license context for non-commercial use
//ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
//app.MapIdentityApi<IdentityUser>();








//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthentication();
//app.UseAuthorization();
////var scopefactory = app.services
////.getrequiredservice<iservicescopefactory>();
////using (var scope = scopefactory.createscope())
////{
////    await configureidentity.createadminuserasync(
////    scope.serviceprovider);
////}
//app.MapControllers();
//// Area Routing
//app.MapControllerRoute(
//    name: "areas",
//    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

//// Default Routing
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
