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
                options.UseSqlServer(configuration.GetConnectionString("SqlServer"));
            });
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>();
            
        }
    }
}

