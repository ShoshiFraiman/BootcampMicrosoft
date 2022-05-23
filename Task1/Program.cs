global using BL;
global using DL;
using Entities;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSingleton<ILocationDL, LocationDL>();
builder.Services.AddScoped<ILocationBL, LocationBL>();
var app = builder.Build();

app.MapGet("/location/",  (ILocationBL _locationBL) => {
    return  _locationBL.GetAll();
});
app.MapGet("/location/{patientId}",  (ILocationBL _locationBL,String patientId) => {
    return  _locationBL.GetByPatientId(patientId);
});

app.MapGet("/location/city", ([FromQuery(Name = "city")] String city, ILocationBL _locationBL) =>
{

    return _locationBL.GetByCity(city);
});

app.MapPost("/location/",  (ILocationBL _locationBL,Location location) => {
    return  _locationBL.AddLocation(location);
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
