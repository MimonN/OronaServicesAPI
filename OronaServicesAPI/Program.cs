using Contracts;
using Microsoft.AspNetCore.HttpOverrides;
using NLog;
using OronaServicesAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

// Add services to the container.

builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration();
builder.Services.ConfigureLoggerService();
builder.Services.ConfigureSqlServerContext(builder.Configuration);
builder.Services.ConfigureRepositoryWrapper();
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

var logger = app.Services.GetRequiredService<ILoggerManager>();
//app.ConfigureExceptionHandler(logger);
app.ConfigureCustomExceptionMiddleware();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();
else
    app.UseHsts();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
