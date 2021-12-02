using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace HospitalAuth.Profiles
{
    public class DoctorProfile : Profile
    {
            public DoctorProfile()
            {
                CreateMap<Models.DoctorForCreationDto, Models.Doctor>();
            }
    }
}