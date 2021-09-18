using System;
using System.Collections.Generic;
using System.Linq;
using TASK.Core.IRepositories;
using TASK.DAL.Context;
using TASK.DAL.Models;

namespace TASK.Core.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        protected readonly TaskDbContext _context;

        public EmployeeRepository(TaskDbContext context)
        {
            _context = context;
        }

        public List<Employee> GetAll()
        {
            return _context.Set<Employee>().ToList();
        }

        public void Add(Employee entity)
        {
            _context.Set<Employee>().Add(entity);
        }

        public Employee FindById(Guid Id)
        {
            return _context.Set<Employee>().Find(Id);
        }

        public Employee FindByEntity(Employee entity)
        {
            return _context.Set<Employee>().Find(entity);
        }

        public Employee Update(Employee entity)
        {
            _context.Set<Employee>().Update(entity);
            return FindByEntity(entity);
        }

        public void DeleteById(Guid Id)
        {
            var entity = FindById(Id);
            _context.Set<Employee>().Remove(entity);            
        }
    }
}
