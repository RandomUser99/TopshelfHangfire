using Hangfire;
using Microsoft.AspNetCore.Builder;

namespace TopshelfHangfireDemo
{
    internal class Startup
    {
        public void Configuration(IApplicationBuilder appBuilder)
        {
            GlobalConfiguration.Configuration.UseSqlServerStorage("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=TopshelfHangfireDemo;Integrated Security=SSPI;");
            appBuilder.UseHangfireDashboard();
            appBuilder.UseHangfireServer();

            var jobService = new HangFireService();
            jobService.ScheduleJobs();
        }
    }
}
