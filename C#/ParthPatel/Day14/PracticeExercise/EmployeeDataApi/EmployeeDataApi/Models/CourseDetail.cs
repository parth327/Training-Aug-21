using System;

namespace EmployeeDataApi.Models
{
    public class CourseDetail
    {
        public Guid Id { get; set; }
        
        public string Title { get; set; }

        public string Description { get; set; }
        
        public Guid EmployeeId { get; set; }
    }
}
