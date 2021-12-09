using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeAPI.Model;

namespace EmployeeAPI.Repository
{
    public interface IEmployeeRepostiory
    {
        string addNewEmployee(EmpModel employeeModel);
        List<EmpModel> getEmployeeList();
        EmpModel getEmployeeById(Int64 employeeId);
        string updateEmployeeDetail(EmpModel employeeModel);

    }
}
