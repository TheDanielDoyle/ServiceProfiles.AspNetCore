using Microsoft.AspNetCore.Hosting;

namespace ServiceProfiles.AspNetCore
{
    public abstract class WebHostServiceProfile : DefaultServiceProfile, IServiceProfile<IWebHostEnvironment>
    {
        void IServiceProfile<IWebHostEnvironment>.Configure(IServiceProfileContext<IWebHostEnvironment> context)
        {
            Configure(context as IWebHostServiceProfileContext);
        }

        public abstract void Configure(IWebHostServiceProfileContext context);
    }
}
