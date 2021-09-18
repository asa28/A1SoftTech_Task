using Microsoft.EntityFrameworkCore;
using System;
using TASK.DAL.Models;

namespace TASK.DAL.Seeding_Data
{
    public static class EmployeeSeedData
    {

        public static void EmployeeSeed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Employee>().HasData(
                
                new Employee()
                {
                    Id = new Guid ("f138a31e-3c81-481e-92de-d873d020b4d4"),
                    Name = "Ahmed",
                    Email = "ahmadsabry28@gmail.com",
                    Salary = 6000,
                    Mobile = 01119790023
                },

                new Employee()
                {
                    Id = new Guid("80a83d08-b6fa-477a-801b-06ec518a12b9"),
                    Name = "Sabry",
                    Email = "ahmadsabry28@hotmail.com",
                    Salary = 7000,
                    Mobile = 01119790023
                },

                new Employee()
                {
                    Id = new Guid("cc24fc2d-9a8b-41f9-87ba-1b6c9112a7b8"),
                    Name = "AhmedSabry",
                    Email = "ahmadsabry28@yahoo.com",
                    Salary = 8000,
                    Mobile = 01119790023
                },

                new Employee()
                {
                    Id = new Guid("e8a5a26b-26ab-4a16-b280-60afcc5b56f9"),
                    Name = "Ahmed",
                    Email = "ahmadsabry28@msn.com",
                    Salary = 9000,
                    Mobile = 01119790023
                }

             );

        }

    }
}
