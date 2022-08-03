using Project.ENTITIES.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.DAL.IRepository
{
    public interface IUserRepository:IRepository<User>
    {
        Task<IEnumerable<User>> GetUserAsync();
        Task<User> GetByIdUserAsync(int id);
    }
}
