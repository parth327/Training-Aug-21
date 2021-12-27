using HospitalManagement.Models;
using HospitalManagement.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using HospitalManagement.Authentication;

namespace HospitalManagement.Controllers
{
    [Route("api/hospital")]
    [ApiController]
    [EnableCors("MyCorsPolicy")]
    public class HospitalController : ControllerBase
    {
        private IHospitalRepository _hospitalRepository;
        public HospitalController(IHospitalRepository hospitalRepository)
        {
            this._hospitalRepository = hospitalRepository;
        }

        //Add New Department
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        [Route("addDepartment")]
        public string AddDepartment([FromBody] DepartmentModel departmentModel)
        {
            var response = "";
            try
            {
                if (departmentModel != null)
                {
                    response = _hospitalRepository.addNewDepartment(departmentModel);
                    return response;
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Delete Department
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        [Route("deleteDepartment/{departmentId}")]
        public string DeleteDepartment(Guid departmentId)
        {
            var response = false;
            try
            {
                response = _hospitalRepository.deleteDepartment(departmentId);
                if (response == true)
                {
                    return "successfully delete department";
                }
                return "something wrong";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // List of All Departments
        [Authorize]
        [HttpGet]
        [Route("getDepartments")]
        public List<DepartmentModel> getDepartments()
        {
            var response = new List<DepartmentModel>();
            try
            {
                response = _hospitalRepository.getDepartmentList();
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Add Doctor
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        [Route("addDoctor")]
        public string AddDoctor([FromBody] DoctorModel doctorModel)
        {
            var response = "";
            try
            {
                    response = _hospitalRepository.addNewDoctor(doctorModel);
                    return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Update Doctor
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        [Route("updateDoctor")]
        public string UpdateDoctor(DoctorModel doctorModel)
        {
            var response = "";
            try
            {
                response = _hospitalRepository.updateDoctor(doctorModel);
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Delete Doctor
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        [Route("deleteDoctor/{doctorId}")]
        public string DeleteDoctor(Guid doctorId)
        {
            var response = false;
            try
            {
                response = _hospitalRepository.deleteDoctor(doctorId);
                if (response == true)
                {
                    return "successfully delete doctor";
                }
                return "something wrong";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //List of Doctors
        [Authorize(Roles =UserRoles.Admin)]
        [HttpGet]
        [Route("getDoctors")]
        public List<DoctorModel> getDoctor()
        {
            var response = new List<DoctorModel>();
            try
            {
                response = _hospitalRepository.getDoctorsList();
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //List of Doctor Department List
        [Authorize]
        [HttpGet]
        [Route("getDoctorDepartment")]
        public List<DoctorDepartmentModel> getDoctorDepartment()
        {
            var response = new List<DoctorDepartmentModel>();
            try
            {
                response = _hospitalRepository.getDoctorDepartmentlist();
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Get Doctor Details By Id
        [Authorize]
        [HttpGet]
        [Route("getDoctorDepartment/{doctorId}")]
        public DoctorDepartmentModel GetDoctorById(Guid doctorId)
        {
            var response = new DoctorDepartmentModel();
            try
            {
                response = _hospitalRepository.getDoctorDepartmentById(doctorId);
                return response;
            }
            catch
            {
                return response;
            }
        }

        //Add Nurse
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        [Route("addNurse")]
        public string AddNurse([FromBody] NurseModel nurseModel)
        {
            var response = "";
            try
            {
                    response = _hospitalRepository.addNewNurse(nurseModel);
                    return response;
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }

        //Delete Nurse
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        [Route("deleteNurse/{nurseId}")]
        public string DeleteNurse(Guid nurseId)
        {
            var response = false;
            try
            {
                response = _hospitalRepository.deleteNurse(nurseId);
                if (response == true)
                {
                    return "successfully delete nurse";
                }
                return "something wrong";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //List of Nurses
        [Authorize(Roles =UserRoles.Admin)]
        [HttpGet]
        [Route("getNurses")]
        public List<NurseModel> getNurses()
        {
            var response = new List<NurseModel>();
            try
            {
                response = _hospitalRepository.getNurseList();
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //List of Nurse Department
        [Authorize]
        [HttpGet]
        [Route("getNurseDepartment")]
        public List<NurseDepartmentModel> getNurseDepartment()
        {
            var response = new List<NurseDepartmentModel>();
            try
            {
                response = _hospitalRepository.getNurseDepartmentList();
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Get Nurse Department By Id
        [Authorize]
        [HttpGet]
        [Route("getNurseDepartment/{nurseId}")]
        public NurseDepartmentModel GetNurseDepartmentById(Guid nurseId)
        {
            var response = new NurseDepartmentModel();
            try
            {
                response = _hospitalRepository.getNurseDepartmentById(nurseId);
                return response;
            }
            catch
            {
                return response;
            }
        }

        //Appointment List
        [Authorize(Roles =UserRoles.Admin)]
        [HttpGet]
        [Route("getAppointments")]
        public List<AppointmentModel> getAppointments()
        {
            var response = new List<AppointmentModel>();
            try
            {
                response = _hospitalRepository.getAppointmentList();
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Appointment Doctor List
        [Authorize(Roles =UserRoles.Admin)]
        [HttpGet]
        [Route("getAppointmentDoctor")]
        public List<AppointmentDoctorModel> getAppointmentDoctor()
        {
            var response = new List<AppointmentDoctorModel>();
            try
            {
                response = _hospitalRepository.getAppointmentDoctorList();
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Appointment Doctor by Id
        [Authorize]
        [HttpGet]
        [Route("getAppointmentDoctor/{AppointmentId}")]
        public AppointmentDoctorModel GetAppointmentDoctorById(Guid appointmentId)
        {
            var response = new AppointmentDoctorModel();
            try
            {
                response = _hospitalRepository.getAppointmentDoctorById(appointmentId);
                return response;
            }
            catch
            {
                return response;
            }
        }

        //Add New Appointment
        [Authorize]
        [HttpPost]
        [Route("addAppointment")]
        public string AddAppointment([FromBody] AppointmentModel appointmentModel)
        {
            var response = "";
            try
            {
                response = _hospitalRepository.addNewAppointment(appointmentModel);
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }

        //Update New Appointment
        [Authorize]
        [HttpPost]
        [Route("updateAppointment")]
        public string UpdateAppointment(AppointmentModel appointmentModel)
        {
            var response = "";
            try
            {
                response = _hospitalRepository.updateAppointment(appointmentModel);
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Delete Appointment
        [Authorize(Roles =UserRoles.Admin)]
        [HttpPost]
        [Route("deleteAppointment/{appointmentId}")]
        public string DeleteAppointment(Guid appointmentId)
        {
            var response = false;
            try
            {
                response = _hospitalRepository.deleteAppointment(appointmentId);
                if (response == true)
                {
                    return "successfully delete Appointment";
                }
                return "something wrong";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Add Patient
        [Authorize(Roles =UserRoles.Admin)]
        [HttpPost]
        [Route("addPatient")]
        public string AddPatient([FromBody] PatientModel patientModel)
        {
            var response = "";
            try
            {
                if (patientModel != null)
                {
                    response = _hospitalRepository.addNewPatient(patientModel);
                    return response;
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Update Patient
        [Authorize(Roles =UserRoles.Admin)]
        [HttpPost]
        [Route("updatePatient")]
        public string UpdatePatient(PatientModel patientModel)
        {
            var response = "";
            try
            {
                    response = _hospitalRepository.updatePatient(patientModel);
                    return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Delete Patient
        [Authorize(Roles =UserRoles.Admin)]
        [HttpPost]
        [Route("deletePatient/{patientId}")]
        public string deletePatient(Guid patientId)
        {
            var response = false;
            try
            {
                response = _hospitalRepository.deletePatient(patientId);
                if (response == true)
                {
                    return "successfully delete patient";
                }
                return "something wrong";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //List of All Patients
        [Authorize(Roles =UserRoles.Admin)]
        [HttpGet]
        [Route("getPatients")]
        public List<PatientModel> getPatients()
        {
            var response = new List<PatientModel>();
            try
            {
                response = _hospitalRepository.getPatientList();
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Get Patient Doctor List
        [Authorize(Roles =UserRoles.Admin)]
        [HttpGet]
        [Route("getPatientDoctor")]
        public List<PatientDoctorModel> getPatientDoctor()
        {
            var response = new List<PatientDoctorModel>();
            try
            {
                response = _hospitalRepository.getPatientDoctorList();
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Get Patient Doctor Nurse List
        [Authorize(Roles =UserRoles.Admin)]
        [HttpGet]
        [Route("getPatientDoctorNurse")]
        public List<PatientDoctorNurseModel> getPatientDoctorNurse()
        {
            var response = new List<PatientDoctorNurseModel>();
            try
            {
                response = _hospitalRepository.getPatientDoctorNurseList();
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Get Patient By PatientId
        [Authorize]
        [Route("getPatientDoctorNurse/{patientId}")]
        [HttpGet]
        public PatientDoctorNurseModel GetPatientDoctorNurseById(Guid patientId)
        {
            var response = new PatientDoctorNurseModel();
            try
            {
                response = _hospitalRepository.getPatientDoctorNurseById(patientId);
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Medicine List
        [Authorize(Roles = UserRoles.Admin)]
        [HttpGet]
        [Route("getMedicines")]
        public List<MedicineModel> getMedicines()
        {
            var response = new List<MedicineModel>();
            try
            {
                response = _hospitalRepository.getMedicineList();
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Add Medicine
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        [Route("addMedicine")]
        public string AddMedicine([FromBody] MedicineModel medicineModel)
        {
            var response = "";
            try
            {
                if (medicineModel != null)
                {
                    response = _hospitalRepository.addNewMedicine(medicineModel);
                    return response;
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;

            }

        }

        //Delete Medicine
        [Authorize(Roles =UserRoles.Admin)]
        [HttpPost]
        [Route("deleteMedicine/{medicineId}")]
        public string deleteMedicine(Guid medicineId)
        {
            var response = false;
            try
            {
                response = _hospitalRepository.deleteMedicine(medicineId);
                if (response == true)
                {
                    return "successfully delete medicine";
                }
                return "something wrong";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Add Medicine Schedule
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        [Route("addMedicineSchedule")]
        public string AddMedicineSchedule([FromBody] MedicineScheduleModel medicineScheduleModel)
        {
            var response = "";
            try
            {
                if (medicineScheduleModel != null)
                {
                    response = _hospitalRepository.addNewMedicineSchedule(medicineScheduleModel);
                    return response;
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }

        //List of Medicine Schedule
        [Authorize(Roles = UserRoles.Admin)]
        [HttpGet]
        [Route("getMedicineSchedule")]
        public List<MedicineScheduleModel> getMedicineSchedule()
        {
            var response = new List<MedicineScheduleModel>();
            try
            {
                response = _hospitalRepository.getMedicineScheduleList();
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //List of Medicine Schedule Patient List
        [Authorize(Roles = UserRoles.Admin)]
        [HttpGet]
        [Route("getMedicineSchedulePatient")]
        public List<MedicineSchedulePatientModel> getMedicineSchedulePatient()
        {
            var response = new List<MedicineSchedulePatientModel>();
            try
            {
                response = _hospitalRepository.getMedicineSchedulePatientList();
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Update Medicine Schedule
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        [Route("updateMedicineSchedule")]
        public string UpdateMedicineSchedule(MedicineScheduleModel medicineScheduleModel)
        {
            var response = "";
            try
            {
                    response = _hospitalRepository.updateMedicineSchedule(medicineScheduleModel);
                    return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Get Medicine Schedule Patient By Id
        [Authorize]
        [Route("getMedicineSchedulePatient/{medicineScheduleId}")]
        [HttpGet]
        public MedicineSchedulePatientModel GetMedicineSchedulePatientById(Guid medicineScheduleId)
        {
            var response = new MedicineSchedulePatientModel();
            try
            {
                response = _hospitalRepository.getMedicineSchedulePatientById(medicineScheduleId);
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Delete Medicine Schedule
        [Authorize(Roles =UserRoles.Admin)]
        [HttpPost]
        [Route("deleteMedicineSchedule/{medicineId}")]
        public string deleteMedicineSchedule(Guid medicineId)
        {
            var response = false;
            try
            {
                response = _hospitalRepository.deleteMedicineSchedule(medicineId);
                if (response == true)
                {
                    return "successfully delete medicine Schedule";
                }
                return "something wrong";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Add Report
        [Authorize(Roles =UserRoles.Admin)]
        [HttpPost]
        [Route("addReport")]
        public string AddReport([FromBody] ReportModel reportModel)
        {
            var response = "";
            try
            {
                if (reportModel != null)
                {
                    response = _hospitalRepository.addNewReport(reportModel);
                    return response;
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }

        //Update Report
        [Authorize(Roles =UserRoles.Admin)]
        [HttpPost]
        [Route("updateReport")]
        public string UpdateReport(ReportModel reportModel)
        {
            var response = "";
            try
            {
                    response = _hospitalRepository.updateReport(reportModel);
                    return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //List of Reports
        [Authorize(Roles =UserRoles.Admin)]
        [HttpGet]
        [Route("getReports")]
        public List<ReportModel> getReports()
        {
            var response = new List<ReportModel>();
            try
            {
                response = _hospitalRepository.getReportList();
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Get Report Patient Doctor
        [Authorize(Roles =UserRoles.Admin)]
        [HttpGet]
        [Route("getReportPatientDoctor")]
        public List<ReportPatientDoctorModel> getReportPatientDoctor()
        {
            var response = new List<ReportPatientDoctorModel>();
            try
            {
                response = _hospitalRepository.getReportPatientDoctorList();
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //get Report Patient Doctor By Id
        [Authorize]
        [Route("getReportPatientDoctor/{reportId}")]
        [HttpGet]
        public ReportPatientDoctorModel GetreportPatientDoctorById(Guid reportId)
        {
            var response = new ReportPatientDoctorModel();
            try
            {
                response = _hospitalRepository.getReportPatientDoctorById(reportId);
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Delete Report
        [Authorize(Roles =UserRoles.Admin)]
        [HttpPost]
        [Route("deleteReport/{reportId}")]
        public string deleteReport(Guid reportId)
        {
            var response = false;
            try
            {
                response = _hospitalRepository.deleteReport(reportId);
                if (response == true)
                {
                    return "successfully delete Report";
                }
                return "something wrong";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
