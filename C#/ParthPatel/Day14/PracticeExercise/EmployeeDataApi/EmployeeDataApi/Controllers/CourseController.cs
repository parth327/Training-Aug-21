using AutoMapper;
using EmployeeDataApi.EmployeeData;
using EmployeeDataApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace EmployeeDataApi.Controllers
{
    [Route("api/EmployeesData/{id}/courses")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IEmployeeData _employeeData;
        private readonly IMapper _mapper;

        public CourseController(IEmployeeData employeeData,
            IMapper mapper)
        {
            _employeeData = employeeData ??
                throw new ArgumentNullException(nameof(EmployeeData));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        //[HttpGet]
        //public ActionResult<IEnumerable<CourseDetail>> GetCoursesForEmployee(Guid employeeId)
        //{
        //    if (!_employeeData.EmployeeExists(employeeId))
        //    {
        //        return NotFound();
        //    }
        //    var coursesForEmpFromRepo = _employeeData.GetCoursees(employeeId);
        //    return Ok(_mapper.Map<IEnumerable<CourseDetail>>(coursesForEmpFromRepo));
        //}

        //[HttpGet]
        //[Route("GetEmployees/{id}")]
        //public IActionResult GetEmployee(Guid id)
        //{
        //    var employee = _employeeData.GetEmployee(id);

        //    if (employee != null)
        //    {
        //        return Ok(_mapper.Map<Employee>(employee));
        //    }
        //    return NotFound($"Employee with id : {id}");
        //}


        //[HttpPost]
        //[Route("PostEmployees")]
        //public IActionResult GetEmployee(Employee employee)
        //{
        //    _employeeData.AddEmployee(employee);

        //    return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + employee.Id,
        //        _mapper.Map<Employee>(employee));
        //}

        //[HttpDelete]
        //[Route("DeleteEmployees/{id}")]
        //public IActionResult DeleteEmployee(Guid id)
        //{
        //    var employee = _employeeData.GetEmployee(id);

        //    if (employee != null)
        //    {
        //        _employeeData.DeleteEmployee(employee);
        //        return Ok(_mapper.Map<Employee>(employee));
        //    }
        //    return NotFound($"Employee with id : {id} was not found");
        //}

        //[HttpPatch]
        //[Route("EditEmployees/{id}")]
        //public IActionResult EditEmployee(Guid id, Employee employee)
        //{
        //    var existingEmployee = _employeeData.GetEmployee(id);

        //    if (existingEmployee != null)
        //    {
        //        employee.Id = existingEmployee.Id;
        //        _employeeData.EditEmployee(employee);

        //    }
        //    return Ok(_mapper.Map<Employee>(employee));
        //}

    }
}
