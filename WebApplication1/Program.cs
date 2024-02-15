using Aairport.Data;
using Aairport.Data.Repositories;
using Airport.Core.Repositories;
using Airport.Core.Services;
using Airport.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var policy = "policy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policy, policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

builder.Services.AddScoped<IflightService , FlightsService>();
builder.Services.AddScoped<IflightRepository, FlightRepository>();
builder.Services.AddSingleton<DataContext>();

builder.Services.AddScoped<IpassengerService, PassengersService>();
builder.Services.AddScoped<IpassengerRepository, PassengerRepository>();
////builder.Services.AddSingleton<DataContext>();

builder.Services.AddScoped<IpilotService, PilotsService>();
builder.Services.AddScoped<IpilotRepository, PilotRepository>();
//builder.Services.AddSingleton<DataContext>();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors(policy);


app.MapControllers();

app.Run();
