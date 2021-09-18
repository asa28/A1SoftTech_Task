using System;
using TASK.Core.IRepositories;

namespace TASK.Core.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        public IEmployeeRepository EmployeeRepository { get; }
        public IEmployeeTaxRepository EmployeeTaxRepository { get; }




        void SaveChanges();
    }
}
