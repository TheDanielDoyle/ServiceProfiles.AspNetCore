using Microsoft.AspNetCore.Hosting;

namespace ServiceProfiles.AspNetCore
{
    public abstract class WebHostServiceProfile : DefaultServiceProfile, IServiceProfile<IWebHostEnvironment>
    {
        public abstract void Configure(IServiceProfileContext<IWebHostEnvironment> context);
    }
}
