using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using ServiceProfiles.AspNetCore;

namespace Microsoft.AspNetCore.Hosting
{
    public static class IWebHostBuilderExtensions
    {
        public static IWebHostBuilder ConfigureServicesWithProfiles(this IWebHostBuilder builder)
        {
            return ConfigureServicesWithProfiles(builder, default(Action<WebHostBuilderContext, IServiceCollection>), Assembly.GetCallingAssembly());
        }

        public static IWebHostBuilder ConfigureServicesWithProfiles(this IWebHostBuilder builder, Action<WebHostBuilderContext, IServiceCollection> configureDelegate)
        {
            return ConfigureServicesWithProfiles(builder, configureDelegate, Assembly.GetCallingAssembly());
        }

        public static IWebHostBuilder ConfigureServicesWithProfiles(this IWebHostBuilder builder, params Assembly[] assemblies)
        {
            return ConfigureServicesWithProfiles(builder, default(Action<WebHostBuilderContext, IServiceCollection>), assemblies);
        }

        public static IWebHostBuilder ConfigureServicesWithProfiles(this IWebHostBuilder builder, Action<WebHostBuilderContext, IServiceCollection> configureDelegate, params Assembly[] assemblies)
        {
            builder.ConfigureServices((context, services) =>
            {
                configureDelegate?.Invoke(context, services);
                IWebHostServiceProfileLoader loader = new WebHostServiceProfileLoader();
                loader.LoadFromAssemblies(services, context.Configuration, context.HostingEnvironment, assemblies);
            });
            return builder;
        }
    }
}
