using Microsoft.Extensions.DependencyInjection;

namespace ServiceProfiles.AspNetCore.Samples.Mvc.Services
{
    public class SecurityProfile : WebHostServiceProfile
    {
        public override void Configure(IWebHostServiceProfileContext context)
        {
            context.Services.AddAuthentication();
            context.Services.AddAuthentication();
        }
    }
}
