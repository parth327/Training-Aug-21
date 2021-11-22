using System.Collections.Generic;

namespace d12Prac_Migration.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<d12Prac_Migration.CodeFirstContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(d12Prac_Migration.CodeFirstContext context)
        {
            Department department = new Department
            {
                DepartmentName = "Technology",
                Employees = new List<Employee>
                {
                    new Employee() {EmployeeName = "Jack"},
                    new Employee() {EmployeeName = "Kim"},
                    new Employee() {EmployeeName = "Shen"}
                }
            };

            Employee employee = new Employee
            {
                EmployeeName = "Akhil Mittal",
                DepartmentId = 1
            };

            context.Departments.AddOrUpdate(department);
            context.Employees.AddOrUpdate(employee);
        }
    }
}
