using System.Threading.Tasks;
using Rocket.Models;
using Rocket.Repository;
using System.Linq;

namespace Rocket.Interface.Repositories
{
    public interface IUserRepository 
    {

        Task<User> GetUserById(int id);
     
        // bool ExisteCpf(string cpf);
        // void BeginTransaction();
        // void Commit();
        // void Rollback();
    }
}
