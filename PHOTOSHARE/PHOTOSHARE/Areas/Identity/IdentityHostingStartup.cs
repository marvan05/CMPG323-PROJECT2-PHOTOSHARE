using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PHOTOSHARE.Areas.Identity.Data;
using PHOTOSHARE.Data;

[assembly: HostingStartup(typeof(PHOTOSHARE.Areas.Identity.IdentityHostingStartup))]
namespace PHOTOSHARE.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PHOTOSHAREDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PHOTOSHAREDBContextConnection")));

                services.AddDefaultIdentity<PHOTOSHAREUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<PHOTOSHAREDBContext>();
            });
        }
    }
}