using Project.ENTITIES.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.IRepository
{
    public interface IRoleRepository:IRepository<Role>
    {
        Task<IEnumerable<Role>> GetRoleAsync();
        Task<Role> GetByIdRoleAsync(int id);
    }
}
