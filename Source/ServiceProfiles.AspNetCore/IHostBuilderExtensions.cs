using System;
using System.Reflection;
using Microsoft.Extensions.Hosting;

namespace Microsoft.AspNetCore.Hosting
{
    public static class IHostBuilderExtensions
    {
        public static IHostBuilder ConfigureWebHostDefaultsWithServiceProfiles(this IHostBuilder builder, Action<IWebHostBuilder> configure, params Assembly[] assemblies)
        {
            builder.ConfigureWebHostDefaults(webBuilder =>
            {
                configure?.Invoke(webBuilder);
                webBuilder.ConfigureServicesWithProfiles(assemblies);
            });
            return builder;
        }
    }
}
