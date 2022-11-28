using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ServiceProfiles.AspNetCore.Samples.Mvc;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaultsWithServiceProfiles(builder =>
            {
                builder.UseStartup<Startup>();
            });
    //.ConfigureWebHostDefaults(webBuilder =>
    //{
    //    webBuilder.UseStartup<Startup>();
    //    //webBuilder.ConfigureServices((context, services) =>
    //    //{
    //    //    WebHostServiceProfileLoader loader = new WebHostServiceProfileLoader();
    //    //    loader.Load(services, context.Configuration, context.HostingEnvironment);
    //    //});
    //    //webBuilder.ConfigureServicesWithProfiles(typeof(Program).Assembly);
    //    webBuilder.ConfigureServicesWithProfiles();
    //});
}