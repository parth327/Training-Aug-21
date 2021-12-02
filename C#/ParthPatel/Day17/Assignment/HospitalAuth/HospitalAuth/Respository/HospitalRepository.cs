using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalAuth.Models;

namespace HospitalAuth.Respository
{
    public class HospitalRepository : IHospitalRepository
    {
        private readonly HospitalDBContext _context;

        public HospitalRepository(HospitalDBContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public void AddDoctor(Doctor doctor)
        {
            if (doctor == null)
            {
                throw new ArgumentNullException(nameof(doctor));
            }
            _context.Doctor.Add(doctor);
        }

        public void DeleteDoctor(Doctor doctorToDelete)
        {
            _context.Doctor.Remove(doctorToDelete);
        }

        public Doctor GetDoctor(int doctorId)
        {
            if (doctorId <= 0)
            {
                throw new ArgumentNullException(nameof(Doctor));
            }
            return _context.Doctor.FirstOrDefault(a => a.DoctorId == doctorId);
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctor.ToList<Doctor>();
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
