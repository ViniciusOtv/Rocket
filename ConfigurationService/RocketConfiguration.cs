using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Rocket.Interface.Repositories;
using Rocket.Interface.Services;
using Rocket.Report.Results;
using Rocket.Repository;
using Rocket.Services;
using Rocket.Settings;

namespace RocketConfiguration
{
    public static class RocketConfiguration
    {
        public static void ServiceConfig(this IServiceCollection services)
        {
            //Context
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient(p => new ErrorBuilder());
          
        }
    }
}