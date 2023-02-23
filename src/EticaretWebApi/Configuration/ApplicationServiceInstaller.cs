using System;
using MediatR;
using System.Reflection.Metadata;
using OnlineMuhasebeServer.Webapi.Configurations;

namespace EticaretWebApi.Configuration
{
    public class ApplicationServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(cfr => cfr.RegisterServicesFromAssembly(typeof(Application.AssemblyReference).Assembly));

            //services.AddTransient(typeof(IPipelineBehavior<,>), (typeof(ValidationBehavior<,>)));

            //services.AddValidatorsFromAssembly(typeof(AssemblyReference).Assembly);
        }
    }
}

