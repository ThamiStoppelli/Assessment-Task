using Hangfire;
using Hangfire.SqlServer;
using Infrastructure.Config;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddInfrastructure(hostContext.Configuration);
        services.AddHangfire(config => config.UseSqlServerStorage("YourConnectionString"));
        services.AddHangfireServer();
    });

var host = builder.Build();

using (var scope = host.Services.CreateScope())
{
    var recurringJobManager = scope.ServiceProvider.GetRequiredService<IRecurringJobManager>();
    recurringJobManager.AddOrUpdate<TextUpsertJob>("UpsertTexts", job => job.Execute(), Cron.Hourly);
}

await host.RunAsync();
