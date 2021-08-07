using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using RazorPages.Utilities;

namespace RazorPages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.ConfigureLogging((hostingContext, logging) =>
                    {
                        logging.AddSerilog(hostingContext);
                    });
                });
    }
}
