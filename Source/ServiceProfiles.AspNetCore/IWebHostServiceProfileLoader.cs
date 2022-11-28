using System.Reflection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceProfiles.AspNetCore;

public interface IWebHostServiceProfileLoader : IServiceProfileLoader<IWebHostEnvironment>
{
    IWebHostServiceProfileLoader Load(IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment);

    IWebHostServiceProfileLoader LoadFromAssemblies(IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment, params Assembly[] assemblies);

    IWebHostServiceProfileLoader LoadFromAssembly(IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment, Assembly assembly);
}