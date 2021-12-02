using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalAuth.Models;

namespace HospitalAuth.Respository
{
    public interface IHospitalRepository
    {
        IEnumerable<Doctor> GetDoctors();
        void AddDoctor(Doctor doctor);
        bool Save();
        Doctor GetDoctor(int doctorId);
        void DeleteDoctor(Doctor doctorToDelete);
    }
}
