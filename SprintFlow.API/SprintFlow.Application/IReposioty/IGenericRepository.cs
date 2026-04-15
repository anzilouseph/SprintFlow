using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprintFlow.Application.IReposioty
{
    public  interface IGenericRepository <T> where T : class
    {
        public IQueryable<T> GetAll();
        public Task Add(T entity);
        public void Update(T entity);
        public Task SaveChanges();
    }
}
