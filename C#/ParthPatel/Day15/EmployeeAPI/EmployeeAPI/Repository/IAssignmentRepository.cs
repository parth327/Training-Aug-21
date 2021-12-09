using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeAPI.Model;

namespace EmployeeAPI.Repository
{
    public interface IAssignmentRepository
    {
        string createNewAssignment(Int64 employeeId, AssignModel assignmentModel);
        List<AssignModel> getAllAssignment(Int64 employeeId);
        AssignModel getAssignment(Int64 employeeId, Int64 assignmentId);
        string updateAssignment(Int64 employeeId, Int64 assignmentId, AssignModel assignmentModel);
    }
}
