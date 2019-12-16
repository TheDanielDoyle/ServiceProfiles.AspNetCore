# Service Profiles for ASP.NET Core

Service Profile implementation suited for ASP.NET Core. IWebHostEnvironment is available instead of IHostEnvironment.

## Quick start

1. Instantiate a __WebHostServiceProfileLoader()__ class.

2. Execute one of the Load() methods and pass in the __IServiceCollection__, __IConfiguration__ and __IWebHostEnvironment__.

3. See example:

````csharp
IWebHostServiceProfileLoader loader = new WebHostServiceProfileLoader();
loader.Load(services, Configuration, Environment);
loader.LoadFromAssembly(services, Configuration, Environment, typeof(Startup).Assembly);
loader.LoadFromAssemblies(services, Configuration, Environment, new Assembly[] {typeof(Startup).Assembly});
````

4. Create classes that derive from __WebHostServiceProfile__ and implement the __Configure()__ method.

5. See example:

````csharp
public class MvcProfile : WebHostServiceProfile
{
    public override void Configure(IServiceProfileContext<IWebHostEnvironment> context)
    {
        context.Services.AddControllersWithViews();
    }
}
````

## Samples

See the following sample <https://github.com/TheDanielDoyle/ServiceProfiles.AspNetCore/blob/develop/Samples/ServiceProfiles.AspNetCore.Samples.Mvc/Startup.cs> which demonstates what to add to your __Startup.cs__
