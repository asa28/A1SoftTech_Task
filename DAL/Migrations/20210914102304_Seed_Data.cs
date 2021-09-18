using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TASK.DAL.Migrations
{
    public partial class Seed_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EmployeeTaxs",
                columns: new[] { "Id", "EmpId", "NetSalary", "Tax" },
                values: new object[,]
                {
                    { new Guid("55b29ec5-b130-4c96-acf0-e946a49b4a72"), new Guid("f138a31e-3c81-481e-92de-d873d020b4d4"), 600f, 50f },
                    { new Guid("51feccbb-929e-4aa6-9e2d-dc9dfa0c0ed4"), new Guid("80a83d08-b6fa-477a-801b-06ec518a12b9"), 700f, 50f }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "Mobile", "Name", "Salary" },
                values: new object[,]
                {
                    { new Guid("f138a31e-3c81-481e-92de-d873d020b4d4"), "ahmadsabry28@gmail.com", 1119790023, "Ahmed", 6000f },
                    { new Guid("80a83d08-b6fa-477a-801b-06ec518a12b9"), "ahmadsabry28@hotmail.com", 1119790023, "Sabry", 7000f },
                    { new Guid("cc24fc2d-9a8b-41f9-87ba-1b6c9112a7b8"), "ahmadsabry28@yahoo.com", 1119790023, "AhmedSabry", 8000f },
                    { new Guid("e8a5a26b-26ab-4a16-b280-60afcc5b56f9"), "ahmadsabry28@msn.com", 1119790023, "Ahmed", 9000f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeTaxs",
                keyColumn: "Id",
                keyValue: new Guid("51feccbb-929e-4aa6-9e2d-dc9dfa0c0ed4"));

            migrationBuilder.DeleteData(
                table: "EmployeeTaxs",
                keyColumn: "Id",
                keyValue: new Guid("55b29ec5-b130-4c96-acf0-e946a49b4a72"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("80a83d08-b6fa-477a-801b-06ec518a12b9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("cc24fc2d-9a8b-41f9-87ba-1b6c9112a7b8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e8a5a26b-26ab-4a16-b280-60afcc5b56f9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f138a31e-3c81-481e-92de-d873d020b4d4"));
        }
    }
}
