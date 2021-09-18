using System;
using System.Collections.Generic;
using TASK.DAL.Models;

namespace TASK.Core.IRepositories
{
    public interface IEmployeeTaxRepository
    {
        IEnumerable<EmployeeTax> GetAll();
        void Add(EmployeeTax entity);
        EmployeeTax FindById(Guid Id);
        EmployeeTax Update(EmployeeTax entity);
        void DeleteById(Guid Id);
    }
}
