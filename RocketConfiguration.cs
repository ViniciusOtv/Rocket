// using System;
// using System.Collections.Generic;
// using System.Data.SqlClient;
// using Microsoft.Extensions.DependencyInjection;
// using Microsoft.Extensions.Options;
// using Rocket.Repository;
// using Rocket.Settings;

// namespace Rocket
// {
//     public class RocketConfiguration
//     {
//         public static void ConfigurationServices(IServiceCollection services)
//         {
//             //Context
//             services.AddTransient(typeof(UserContext), x => new UserContext(new SqlConnection(x.GetService<IOptions<ConnectionStrings>>().Value.UserApp)));
            
//         }
//     }
// }