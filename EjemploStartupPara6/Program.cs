
using EjemploStartupPara6;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var startup = new Startup(builder.Configuration);

startup.ConfigureService(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
startup.Configure(app, app.Environment);



app.Run();
