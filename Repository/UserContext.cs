using System.Data;
using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;
using Rocket.Models;

namespace Rocket.Repository
{
    public class UserContext : ConnectionContext
    {
        public UserContext(IDbConnection dbConnection) : base(dbConnection)
        {
        }        
    }
}