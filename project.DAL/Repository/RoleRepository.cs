using Project.DAL.Helpers;
using Project.DAL.IRepository;
using Project.ENTITIES.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repository
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(ProjectDBContext ProjectDBContext):base(ProjectDBContext)
        {

        }
        public ProjectDBContext ProjectDBContext { get { return _Context as ProjectDBContext; } }
        public Task<Role> GetByIdRoleAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Role>> GetRoleAsync()
        {
            throw new NotImplementedException();
        }
    }
}
