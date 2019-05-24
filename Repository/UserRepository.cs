using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rocket.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Rocket.Interface.Services;
using Rocket.Interface.Repositories;
using Rocket.Report.Results;
using Rocket.Report.Services;

namespace Rocket.Repository
{
    public class UserRepository : IUserRepository
    {
        private IConfiguration _config;
        public Task<User> GetUserById(int id)
        {
            using (SqlConnection connection = new SqlConnection(
                _config.GetConnectionString("Rocket_Dev")))
            {
                return connection.QueryFirstOrDefaultAsync<User>(
                    "SELECT * FROM USERS (NOLOCK) WHERE = @id", new { id });
            }
        }
    }
}