using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalTask.Assignment.Models;

namespace HospitalTask
{
    public class Hospital
    {
        public static void addNewDoctor()
        {
            using (var dbContext = new HospitalDatabaseContext())
            {
                Console.WriteLine("Enter Doctor Name");
                var doctorName = Console.ReadLine();
                var departmentId = 1;

                var newdoctor = new Doctor
                {
                    DoctorName = doctorName,
                    DepartmentId = departmentId
                };
                dbContext.Doctor.Add(newdoctor);
                dbContext.SaveChanges();
                Console.WriteLine("Success");
                
            }
        }

        public static void updateDoctor()
        {
            using (var dbContext = new HospitalDatabaseContext())
            {
                var getDoctorlist = dbContext.Doctor.ToList();
                Console.WriteLine("List of Doctor:");
                foreach (var doctor in getDoctorlist)
                {
                    Console.WriteLine($"DoctorId:{doctor.DoctorId}  DoctorName : {doctor.DoctorName}");
                }
                Console.WriteLine("Select DoctorId :");
               var doctorId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Doctor Name:");
                var doctorName = Console.ReadLine();
                var doctorDetail = dbContext.Doctor.Where(x => x.DoctorId == doctorId).FirstOrDefault();
                doctorDetail.DoctorName = doctorName;
                dbContext.SaveChanges();
                Console.WriteLine("Update Doctor.");
            }
        }

        public static void DeleteDoctorDetail()
        {
            using (var dbContext = new HospitalDatabaseContext())
            {
                var getDoctorlist = dbContext.Doctor.ToList();
                Console.WriteLine("List of Doctor:");
                foreach (var doctor in getDoctorlist)
                {
                    Console.WriteLine($"DoctorId:{doctor.DoctorId}  DoctorName : {doctor.DoctorName}");
                }
                Console.WriteLine("Select DoctorId :");
                var doctorId = Convert.ToInt32(Console.ReadLine());
                var deleteDoctorId = dbContext.Doctor.Where(x => x.DoctorId == doctorId).FirstOrDefault();
                dbContext.Remove(deleteDoctorId);
                dbContext.SaveChanges();
            }
            
        }
    }
}
