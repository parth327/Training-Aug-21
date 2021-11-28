using EmployeeDataApi.Models;
using System;
using System.Collections.Generic;

namespace EmployeeDataApi.EmployeeData
{
    public interface IEmployeeData
    {
        List<Employee> GetEmployees();

        Employee GetEmployee(Guid id);
    
        Employee AddEmployee(Employee employee);

        void DeleteEmployee(Employee employee);

        Employee EditEmployee(Employee employee);

        
        CourseDetail GetCoursees(Guid id);
        //bool EmployeeExists(bool employeeId);
    }
}
