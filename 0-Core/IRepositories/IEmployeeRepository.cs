using System;
using System.Collections.Generic;
using TASK.DAL.Models;

namespace TASK.Core.IRepositories
{
    public interface IEmployeeRepository 
    {
        List<Employee> GetAll();
        void Add(Employee entity);
        Employee FindById(Guid Id);
        Employee Update(Employee entity);
        void DeleteById(Guid Id);
    }
}
