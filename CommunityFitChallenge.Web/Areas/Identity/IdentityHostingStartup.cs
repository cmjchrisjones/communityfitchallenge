using System;
using CommunityFitChallenge.Web.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CommunityFitChallenge.Web.Areas.Identity.IdentityHostingStartup))]
namespace CommunityFitChallenge.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<CommunityFitChallengeWebContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("CommunityFitChallengeWebContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<CommunityFitChallengeWebContext>();
            });
        }
    }
}