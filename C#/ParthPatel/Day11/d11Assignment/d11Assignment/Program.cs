using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HospitalTask.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("For Insert,Update or delete a doctor , press 1 or other wise enter any key");
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Enter 1 for Inserting a doctor\n" +
                    "Enter 2 for Update a Doctor\n" +
                    "Enter 3 for Delete a Doctor");

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InsertDoctor();
                        break;
                    case 2:
                        UpdateDoctor();
                        break;
                    case 3:
                        DeleteDoctor();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }

            Console.WriteLine("Enter 1 for report patient assigned to a particular doctor");
            Console.WriteLine("Enter 2 for report of medicine list for a particular patient");
            Console.WriteLine("Enter 3 report of Doctor and patient");

            choice = Convert.ToInt32(Console.ReadLine());

            using (var context = new HospitalTaskDBContext())
            {
                switch (choice)
                {
                    case 1:
                        context.Doctors
                            .Join(context.DoctorPatient,
                            d => d.PatientId,
                            p => p.DoctorId,
                            (d, p) => new
                            {
                                Doctor = d.DoctorName,
                                Patient = p.Patient.PatientName
                            })
                            .ToList().ForEach(c => Console.WriteLine(c));
                        break;
                    case 2:
                        context.PatientMedicineList
                            .Join(context.DoctorPatient,
                            m => m.ListID,
                            p => p.PatientDoctorID,
                            (m, p) => new {
                                Patient = p.Patient.PatientName,
                                MedicineSchedule = m.Medicine.MedicineName,
                                Daypart = m.Daypart
                            })
                            .ToList().ForEach(c => Console.WriteLine(c));
                        break;
                    case 3:
                        var collection = context.DoctorPatient
                            .Include(p => p.Doctor)
                            .Include(p => p.Patient)
                            .ToList();
                        collection.ForEach(c => Console.WriteLine($"Doctor {c.Doctor.DoctorName} Patient {c.Patient.PatientName}"));
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }



        }

        private static void DeleteDoctor()
        {
            Console.WriteLine("Enter Id of Doctor to delete");
            int DoctorID = Convert.ToInt32(Console.ReadLine());

            using (var context = new HospitalTaskDBContext())
            {
                var Doctor = context.Doctors.Find(DoctorID);

                if (Doctor == null)
                {
                    Console.WriteLine("Sorry the Doctor does't exist in the database");
                }
                else
                {
                    Console.WriteLine("the Doctor with following detail is deleted");
                    Console.WriteLine($"DoctorName: {Doctor.DoctorName}");
                    Console.WriteLine($"Department: {Doctor.DepartmentId}");

                    context.Remove(Doctor);
                    context.SaveChanges();
                }
            }
        }

        private static void UpdateDoctor()
        {
            Console.WriteLine("Enter Id of Doctor to update");
            int DoctorID = Convert.ToInt32(Console.ReadLine());

            using (var context = new HospitalTaskDBContext())
            {
                var Doctor = context.Doctors.Find(DoctorID);

                if (Doctor == null)
                {
                    Console.WriteLine("Sorry the doctor does't exist in the database");
                }
                else
                {
                    Console.WriteLine("Enter 1 for change DoctorName");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter firstName");
                            string DoctorName = Console.ReadLine();
                            Console.WriteLine($"OldDoctorName{Doctor.DoctorName} newFirstName{DoctorName}");
                            Doctor.DoctorName = DoctorName;
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }

                context.SaveChanges();

            }

        }

        private static void InsertDoctor()
        {
            Console.WriteLine("Enter Name of Doctor");
            string DoctorName = Console.ReadLine();
            Console.WriteLine("Enter DepartmentId of Doctor");
            int DepartmentId = Convert.ToInt32(Console.ReadLine());

            using (var context = new HospitalTaskDBContext())
            {
                var Doctor = new Doctor()
                {
                    DoctorName = DoctorName,
                    DepartmentId = DepartmentId
                };

                context.Doctor.Add(Doctor);
                context.SaveChanges();
            }
        }
    }
}
