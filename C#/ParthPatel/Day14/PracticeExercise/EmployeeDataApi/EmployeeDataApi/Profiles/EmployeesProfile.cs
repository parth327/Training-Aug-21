using AutoMapper;

namespace EmployeeDataApi.Profiles
{
    public class EmployeesProfile : Profile
    {
        public EmployeesProfile()
        {
            CreateMap<Entities.EmpEntity, Models.Employee>()
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => $"{src.Name}"));
        }
    }
}
