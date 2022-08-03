using Project.DAL.Helpers;
using Project.DAL.IRepository;
using Project.DAL.Repository;

namespace Project.UNITOFWORK.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork.IUnitOfWork
    {
        private ProjectDBContext _ProjectDBContext;
        public UnitOfWork(ProjectDBContext projectDBContext)
        {
            _ProjectDBContext = projectDBContext;
            userRepository = new UserRepository(_ProjectDBContext);
            roleRepository = new RoleRepository(_ProjectDBContext);
        }

        public IUserRepository userRepository { get; private set; }

        public IRoleRepository roleRepository { get; private set; }

        public int Complete()
        {

            return _ProjectDBContext.SaveChanges();
        }

        public void Dispose()
        {
            _ProjectDBContext.Dispose();
        }
    }
}
