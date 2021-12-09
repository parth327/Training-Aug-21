using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeAPI.Model;
using EmployeeAPI.Models;

namespace EmployeeAPI.Repository
{
    public class EmployeeRepository : IEmployeeRepostiory
    {
        public EmployeeDBContext dbContext { get; set; }
        public EmployeeRepository(EmployeeDBContext employeeDBContext)
        {
            this.dbContext = employeeDBContext;
        }
        public string addNewEmployee(EmpModel employeeModel)
        {
            var newEmployee = new Employee()
            {
                FirstName = employeeModel.FirstName,
                LastName = employeeModel.LastName,
                AddressLine1 = employeeModel.AddressLine1,
                City = employeeModel.City,
                Country = employeeModel.Country
            };
            
            dbContext.Employees.Add(newEmployee);
            dbContext.SaveChanges();
            return "Successfully add new employee";
        }

        public List<EmpModel> getEmployeeList()
        {
            var employeesList = new List<EmpModel>();

            employeesList = dbContext.Employees.Select(x => new EmpModel()
            {
                EmployeeId = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                City = x.City,
                Country = x.Country,
                AddressLine1 = x.AddressLine1
            }).ToList();
            return employeesList;
        }

        public EmpModel getEmployeeById(Int64 employeeId)
        {
            var employeeDetail = new EmpModel();

            employeeDetail = dbContext.Employees.Select(x => new EmpModel()
            {
                EmployeeId = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                City = x.City,
                Country = x.Country,
                AddressLine1 = x.AddressLine1
            }).Where(x => x.EmployeeId == employeeId).FirstOrDefault();

            return employeeDetail;
        }

        public string updateEmployeeDetail(EmpModel employeeModel)
        {
            var employeeDetail = dbContext.Employees.Where(x => x.Id == employeeModel.EmployeeId).FirstOrDefault();
            employeeDetail.FirstName = employeeModel.FirstName;
            employeeDetail.LastName = employeeModel.LastName;
            employeeDetail.City = employeeModel.City;
            employeeDetail.Country = employeeModel.Country;
            employeeDetail.AddressLine1 = employeeModel.AddressLine1;
            dbContext.SaveChanges();
            return "Successfully update employee detail";
        }
    }
}


