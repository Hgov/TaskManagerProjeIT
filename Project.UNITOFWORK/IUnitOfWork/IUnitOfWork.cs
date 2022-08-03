using Project.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.UNITOFWORK.IUnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository userRepository { get; }
        IRoleRepository roleRepository { get; }
        int Complete();
    }
}
