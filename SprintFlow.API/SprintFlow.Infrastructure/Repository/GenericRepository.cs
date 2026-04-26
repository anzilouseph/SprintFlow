using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SprintFlow.Application.IReposioty;
using SprintFlow.Infrastructure.Context;

namespace SprintFlow.Infrastructure.Repository
{
    public class GenericRepository <T> :IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _dbcontext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
            _dbSet = dbcontext.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable();
        }
        public async Task Add (T entity)
        {
             await _dbSet.AddAsync(entity);
        }
        public void Update(T entity)
        {
             _dbSet.Update(entity);
        }
        public async Task SaveChanges()
        {
            await _dbcontext.SaveChangesAsync();
        }
    }
}
