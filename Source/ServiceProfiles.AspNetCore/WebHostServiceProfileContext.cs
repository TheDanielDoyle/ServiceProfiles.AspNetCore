using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceProfiles.AspNetCore;

public class WebHostServiceProfileContext : IWebHostServiceProfileContext
{
    public WebHostServiceProfileContext(IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment)
    {
        Services = services;
        Configuration = configuration;
        Environment = environment;
    }

    public IConfiguration Configuration { get; }

    public IWebHostEnvironment Environment { get; }

    public IServiceCollection Services { get; }
}