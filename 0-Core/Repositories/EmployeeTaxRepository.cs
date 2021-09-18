using System;
using System.Collections.Generic;
using System.Linq;
using TASK.Core.IRepositories;
using TASK.DAL.Context;
using TASK.DAL.Models;

namespace TASK.Core.Repositories
{
    public class EmployeeTaxRepository: IEmployeeTaxRepository
    {
        protected readonly TaskDbContext _context;

        public EmployeeTaxRepository(TaskDbContext context)
        {
            _context = context;
        }

        public IEnumerable<EmployeeTax> GetAll()
        {
            return _context.Set<EmployeeTax>().ToList();
        }

        public void Add(EmployeeTax entity)
        {
            _context.Set<EmployeeTax>().Add(entity);
        }

        public EmployeeTax FindById(Guid Id)
        {
            return _context.Set<EmployeeTax>().Find(Id);
        }

        public EmployeeTax FindByEntity(EmployeeTax entity)
        {
            return _context.Set<EmployeeTax>().Find(entity);
        }

        public EmployeeTax Update(EmployeeTax entity)
        {
            _context.Set<EmployeeTax>().Update(entity);
            return FindByEntity(entity);
        }

        public void DeleteById(Guid Id)
        {
            var entity = FindById(Id);
            _context.Set<EmployeeTax>().Remove(entity);
        }
    }
}
