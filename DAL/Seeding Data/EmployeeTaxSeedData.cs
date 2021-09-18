using Microsoft.EntityFrameworkCore;
using System;
using TASK.DAL.Models;

namespace TASK.DAL.Seeding_Data
{
    public static class EmployeeTaxSeedData
    {

        public static void EmployeeTaxSeed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<EmployeeTax>().HasData(
                                
                new EmployeeTax()
                { 
                    Id = new Guid("55b29ec5-b130-4c96-acf0-e946a49b4a72"),
                    EmpId = new Guid("f138a31e-3c81-481e-92de-d873d020b4d4"),
                    Tax = 50,
                    NetSalary = 600, 
                },

                new EmployeeTax()
                {
                    Id = new Guid("51feccbb-929e-4aa6-9e2d-dc9dfa0c0ed4"),
                    EmpId = new Guid("80a83d08-b6fa-477a-801b-06ec518a12b9"),
                    Tax = 50,
                    NetSalary = 700,
                }

            );

        }

    }
}
