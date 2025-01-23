using CRUDwithDapper.Data;
using CRUDwithDapper.Models;
using CRUDwithDapper.Repository;
using Microsoft.Extensions.Logging.Abstractions;
using NLog;
using NLog.Web;

var logger = LogManager.Setup().LoadConfigurationFromFile("NLog.config").GetCurrentClassLogger();

try
{

    logger.Debug("Starting application...");

    var builder = WebApplication.CreateBuilder(args);

    builder.Logging.ClearProviders();
    builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
    builder.Host.UseNLog();

    builder.Services.AddControllersWithViews();
    builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

    builder.Services.AddTransient<IDapperContext, DapperContext>();
    builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

    var app = builder.Build();

    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();
    app.UseRouting();

    app.UseAuthorization();


    app.MapRazorPages();
    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");


    app.Run();
}
catch (Exception ex)
{
    logger.Error(ex, "Stopped program because of exception");
    throw;
}
finally
{
    LogManager.Shutdown();
}