using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SprintFlow.Application.IReposioty;
using SprintFlow.Domain.Entity;

namespace SprintFlow.Application
{
    public interface IUnitOfWork
    {
       public  IGenericRepository<Login> Logins { get; }
       public IGenericRepository<Employee> Employees { get; }

    }
}
