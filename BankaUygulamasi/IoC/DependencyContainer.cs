using Banka.Application.Interfaces;
using Banka.Application.Services;
using Banka.Data.Context;
using Banka.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application
            services.AddTransient<IHesapServisi, HesapServisi>();

            // Data
            services.AddTransient<IHesapRepository, HesapRepository>();
            services.AddTransient<BankaDbContext>();
        }
    }
}
