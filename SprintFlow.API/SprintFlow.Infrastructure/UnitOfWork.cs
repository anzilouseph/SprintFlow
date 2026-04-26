using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SprintFlow.Application;
using SprintFlow.Application.IReposioty;
using SprintFlow.Domain.Entity;
using SprintFlow.Infrastructure.Context;
using SprintFlow.Infrastructure.Repository;



namespace SprintFlow.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext; 
        }

        public IGenericRepository<Login> Logins => new GenericRepository<Login>(_dbContext);
        public IGenericRepository<Employee> Employees => new GenericRepository<Employee>(_dbContext);   
        public IGenericRepository<Role> Roles => new GenericRepository<Role>(_dbContext);
    }
}
