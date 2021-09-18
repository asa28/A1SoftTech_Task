using Microsoft.EntityFrameworkCore;
using TASK.DAL.Models;
using TASK.DAL.Seeding_Data;

namespace TASK.DAL.Context
{
    public class TaskDbContext:DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> opt) : base(opt) { }


        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeTax> EmployeeTaxs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.EmployeeSeed();
            modelBuilder.EmployeeTaxSeed();
        }
    }
}
