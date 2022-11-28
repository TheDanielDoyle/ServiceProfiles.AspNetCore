using Microsoft.AspNetCore.Hosting;

namespace ServiceProfiles.AspNetCore;

public interface IWebHostServiceProfileContext : IServiceProfileContext<IWebHostEnvironment>
{
}