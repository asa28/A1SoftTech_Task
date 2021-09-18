using Microsoft.EntityFrameworkCore.Migrations;

namespace TASK.DAL.Migrations
{
    public partial class AddRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTaxs_EmpId",
                table: "EmployeeTaxs",
                column: "EmpId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTaxs_Employees_EmpId",
                table: "EmployeeTaxs",
                column: "EmpId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTaxs_Employees_EmpId",
                table: "EmployeeTaxs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTaxs_EmpId",
                table: "EmployeeTaxs");
        }
    }
}
