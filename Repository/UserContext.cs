using Microsoft.EntityFrameworkCore;
using Rocket.Models;

namespace Rocket.Repository
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }       

       public DbSet<User> Users { get; set; } 
    }
}