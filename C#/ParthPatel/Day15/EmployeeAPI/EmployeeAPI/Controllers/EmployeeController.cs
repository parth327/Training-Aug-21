using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeAPI.Repository;
using EmployeeAPI.Model;

namespace EmployeeAPI.Controllers
{
    [ApiController]
    [Route("api/emps")]
    [Produces("application/json")]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeRepostiory _employeeServices;
        public EmployeeController(IEmployeeRepostiory employeeServices)
        {
            this._employeeServices = employeeServices;
        }

        //create new employee
        [Route("createEmployee")]
        [HttpPost]
        public string CreateNewEmployee([FromBody] EmpModel employeeModel)
        {
            var response = "";
            try
            {
                if (employeeModel != null)
                {
                    response = _employeeServices.addNewEmployee(employeeModel);
                    if (response == null)
                    {
                        return NotFound().ToString();
                    }
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Get all employee list
        [Route("GetAllEmployee")]
        [HttpGet]
        public List<EmpModel> GetAllEmployees()
        {
            List<EmpModel> response;
            try
            {
                response = _employeeServices.getEmployeeList();
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }


        //Get Employee Detail by EmployeeId
        [Route("GetEmployee/{employeeId}")]
        [HttpGet]
        public EmpModel GetEmployeesById(Int64 employeeId)
        {
            var response = new EmpModel();
            try
            {
                if (employeeId != 0 && employeeId > 0)
                {
                    response = _employeeServices.getEmployeeById(employeeId);
                    return response;
                }
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}




