using AutoMapper;

namespace EmployeeDataApi.Profiles
{
    public class CourcesProfile : Profile
    {
        public CourcesProfile()
        {
            CreateMap<Entities.CourseEntity, Models.CourseDetail>();
        }
    }
}
