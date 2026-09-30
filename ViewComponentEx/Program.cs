using Microsoft.EntityFrameworkCore;
using ViewComponentEx.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContextPool<CompanyContext>(
     opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("scon"))
    );
var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
