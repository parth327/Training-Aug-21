using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeAPI.Repository;
using EmployeeAPI.Model;

namespace EmployeeAPI.Controller
{
    [ApiController]
    [Route("api/emps")]
    [Produces("application/json")]
    public class AssignmentController : ControllerBase
    {
        private IAssignmentRepository _assignmentServices;
        public AssignmentController(IAssignmentRepository assignmentServices)
        {
            this._assignmentServices = assignmentServices;
        }

        //create new Assignment by employeeId
        [Route("{employeeId}/child/assignments")]
        [HttpPost]
        public string CreateNewAssignment(Int64 employeeId, [FromBody] AssignModel assignmentModel)
        {
            var response = "";
            try
            {
                if (assignmentModel != null)
                {
                    response = _assignmentServices.createNewAssignment(employeeId, assignmentModel);
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

        //get all assignment 
        [Route("{employeeId}/child/assignment")]
        [HttpGet]
        public List<AssignModel> GetAllAssignment(Int64 employeeId)
        {
            var response = new List<AssignModel>();
            try
            {
                if (employeeId != 0 && employeeId > 0)
                {
                    response = _assignmentServices.getAllAssignment(employeeId);
                    return response;
                }
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }


        //get assignment by employeeId and assignmentId
        [Route("{employeeId}/child/assignments/{assignmentId}")]
        [HttpGet]
        public AssignModel GetEmployeeAllAssignment(Int64 employeeId, Int64 assignmentId)
        {
            var response = new AssignModel();
            try
            {
                if (assignmentId != 0 && employeeId != 0 && employeeId > 0 && assignmentId > 0)
                {
                    response = _assignmentServices.getAssignment(employeeId, assignmentId);
                    return response;
                }
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //update assignment by employeeId and assignmentId
        [Route("{employeeId}/child/assignment/{assignmentId}")]
        [HttpPut]
        public string UpdateAssignment(Int64 employeeId, Int64 assignmentId, AssignModel assignmentModel)
        {
            var response = "";
            try
            {
                if (assignmentId != 0 && employeeId != 0 && employeeId > 0 && assignmentId > 0 && assignmentModel != null)
                {
                    response = _assignmentServices.updateAssignment(employeeId, assignmentId, assignmentModel);
                    if (response == null)
                    {
                        return NotFound().ToString();
                    }
                    return response;
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}

