using HospitalManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;
using HospitalManagement.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Repository
{
    public class HospitalRepository : IHospitalRepository
    {
        public apiContext dbContext { get; set; }
        public HospitalRepository(apiContext apiContext)
        {
            this.dbContext = apiContext;
        }

        //Department Services

        //Get All Departments List
        public List<DepartmentModel> getDepartmentList()
        {
            var departmentList = new List<DepartmentModel>();

            departmentList = dbContext.Department.Where(x => x.IsDelete == false)
                .Select(x => new DepartmentModel()
                {
                    DepartmentId = x.DepartmentId,
                    DepartmentName = x.DepartmentName,
                    IsActive = x.IsActive,
                    IsDelete = x.IsDelete,
                    OnCreated = x.OnCreated,
                    OnUpdated = x.OnUpdated
                }).ToList();
            return departmentList;
        }

        //Add New Department
        public string addNewDepartment(DepartmentModel departmentModel)
        {
            var newDepartment = new Department()
            {
                DepartmentId = departmentModel.DepartmentId,
                DepartmentName = departmentModel.DepartmentName,
                IsActive = true,
                IsDelete = false,
                OnCreated = DateTime.Now,
                OnUpdated = DateTime.Now
            };
            dbContext.Department.Add(newDepartment);
            dbContext.SaveChanges();
            return "New Department Inserted Successfully.";
        }

        //Delete Department
        public bool deleteDepartment(Guid departmentId)
        {
            var departmentDetail = dbContext.Department.FirstOrDefault(x => x.DepartmentId == departmentId);
            departmentDetail.IsDelete = true;
            departmentDetail.OnUpdated = DateTime.Now;
            dbContext.SaveChanges();
            return true;
        }

        //Doctor

        //Get List of All Doctors
        public List<DoctorModel> getDoctorsList()
        {
            var doctorList = new List<DoctorModel>();
            doctorList = dbContext.Doctor
                .Select(x => new DoctorModel()
                {
                    DoctorId = x.DoctorId,
                    DoctorName = x.DoctorName,
                    Speciality = x.Speciality,
                    Age = x.Age,
                    Address = x.Address,
                    ContactNo = x.ContactNo,
                    Email = x.Email,
                    AvailableFrom = x.AvailableFrom,
                    AvailableTo = x.AvailableTo,
                    DepartmentId = x.DepartmentId,
                    IsActive = x.IsActive,
                    IsDelete = x.IsDelete,
                    OnCreated = x.OnCreated,
                    OnUpdated = x.OnUpdated
                }).ToList();

            return doctorList;
        }

        //Get List of Doctors with Department
        public List<DoctorDepartmentModel> getDoctorDepartmentlist()
        {
            var doctorDepartmentList = new List<DoctorDepartmentModel>();
            doctorDepartmentList = dbContext.DoctorDepartment.Where(x => x.IsDelete == false)
                .Select(x => new DoctorDepartmentModel()
                {
                    DoctorId = x.DoctorId,
                    DepartmentName = x.DepartmentName,
                    DoctorName = x.DoctorName,
                    AvailableFrom = x.AvailableFrom!= null ? x.AvailableFrom.Value.ToString("hh:mm tt") : "",
                    AvailableTo = x.AvailableTo != null ? x.AvailableTo.Value.ToString("hh:mm tt") : "",
                    IsActive = x.IsActive,
                    IsDelete = x.IsDelete
                }).ToList();

            return doctorDepartmentList;
        }

        //Get Doctor with Department By Id
        public DoctorDepartmentModel getDoctorDepartmentById(Guid doctorId)
        {
            var doctorDepartmentDetail = new DoctorDepartmentModel();
            doctorDepartmentDetail = dbContext.DoctorDepartment.Where(x => x.IsDelete == false)
                .Select(x => new DoctorDepartmentModel()
                {
                    DoctorId = x.DoctorId,
                    DoctorName = x.DoctorName,
                    DepartmentName = x.DepartmentName,
                    AvailableFrom = x.AvailableFrom!=null?x.AvailableFrom.Value.ToString("hh:mm tt"):"",
                    AvailableTo = x.AvailableTo != null ? x.AvailableTo.Value.ToString("hh:mm tt") : "",
                    IsActive = x.IsActive,
                    IsDelete = x.IsDelete
                }).Where(x => x.DoctorId == doctorId).FirstOrDefault();
            return doctorDepartmentDetail;
        }

        //Add New Doctor
        public string addNewDoctor(DoctorModel doctorModel)
        {
            var newDoctor = new Doctor()
            {
                DoctorId = doctorModel.DoctorId,
                DoctorName = doctorModel.DoctorName,
                Speciality = doctorModel.Speciality,
                Age = doctorModel.Age,
                Address = doctorModel.Address,
                ContactNo = doctorModel.ContactNo,
                Email = doctorModel.Email,
                AvailableFrom = doctorModel.AvailableFrom,
                AvailableTo = doctorModel.AvailableTo,
                DepartmentId = doctorModel.DepartmentId,
                IsActive = true,
                IsDelete = false,
                OnCreated = DateTime.Now,
                OnUpdated = DateTime.Now
            };
            dbContext.Doctor.Add(newDoctor);
            dbContext.SaveChanges();
            return "New Doctor Inserted Successfully.";
        }

        //Update Doctor Details
        public string updateDoctor(DoctorModel doctorModel)
        {
            var doctorDetail = dbContext.Doctor.FirstOrDefault(x => x.DoctorId == doctorModel.DoctorId);
            if (doctorDetail != null)
            {
                doctorDetail.DoctorId = doctorModel.DoctorId;
                doctorDetail.DoctorName = doctorModel.DoctorName;
                doctorDetail.Speciality = doctorModel.Speciality;
                doctorDetail.Age = doctorModel.Age;
                doctorDetail.Address = doctorModel.Address;
                doctorDetail.ContactNo = doctorModel.ContactNo;
                doctorDetail.Email = doctorModel.Email;
                doctorDetail.AvailableFrom = doctorModel.AvailableFrom;
                doctorDetail.AvailableTo = doctorModel.AvailableTo;
                doctorDetail.DepartmentId = doctorModel.DepartmentId;
                doctorDetail.OnUpdated = DateTime.Now;
                dbContext.SaveChanges();
                return "Successfully Update Doctor Details.";
            }
            return "Doctor does not exist.";
        }

        //Delete Doctor 
        public bool deleteDoctor(Guid doctorId)
        {
            var doctorDetail = dbContext.Doctor.FirstOrDefault(x => x.DoctorId == doctorId);
                doctorDetail.IsDelete = true;
                doctorDetail.OnUpdated = DateTime.Now;
                dbContext.SaveChanges();
                return true;
        }

        //Nurse

        //Nurse List
        public List<NurseModel> getNurseList()
        {
            var nurseList = new List<NurseModel>();
            nurseList = dbContext.Nurse.Select(x => new NurseModel()
            {
                NurseId = x.NurseId,
                NurseName = x.NurseName,
                DepartmentId = x.DepartmentId,
                IsActive = x.IsActive,
                IsDelete = x.IsDelete,
                OnCreated = DateTime.Now,
                OnUpdated = DateTime.Now
            }).ToList();
            return nurseList;
        }

        //Nurse with Department List
        public List<NurseDepartmentModel> getNurseDepartmentList()
        {
            var nurseDepartmentList = new List<NurseDepartmentModel>();
            nurseDepartmentList = dbContext.NurseDepartment.Where(x=>x.IsDelete==false)
                .Select(x => new NurseDepartmentModel()
            {
                NurseId = x.NurseId,
                NurseName = x.NurseName,
                DepartmentName = x.DepartmentName,
                IsDelete = x.IsDelete,
            }).ToList();
            return nurseDepartmentList;
        }

        //Get Nurse with Department By Id
        public NurseDepartmentModel getNurseDepartmentById(Guid nurseId)
        {
            var nurseDepartmentDetail = new NurseDepartmentModel();
            nurseDepartmentDetail = dbContext.NurseDepartment.Where(x => x.IsDelete == false)
                .Select(x => new NurseDepartmentModel()
            {
                NurseId = x.NurseId,
                NurseName = x.NurseName,
                DepartmentName = x.DepartmentName,
                IsDelete = x.IsDelete
            }).Where(x => x.NurseId == nurseId).FirstOrDefault();
            return nurseDepartmentDetail;
        }

        // Add New Nurse
        public string addNewNurse(NurseModel nurseModel)
        {
            var newNurse = new Nurse()
            {
                NurseId = nurseModel.NurseId,
                NurseName = nurseModel.NurseName,
                DepartmentId = nurseModel.DepartmentId,
                IsActive = true,
                IsDelete = false,
                OnCreated = DateTime.Now,
                OnUpdated = DateTime.Now
            };
            dbContext.Nurse.Add(newNurse);
            dbContext.SaveChanges();
            return "New Nurse Inserted Successfully.";
        }

        //Delete Nurse
        public bool deleteNurse(Guid nurseId)
        {
            var nurseDetail = dbContext.Nurse.FirstOrDefault(x => x.NurseId == nurseId);
                nurseDetail.IsDelete = true;
                nurseDetail.OnUpdated = DateTime.Now;
                dbContext.SaveChanges();
                return true;
        }

        //Appointment

        //Get Appointment List
        public List<AppointmentModel> getAppointmentList()
        {
            var appointmentList = new List<AppointmentModel>();
            appointmentList = dbContext.Appointment.Select(x => new AppointmentModel()
            {
                AppointmentId = x.AppointmentId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Age = x.Age,
                Address = x.Address,
                ContactNo = x.ContactNo,
                Email = x.Email,
                AppointmentDate = x.AppointmentDate,
                TimeSelection = x.TimeSelection.Value,
                IsActive = x.IsActive,
                DoctorId = x.DoctorId,
                IsDelete = x.IsDelete,
                OnCreated = x.OnCreated,
                OnUpdated = x.OnUpdated
            }).ToList();

            return appointmentList;
        }

        //Get Appointment with Doctor List
        public List<AppointmentDoctorModel> getAppointmentDoctorList()
        {
            var appointmentDoctorList = new List<AppointmentDoctorModel>();
            appointmentDoctorList = dbContext.AppointmentDoctor.Where(x=>x.IsDelete==false)
                .Select(x => new AppointmentDoctorModel()
                {
                AppointmentId = x.AppointmentId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                AppointmentDate = x.AppointmentDate!=null?x.AppointmentDate.Value.ToString("dd MMM,yyyy"):"",
                TimeSelection = x.TimeSelection!=null?x.AvailableFrom.Value.ToString("hh:mm tt"):"",
                DoctorName = x.DoctorName,
                AvailableFrom = x.AvailableFrom != null ? x.AvailableFrom.Value.ToString("hh:mm tt") : "",
                AvailableTo = x.AvailableTo != null ? x.AvailableTo.Value.ToString("hh:mm tt") : "",
                IsDelete = x.IsDelete
                }).ToList();

            return appointmentDoctorList;
        }

        //Get Appointment with Doctor By Id
        public AppointmentDoctorModel getAppointmentDoctorById(Guid appointmentId)
        {
            var appointmentDoctorDetail = new AppointmentDoctorModel();
            appointmentDoctorDetail = dbContext.AppointmentDoctor.Where(x => x.IsDelete == false)
                .Select(x => new AppointmentDoctorModel()
                {
                    AppointmentId = x.AppointmentId,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    AppointmentDate = x.AppointmentDate!=null?x.AppointmentDate.Value.ToString("dd MMM,yyyy"):"",
                    TimeSelection = x.TimeSelection != null ? x.AvailableFrom.Value.ToString("hh:mm tt") : "",
                    DoctorName = x.DoctorName,
                    AvailableFrom = x.AvailableFrom != null ? x.AvailableFrom.Value.ToString("hh:mm tt") : "",
                    AvailableTo = x.AvailableTo != null ? x.AvailableTo.Value.ToString("hh:mm tt") : "",
                    IsDelete = x.IsDelete
                }).Where(x => x.AppointmentId == appointmentId).FirstOrDefault();
            return appointmentDoctorDetail;
        }

        //Add new Appointment
        public string addNewAppointment(AppointmentModel appointmentModel)
        {
            var newAppointment = new Appointment()
            {
                AppointmentId = appointmentModel.AppointmentId,
                FirstName = appointmentModel.FirstName,
                LastName = appointmentModel.LastName,
                Address = appointmentModel.Address,
                Age = appointmentModel.Age,
                ContactNo = appointmentModel.ContactNo,
                Email = appointmentModel.Email,
                AppointmentDate = appointmentModel.AppointmentDate,
                TimeSelection = appointmentModel.TimeSelection,
                DoctorId = appointmentModel.DoctorId,
                IsActive = true,
                IsDelete = false,
                OnCreated = DateTime.Now,
                OnUpdated = DateTime.Now
            };
            dbContext.Appointment.Add(newAppointment);
            dbContext.SaveChanges();
            return "New Appointement Inserted Successfully.";
        }

        //Update Appointment
        public string updateAppointment(AppointmentModel appointmentModel)
        {
            var appointmentDetail = dbContext.Appointment.FirstOrDefault(x => x.AppointmentId == appointmentModel.AppointmentId);
            if (appointmentDetail != null)
            {
                appointmentDetail.AppointmentId = appointmentModel.AppointmentId;
                appointmentDetail.FirstName = appointmentModel.FirstName;
                appointmentDetail.LastName = appointmentModel.LastName;
                appointmentDetail.Address = appointmentModel.Address;
                appointmentDetail.Age = appointmentModel.Age;
                appointmentDetail.ContactNo = appointmentModel.ContactNo;
                appointmentDetail.Email = appointmentDetail.Email;
                appointmentDetail.AppointmentDate = appointmentModel.AppointmentDate;
                appointmentDetail.TimeSelection = appointmentModel.TimeSelection;
                appointmentDetail.DoctorId = appointmentModel.DoctorId;
                appointmentDetail.OnUpdated = DateTime.Now;
                dbContext.SaveChanges();
                return "Successfully Update Appointment Details.";
            }
            return "Appointment does not exist.";
        }

        //Delete Appointment
        public bool deleteAppointment(Guid appointmentId)
        {
            var appointmentDetail = dbContext.Appointment.FirstOrDefault(x => x.AppointmentId == appointmentId);
                appointmentDetail.IsDelete = true;
                appointmentDetail.OnUpdated = DateTime.Now;
                dbContext.SaveChanges();
                return true;
        }

        //Patient Services

        //Get all Patients
        public List<PatientModel> getPatientList()
        {
            var patientList = new List<PatientModel>();
            patientList = dbContext.Patient.Select(x => new PatientModel()
            {
                PatientId = x.PatientId,
                PatientName = x.PatientName,
                Dob = x.Dob,
                Age = x.Age,
                Address = x.Address,
                ContactNo = x.ContactNo,
                NurseId = x.NurseId,
                DoctorId = x.DoctorId,
                IsActive = x.IsActive,
                IsDelete = x.IsDelete,
                OnCreated = x.OnCreated,
                OnUpdated = x.OnUpdated
            }).ToList();

            return patientList;
        }

        //Get all Patient with Doctor List
        public List<PatientDoctorModel> getPatientDoctorList()
        {
            var patientDoctorList = new List<PatientDoctorModel>();
            patientDoctorList = dbContext.PatientDoctor.Where(x => x.IsDelete == false)
                .Select(x => new PatientDoctorModel()
            {
                PatientId = x.PatientId,
                PatientName = x.PatientName,
                DoctorName = x.DoctorName,
                IsDelete = x.IsDelete
            }).ToList();

            return patientDoctorList;
        }

        // Get Patient Doctor Nurse By Id
        public PatientDoctorNurseModel getPatientDoctorNurseById(Guid patientId)
        {
            var patientDetail = new PatientDoctorNurseModel();
            patientDetail = dbContext.PatientDoctorNurse.Where(x => x.IsDelete == false)
                .Select(x => new PatientDoctorNurseModel()
            {
                NurseId = x.NurseId,
                PatientId = x.PatientId,
                PatientName = x.PatientName,
                NurseName = x.NurseName,
                DoctorName = x.DoctorName,
                IsDelete = x.IsDelete
            }).Where(x => x.PatientId == patientId).FirstOrDefault();
            return patientDetail;
        }

        // Get List Patient Nurse Doctor
        public List<PatientDoctorNurseModel> getPatientDoctorNurseList()
        {
            var patientDoctorNurseList = new List<PatientDoctorNurseModel>();
            patientDoctorNurseList = dbContext.PatientDoctorNurse.Where(x => x.IsDelete == false)
                .Select(x => new PatientDoctorNurseModel()
            {
                NurseId = x.NurseId,
                PatientId = x.PatientId,
                DoctorName = x.DoctorName,
                PatientName = x.PatientName,
                NurseName = x.NurseName,
                IsDelete = x.IsDelete
            }).ToList();

            return patientDoctorNurseList;
        }

        //Add new patient
        public string addNewPatient(PatientModel patientModel)
        {
            var newPatient = new Patient()
            {
                PatientId = patientModel.PatientId,
                PatientName = patientModel.PatientName,
                Dob = patientModel.Dob,
                Age = patientModel.Age,
                ContactNo = patientModel.ContactNo,
                Address = patientModel.Address,
                NurseId = patientModel.NurseId,
                DoctorId = patientModel.DoctorId,
                IsActive = true,
                IsDelete = false,
                OnCreated = DateTime.Now,
                OnUpdated = DateTime.Now
            };
            dbContext.Patient.Add(newPatient);
            dbContext.SaveChanges();
            return "New Patient Inserted Successfully.";
        }

        //update patient
        public string updatePatient(PatientModel patientModel)
        {
            var patientDetail = dbContext.Patient.FirstOrDefault(x => x.PatientId == patientModel.PatientId);
            if (patientDetail != null)
            {
                patientDetail.PatientId = patientModel.PatientId;
                patientDetail.PatientName = patientModel.PatientName;
                patientDetail.Dob = patientModel.Dob;
                patientDetail.Age = patientModel.Age;
                patientDetail.ContactNo = patientModel.ContactNo;
                patientDetail.Address = patientModel.Address;
                patientDetail.NurseId = patientModel.NurseId;
                patientDetail.DoctorId = patientModel.DoctorId;
                patientDetail.OnUpdated = DateTime.Now;
                dbContext.SaveChanges();
                return "Successfully Update Patient Details.";
            }
            return "Patient does not exist.";
        }

        //Delete Patient
        public bool deletePatient(Guid patientId)
        {
            var patientDetail = dbContext.Patient.FirstOrDefault(x => x.PatientId == patientId);
                patientDetail.IsDelete = true;
                patientDetail.OnUpdated = DateTime.Now;
                dbContext.SaveChanges();
                return true;
        }

        //Medicine Services

        //Get Medicine List
        public List<MedicineModel> getMedicineList()
        {
            var medicineList = new List<MedicineModel>();
            medicineList = dbContext.Medicine.Select(x => new MedicineModel()
            {
                MedicineId = x.MedicineId,
                MedicineName = x.MedicineName,
                CompanyName = x.CompanyName,
                IsActive = x.IsActive,
                IsDelete = x.IsDelete,
                OnCreated = x.OnCreated,
                OnUpdated = x.OnUpdated
            }).ToList();

            return medicineList;
        }

        //Add New Medicine
        public string addNewMedicine(MedicineModel medicineModel)
        {
            var newMedicine = new Medicine()
            {
                MedicineId = medicineModel.MedicineId,
                MedicineName = medicineModel.MedicineName,
                CompanyName = medicineModel.CompanyName,
                IsActive = true,
                IsDelete = false,
                OnCreated = DateTime.Now,
                OnUpdated = DateTime.Now
            };
            dbContext.Medicine.Add(newMedicine);
            dbContext.SaveChanges();
            return "New Medicine Inserted Successfully.";
        }

        //Delete Medicine
        public bool deleteMedicine(Guid medicineId)
        {
            var medicineDetail = dbContext.Medicine.FirstOrDefault(x => x.MedicineId == medicineId);
                medicineDetail.IsDelete = true;
                medicineDetail.OnUpdated = DateTime.Now;
                dbContext.SaveChanges();
                return true;
        }

        //Medicine Schedule Services

        //Get Medicine Schedule List
        public List<MedicineScheduleModel> getMedicineScheduleList()
        {
            var medicineScheduleList = new List<MedicineScheduleModel>();
            medicineScheduleList = dbContext.MedicineSchedule.Select(x => new MedicineScheduleModel()
            {
                MedicineScheduleId = x.MedicineScheduleId,
                MedicineId = x.MedicineId,
                DayPartMorning = x.DayPartMorning,
                DayPartNoon = x.DayPartNoon,
                DayPartEvening = x.DayPartEvening,
                PatientId = x.PatientId,
                NurseId = x.NurseId,
                IsActive = x.IsActive,
                IsDelete = x.IsDelete,
                OnCreated = x.OnCreated,
                OnUpdated = x.OnUpdated
            }).ToList();

            return medicineScheduleList;
        }

        //Get Medicine Schedule Patient List
        public List<MedicineSchedulePatientModel> getMedicineSchedulePatientList()
        {
            var medicineSchedulePatientList = new List<MedicineSchedulePatientModel>();
            medicineSchedulePatientList = dbContext.MedicineSchedulePatient.Where(x=>x.IsDelete==false)
                .Select(x => new MedicineSchedulePatientModel()
            {
                MedicineScheduleId = x.MedicineScheduleId,
                PatientName = x.PatientName,
                MedicineName = x.MedicineName,
                DayPartMorning = x.DayPartMorning,
                DayPartNoon = x.DayPartNoon,
                DayPartEvening = x.DayPartEvening,
                IsDelete = x.IsDelete
            }).ToList();

            return medicineSchedulePatientList;
        }

        //Medicine Schedule Patient By Id
        public MedicineSchedulePatientModel getMedicineSchedulePatientById(Guid medicineScheduleId)
        {
            var medicineSchedulePatientDetail = new MedicineSchedulePatientModel();
            medicineSchedulePatientDetail = dbContext.MedicineSchedulePatient
                .Where(x=> x.IsDelete == false)
                .Select(x => new MedicineSchedulePatientModel()
            {
                MedicineScheduleId = x.MedicineScheduleId,
                MedicineName = x.MedicineName,
                PatientName = x.PatientName,
                DayPartMorning = x.DayPartMorning,
                DayPartNoon = x.DayPartNoon,
                DayPartEvening = x.DayPartEvening,
                IsDelete = x.IsDelete
            }).Where(x => x.MedicineScheduleId == medicineScheduleId).FirstOrDefault();
            return medicineSchedulePatientDetail;
        }

        //Add new Medicine Schedule
        public string addNewMedicineSchedule(MedicineScheduleModel medicineScheduleModel)
        {
            var newMedicineSchedule = new MedicineSchedule()
            {
                MedicineScheduleId = medicineScheduleModel.MedicineScheduleId,
                MedicineId = medicineScheduleModel.MedicineId,
                DayPartMorning = medicineScheduleModel.DayPartMorning,
                DayPartNoon = medicineScheduleModel.DayPartNoon,
                DayPartEvening = medicineScheduleModel.DayPartEvening,
                PatientId = medicineScheduleModel.PatientId,
                NurseId = medicineScheduleModel.NurseId,
                IsActive = true,
                IsDelete = false,
                OnCreated = DateTime.Now,
                OnUpdated = DateTime.Now
            };
            dbContext.MedicineSchedule.Add(newMedicineSchedule);
            dbContext.SaveChanges();
            return "New Medicine Schedule Inserted Successfully.";
        }

        //Update Medicine Schedule
        public string updateMedicineSchedule(MedicineScheduleModel medicineScheduleModel)
        {
            var medicineScheduleDetail = dbContext.MedicineSchedule.FirstOrDefault(x => x.MedicineScheduleId == medicineScheduleModel.MedicineScheduleId);
            if (medicineScheduleDetail != null)
            {
                medicineScheduleDetail.MedicineScheduleId = medicineScheduleModel.MedicineScheduleId;
                medicineScheduleDetail.MedicineId = medicineScheduleModel.MedicineId;
                medicineScheduleDetail.DayPartMorning = medicineScheduleModel.DayPartMorning;
                medicineScheduleDetail.DayPartNoon = medicineScheduleModel.DayPartNoon;
                medicineScheduleDetail.DayPartEvening = medicineScheduleModel.DayPartEvening;
                medicineScheduleDetail.PatientId = medicineScheduleModel.PatientId;
                medicineScheduleDetail.NurseId = medicineScheduleModel.NurseId;
                medicineScheduleDetail.OnUpdated = DateTime.Now;
                dbContext.SaveChanges();
                return "Successfully Update Medicine Schedule Details.";
            }
            return "Medicine Schedule does not exist.";
        }

        //Delete Medicine Schedule
        public bool deleteMedicineSchedule(Guid medicineScheduleId)
        {
            var medicineScheduleDetail = dbContext.MedicineSchedule.FirstOrDefault(x => x.MedicineScheduleId == medicineScheduleId);
                medicineScheduleDetail.IsDelete = true;
                medicineScheduleDetail.OnUpdated = DateTime.Now;
                dbContext.SaveChanges();
                return true;
        }

        //Report Services

        //List of Reports
        public List<ReportModel> getReportList()
        {
            var reportList = new List<ReportModel>();
            reportList = dbContext.Report.Select(x => new ReportModel()
            {
                ReportId = x.ReportId,
                BloodPressure = x.BloodPressure,
                Sugar = x.Sugar,
                HeartBeat = x.HeartBeat,
                Description = x.Description,
                PatientId = x.PatientId,
                IsActive = x.IsActive,
                IsDelete = x.IsDelete,
                OnCreated = x.OnCreated,
                OnUpdated = x.OnUpdated
            }).ToList();

            return reportList;
        }

        //List of Report Patient Doctor
        public List<ReportPatientDoctorModel> getReportPatientDoctorList()
        {
            var reportPatientDoctorList = new List<ReportPatientDoctorModel>();
            reportPatientDoctorList = dbContext.ReportPatientDoctor.Where(x=>x.IsDelete==false)
                .Select(x => new ReportPatientDoctorModel()
            {
                ReportId = x.ReportId,
                PatientName = x.PatientName,
                DoctorName = x.DoctorName,
                BloodPressure = x.BloodPressure,
                Sugar = x.Sugar,
                HeartBeat = x.HeartBeat,
                Description = x.Description,
                IsDelete = x.IsDelete
            }).ToList();

            return reportPatientDoctorList;
        }

        //Get report Patient Doctor By id
        public ReportPatientDoctorModel getReportPatientDoctorById(Guid reportId)
        {
            var reportDetail = new ReportPatientDoctorModel();
            reportDetail = dbContext.ReportPatientDoctor.Where(x=> x.IsDelete == false)
                .Select(x => new ReportPatientDoctorModel()
            {
                ReportId = reportId,
                PatientName= x.PatientName,
                DoctorName = x.DoctorName,
                BloodPressure = x.BloodPressure,
                Sugar = x.Sugar,
                HeartBeat = x.HeartBeat,
                Description = x.Description,
                IsDelete = x.IsDelete
            }).Where(x => x.ReportId == reportId).FirstOrDefault();
            return reportDetail;
        }

        //Add New Report
        public string addNewReport(ReportModel reportModel)
        {
            var newReport = new Report()
            {
                ReportId = reportModel.ReportId,
                BloodPressure = reportModel.BloodPressure,
                Sugar = reportModel.Sugar,
                HeartBeat = reportModel.HeartBeat,
                Description = reportModel.Description,
                PatientId = reportModel.PatientId,
                IsActive = true,
                IsDelete = false,
                OnCreated = DateTime.Now,
                OnUpdated= DateTime.Now
            };
            dbContext.Report.Add(newReport);
            dbContext.SaveChanges();
            return "New Report Inserted Successfully.";
        }

        //Update Report
        public string updateReport(ReportModel reportModel)
        {
            var reportDetail = dbContext.Report.FirstOrDefault(x => x.ReportId == reportModel.ReportId);
            if (reportDetail != null)
            {
                reportDetail.BloodPressure = reportModel.BloodPressure;
                reportDetail.Sugar = reportModel.Sugar;
                reportDetail.HeartBeat = reportModel.HeartBeat;
                reportDetail.Description = reportModel.Description;
                reportDetail.PatientId = reportModel.PatientId;
                reportDetail.OnUpdated = DateTime.Now;
                dbContext.SaveChanges();
                return "Successfully Update Report Details.";
            }
            return "Report does not exist.";
        }

        //Delete Report
        public bool deleteReport(Guid reportId)
        {
            var reportDetail = dbContext.Report.FirstOrDefault(x => x.ReportId == reportId);
                reportDetail.IsDelete = true;
                reportDetail.OnUpdated = DateTime.Now;
                dbContext.SaveChanges();
                return true;
        }

    }
}