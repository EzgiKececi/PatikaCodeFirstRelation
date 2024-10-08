using CodeFirstRelation.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var cs = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<PatikaSecondDbContext>(options =>options.UseSqlServer(cs));

var app = builder.Build();
app.MapDefaultControllerRoute();

app.Run();
