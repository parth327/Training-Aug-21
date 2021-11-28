using EmployeeDataApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeDataApi.EmployeeData
{
    public class MockEmployeeData : IEmployeeData
    {
        private readonly List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Employee One"
            },
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Employee Two"
            }
        };

        public Employee AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            employees.Add(employee);
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public Employee EditEmployee(Employee employee)
        {
            var existingEmployee = GetEmployee(employee.Id);
            existingEmployee.Name = employee.Name;
            return existingEmployee;
        }

        public bool EmployeeExists(Guid employeeId)
        {
            throw new NotImplementedException();
        }

        public CourseDetail GetCoursees(Guid id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(Guid id)
        {
            return employees.SingleOrDefault(x => x.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
        //Employee IEmployeeData.AddEmployee(Employee employee)
        //{
        //    throw new NotImplementedException();
        //}

        //void IEmployeeData.DeleteEmployee(Employee employee)
        //{
        //    throw new NotImplementedException();
        //}

        //Employee IEmployeeData.EditEmployee(Employee employee)
        //{
        //    throw new NotImplementedException();
        //}

        //Employee IEmployeeData.GetEmployee(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //List<Employee> IEmployeeData.GetEmployees()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
