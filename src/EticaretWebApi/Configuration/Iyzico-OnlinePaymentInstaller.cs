using System;
using Application.Services;
using OnlineMuhasebeServer.Webapi.Configurations;

using OnlinePayment_Iyzico.Services;

namespace EticaretWebApi.Configuration
{
    public class Iyzico_OnlinePaymentInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPaymentService, PaymenyService>();
        }
    }
}

