using RealEstateAgency.Application;
using RealEstateAgency.Application.Common.Interfaces;
using RealEstateAgency.Infrastructure;
using RealEstateAgency.Infrastructure.Persistence;
using AutoMapper;
using System.Reflection;
using RealEstateAgency.Application.Common.Mappings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddAutoMapper(config =>
{
    config.AddProfile(new MappingProfile(Assembly.GetExecutingAssembly()));
    config.AddProfile(new MappingProfile(typeof(IApplicationDbContext).Assembly));
});


builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();

builder.Services.AddControllersWithViews();

var app = builder.Build();


using (var serviceScope = app.Services.CreateScope())
{
    var services = serviceScope.ServiceProvider;

    try
    {
        var context = services.GetRequiredService<ApplicationDbContext>();
        DbInitializer.Initialize(context);
    }
    catch (Exception exception)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(exception, "An error occured while app initialization");
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.MapFallbackToFile("index.html"); ;

app.Run();
