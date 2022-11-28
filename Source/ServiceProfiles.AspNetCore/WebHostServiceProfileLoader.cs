using System.Reflection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceProfiles.AspNetCore;

public class WebHostServiceProfileLoader : DefaultServiceProfileLoader<IWebHostEnvironment>, IWebHostServiceProfileLoader
{
    public IWebHostServiceProfileLoader Load(IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment)
    {
        return LoadFromAssembly(services, configuration, environment, Assembly.GetCallingAssembly());
    }

    public IWebHostServiceProfileLoader LoadFromAssemblies(IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment, params Assembly[] assemblies)
    {
        WebHostServiceProfileLoader loader = new WebHostServiceProfileLoader();
        loader.LoadFromAssemblies(new WebHostServiceProfileContext(services, configuration, environment), assemblies);
        return loader;
    }

    public IWebHostServiceProfileLoader LoadFromAssembly(IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment, Assembly assembly)
    {
        return LoadFromAssemblies(services, configuration, environment, new[] { assembly });
    }
}