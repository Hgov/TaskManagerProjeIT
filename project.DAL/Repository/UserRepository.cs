using Microsoft.EntityFrameworkCore;
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
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ProjectDBContext projectDBContext) : base(projectDBContext)
        {

        }
        public ProjectDBContext ProjectDBContext { get { return _Context as ProjectDBContext; } }
        public async Task<User> GetByIdUserAsync(int id)
        {
            return await _Context.Users
               .Where(x => x.user_id == id)
               .Include(x => x.Role)
               .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<User>> GetUserAsync()
        {
            return await _Context.Users
                .Include(x => x.Role)
                .ToListAsync();
        }
    }
}
