﻿using Squad.Service.Implementations;
using Squad.Service.Interfaces;

namespace Squad.API.Extension
{
    public static class ServiceExtensions
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IHabariService, HabariService>();
            services.AddScoped<IAuthService, AuthService>();

        }
    }
}
