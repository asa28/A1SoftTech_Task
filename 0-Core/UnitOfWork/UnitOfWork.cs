using TASK.DAL.Context;
using TASK.Core.IRepositories;
using TASK.Core.Repositories;

namespace TASK.Core.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly TaskDbContext _context;
        private IEmployeeRepository _employeeRepository;
        private IEmployeeTaxRepository _employeeTaxRepository;



        public IEmployeeRepository EmployeeRepository {
            get { 
                return _employeeRepository = _employeeRepository ?? new EmployeeRepository(_context); 
            }
        }

        public IEmployeeTaxRepository EmployeeTaxRepository { 
            get {
                return _employeeTaxRepository = _employeeTaxRepository ?? new EmployeeTaxRepository(_context);
            } 
        }

        public UnitOfWork(TaskDbContext context)
        {
            _context = context;
        }





        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}