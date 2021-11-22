using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d12Prac
{
    class Program
    {
        static void Main(string[] args)
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
            DataAccessHelper dbHelper = new DataAccessHelper();
            dbHelper.AddDepartment(department);
            var addedDepartment = dbHelper.FetchDepartments().FirstOrDefault();
            if (addedDepartment != null)
            {
                Console.WriteLine("Department Name is: " + addedDepartment.DepartmentName + Environment.NewLine);
                Console.WriteLine("Department Employees are: " + Environment.NewLine);

                foreach (var addedDepartmentEmployee in addedDepartment.Employees)
                {
                    Console.WriteLine(addedDepartmentEmployee.EmployeeName + Environment.NewLine);
                }

                Console.ReadLine();
            }
        }
    }
}
