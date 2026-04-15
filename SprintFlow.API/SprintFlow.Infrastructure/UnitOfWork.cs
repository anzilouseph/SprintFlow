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
        public readonly AppDbContext _dbContext;
        public IGenericRepository<Employee> Employees { get; }
        public IGenericRepository<Login> Logins { get; }

        public  IGenericRepository<Role> Roles { get; }


        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            Employees = new GenericRepository<Employee>(_dbContext);
            Logins = new GenericRepository<Login>(_dbContext);
            Roles = new GenericRepository<Role>(_dbContext);
        }
    }
}
