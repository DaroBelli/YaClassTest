using Microsoft.EntityFrameworkCore;
using Task10.Contexts;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<YaClassTestContext>(options => options.UseSqlServer(connection));

builder.Services.AddRazorPages();

var app = builder.Build();

app.MapRazorPages();

app.Run();