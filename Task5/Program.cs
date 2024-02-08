using Task5.Services;
using Task5.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddTransient<IFigureService, FigureService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/figuries", app.Services.GetService<IFigureService>().InfoFiguries).WithTags("Figure Endpoint");

app.Run();