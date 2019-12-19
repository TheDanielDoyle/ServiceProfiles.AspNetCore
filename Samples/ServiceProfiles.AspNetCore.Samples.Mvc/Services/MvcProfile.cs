using Microsoft.Extensions.DependencyInjection;

namespace ServiceProfiles.AspNetCore.Samples.Mvc.Services
{
    public class MvcProfile : WebHostServiceProfile
    {
        public override void Configure(IWebHostServiceProfileContext context)
        {
            context.Services.AddControllersWithViews();
        }
    }
}
