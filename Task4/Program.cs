using Task4.Controllers;
using Task4.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddTransient<ITrainService, TrainService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

RouteGroupBuilder trains = app.MapGroup("/trains");

trains.MapGet("/train", app.Services.GetService<ITrainService>().GetTrain).WithTags("Trains Endpoint");
trains.MapGet("/order", app.Services.GetService<ITrainService>().GetTrainsOrderByDestinationThenDepartureTime).WithTags("Trains Endpoint");
trains.MapGet("/filter", app.Services.GetService<ITrainService>().GetTrainsFilterByActualTime).WithTags("Trains Endpoint");

app.Run();
