using AutoMapper;
using EmployeeDataApi.EmployeeData;
using EmployeeDataApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace EmployeeDataApi.Controllers
{
    [Route("api/EmployeesData")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeData _employeeData;
        private readonly IMapper _mapper;

        public EmployeesController(IEmployeeData employeeData,
            IMapper mapper)
        {
            _employeeData = employeeData;
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        [HttpHead]
        [Route("GetEmployees")]
        public ActionResult<IEnumerable<Employee>> GetEmployees( string mainCategory)
        {
            var employee = _employeeData.GetEmployees();
            
            return Ok(_mapper.Map<IEnumerable<Employee>>(employee));
        }

        [HttpGet]
        [Route("GetEmployees/{id}")]
        public IActionResult GetEmployee(Guid id)
        {
            var employee = _employeeData.GetEmployee(id);

            if (employee != null) 
            {
                return Ok(_mapper.Map<Employee>(employee));
            }
            return NotFound($"Employee with id : {id}");
        }


        [HttpPost]
        [Route("PostEmployees")]
        public IActionResult GetEmployee(Employee employee )
        {
            _employeeData.AddEmployee(employee);
            
            return Created(HttpContext.Request.Scheme +"://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + employee.Id,
                _mapper.Map<Employee>(employee));
        }

        [HttpDelete]
        [Route("DeleteEmployees/{id}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var employee = _employeeData.GetEmployee(id);

            if (employee != null)
            {
                _employeeData.DeleteEmployee(employee);
                return Ok(_mapper.Map<Employee>(employee));
            }
            return NotFound($"Employee with id : {id} was not found");
        }

        [HttpPatch]
        [Route("EditEmployees/{id}")]
        public IActionResult EditEmployee(Guid id, Employee employee)
        {
            var existingEmployee = _employeeData.GetEmployee(id);

            if (existingEmployee != null)
            {
                employee.Id = existingEmployee.Id;
                _employeeData.EditEmployee(employee);

            }
            return Ok(_mapper.Map<Employee>(employee));
        }
    }
}
