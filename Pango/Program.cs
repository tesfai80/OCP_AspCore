using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
//using Pango;
using OCP_AspCore;

namespace OCP_AspCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
