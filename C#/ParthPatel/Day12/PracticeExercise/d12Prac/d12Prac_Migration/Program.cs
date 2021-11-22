using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d12Prac_Migration
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeFirstContext context = new CodeFirstContext();

            Department department = new Department
            {
                DepartmentName = "Management",
                Employees = new List<Employee>
                {
                    new Employee() {EmployeeName = "Hui"},
                    new Employee() {EmployeeName = "Dui"},
                    new Employee() {EmployeeName = "Lui"}
                }
            };
            context.Departments.Add(department);
            context.SaveChanges();
        }
    }
}
