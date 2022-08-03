using Microsoft.EntityFrameworkCore;
using Project.DAL.Helpers;
using Project.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected ProjectDBContext _Context;
        private DbSet<TEntity> _dbSet;

        public Repository(ProjectDBContext context)
        {
            this._Context = context;
            this._dbSet = _Context.Set<TEntity>();
        }
        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public TEntity GetByID(int id)
        {
            return _dbSet.FindAsync(id).Result;
        }
        public void RemoveAsync(int id)
        {
            _dbSet.Remove(GetByID(id));
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public void update(TEntity entity)
        {
            _dbSet.Attach(entity);
        }
        public async Task<int> CountAsync()
        {
            return await _dbSet.CountAsync();
        }

    }
}
