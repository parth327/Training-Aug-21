using System;
using System.Collections.Generic;
using System.Text;
using HospitalManagement.Models;

namespace HospitalManagement.Repository
{
    public interface IHospitalRepository
    {
        //Department
        List<DepartmentModel> getDepartmentList();
        string addNewDepartment(DepartmentModel departmentModel);
        bool deleteDepartment(Guid departmentId);

        //Doctor
        List<DoctorModel> getDoctorsList();
        List<DoctorDepartmentModel> getDoctorDepartmentlist();
        DoctorDepartmentModel getDoctorDepartmentById(Guid doctorId);
        string addNewDoctor(DoctorModel doctorModel);
        string updateDoctor(DoctorModel doctorModel);
        bool deleteDoctor(Guid doctorId);

        //Nurse
        List<NurseModel> getNurseList();
        List<NurseDepartmentModel> getNurseDepartmentList();
        NurseDepartmentModel getNurseDepartmentById(Guid nurseId);
        string addNewNurse(NurseModel nurseModel);
        bool deleteNurse(Guid nurseId);

        //Appointment
        List<AppointmentModel> getAppointmentList();
        List<AppointmentDoctorModel> getAppointmentDoctorList();
        AppointmentDoctorModel getAppointmentDoctorById(Guid appointmentId);
        string addNewAppointment(AppointmentModel appointmentModel);
        string updateAppointment(AppointmentModel appointmentModel);
        bool deleteAppointment(Guid appointmentId);

        //Patient
        List<PatientModel> getPatientList();
        List<PatientDoctorModel> getPatientDoctorList();
        List<PatientDoctorNurseModel> getPatientDoctorNurseList();
        PatientDoctorNurseModel getPatientDoctorNurseById(Guid patientId);
        string addNewPatient(PatientModel patientModel);
        string updatePatient(PatientModel patientModel);
        bool deletePatient(Guid patientId);

        //Medicine
        List<MedicineModel> getMedicineList();
        string addNewMedicine(MedicineModel medicineModel);
        bool deleteMedicine(Guid medicineId);

        //Medicine Schedule
        List<MedicineScheduleModel> getMedicineScheduleList();
        List<MedicineSchedulePatientModel> getMedicineSchedulePatientList();
        MedicineSchedulePatientModel getMedicineSchedulePatientById(Guid medicineScheduleId);
        string addNewMedicineSchedule(MedicineScheduleModel medicineScheduleModel);
        string updateMedicineSchedule(MedicineScheduleModel medicineScheduleModel);
        bool deleteMedicineSchedule(Guid medicineScheduleId);

        //Report
        List<ReportModel> getReportList();
        List<ReportPatientDoctorModel> getReportPatientDoctorList();
        ReportPatientDoctorModel getReportPatientDoctorById(Guid reportId);
        string addNewReport(ReportModel reportModel);
        string updateReport(ReportModel reportModel);
        bool deleteReport(Guid reportId);
    }
}
