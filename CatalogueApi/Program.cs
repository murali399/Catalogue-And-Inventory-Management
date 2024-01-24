using catalogue.ApplicationLayer;
using Catalogue.DomainLayer.IReposistory;
using Catalogue.InfastructureLayer;
using Catalogue.InfastructureLayer.Data;
using Catalogue.InfastructureLayer.Reposistory;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var logger = new LoggerConfiguration()
    .WriteTo.Console()
     .WriteTo.File("Log/log.txt", rollingInterval: RollingInterval.Minute)
    .MinimumLevel.Information()
    .CreateLogger();

builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);



builder.Services.AddControllers();
builder.Services.AddApplicationService();
builder.Services.AddInfrastructureServices(builder.Configuration);

builder.Services.AddTransient<IProductRepository, ProductRepository>();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

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
