using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args) 
            .ConfigureAppConfiguration((hostingcontext, config) =>
            {
                var env = hostingcontext.HostingEnvironment;

                config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddJsonFile("Content.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

                
            }).UseStartup<Startup>();// 为Web Host指定了Startup类
                                    //.ConfigureWebHostDefaults(webBuilder =>
                                    //{
                                    //    webBuilder.UseStartup<Startup>();
                                    //});
    }
}
