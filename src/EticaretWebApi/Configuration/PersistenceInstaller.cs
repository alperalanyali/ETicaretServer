using System;
using Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Webapi.Configurations;
using Persistence.Context;

namespace EticaretWebApi.Configuration
{
    public class PersistenceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                //options.UseSqlServer("Data Source=185.8.128.21;Initial Catalog=ecnorowc_alperalanyali;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Trusted_Connection=False;User ID=ecnorowc_alper;Password=Tn4!2rf03;");
                options.UseSqlServer("Data Source=localhost;Initial Catalog=ECommerce;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Trusted_Connection=False;User ID=sa;Password=metallica1;");
            });
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>();
            
        }
    }
}

