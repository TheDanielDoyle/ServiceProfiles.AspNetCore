using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceProfiles.AspNetCore.Samples.Mvc.Services
{
    public class SecurityProfile : WebHostServiceProfile
    {
        public override void Configure(IServiceProfileContext<IWebHostEnvironment> context)
        {
            context.Services.AddAuthentication();
            context.Services.AddAuthentication();
        }
    }
}
