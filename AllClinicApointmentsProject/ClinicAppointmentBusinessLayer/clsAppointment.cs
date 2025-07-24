using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicAppointmentDataAccessLayer;
using ClinicDoctorDataAccessLayer;
using ClinicPatientDataAccessLayer;

namespace ClinicAppointmentBusinessLayer
{
    public class clsAppointment
    {
        enum enMode { Addnew = 0,Update = 1}
        enMode Mode = enMode.Addnew;

       // public int CurrentID = -1;
        public int ID {  get; set; }
        public int PatientID {  get; set; }
        public int DoctorID {  get; set; }
        public DateTime DateTime { get; set; }
        public string Status { get; set; }//Pending, Confirme, Complete, Canceled, Reschedule, No Show
        public Nullable<int> MedicalRecordID {  get; set; }
        public Nullable<int> PaymentID {  get; set; }

        public clsAppointment()
        {
            ID = -1;
            PatientID = -1;
            DoctorID = -1;
            DateTime = new DateTime();
            Status = "";
            MedicalRecordID = -1;
            PaymentID = -1;
            Mode = enMode.Addnew;
        }

        clsAppointment(int iD, int patientID, int doctorID, DateTime dateTime, string status, int? medicalRecordID, int? paymentID)
        {
            Mode = enMode.Update;
            ID = iD;
            PatientID = patientID;
            DoctorID = doctorID;
            DateTime = dateTime;
            Status = status;
            MedicalRecordID = medicalRecordID;
            PaymentID = paymentID;
        }

        public static DataTable GetAllAppointments()
        {
            return clsAppointmentData.GetAllAppointments();
        }

        public static clsAppointment FindAppointment(int AppointmentID)
        {
            int PatientID=-1, DoctorID=-1;
            DateTime AppointmentDateTime= new DateTime();
            string AppointmentStatus="";
            int? MedicalRecordID=-1, PaymentID=-1;

            if(clsAppointmentData.FindAppointment(AppointmentID,ref PatientID,ref DoctorID,ref AppointmentDateTime,ref AppointmentStatus,ref MedicalRecordID,ref PaymentID))
            {
                return new clsAppointment(AppointmentID,PatientID,DoctorID,AppointmentDateTime,AppointmentStatus,MedicalRecordID,PaymentID);
            }
            return null;
        }
        bool _UpdateAppointment()
        {
            //before update i have to check forein keys exits or not like add function
            return clsAppointmentData.UpdateAppointment(this.ID,this.PatientID,this.DoctorID,this.DateTime,this.Status,this.MedicalRecordID,this.PaymentID);
        }

        bool _CheckDoctorIsExists(int DoctorID)
        {
            return clsDoctorData.IsDoctorExists(DoctorID);

        }
        bool _CheckPatientIsExists(int PatientID)
        {
            return clsPatientData.IsPatientExists(PatientID);
        }
        bool _AddNewAppointment()
        {

            //Check Patient is Exists //I can Add here my message
            if (_CheckPatientIsExists(this.PatientID) == false)
                return false;


            //Check Doctor is Exists 
            if (!_CheckDoctorIsExists(this.DoctorID))
                return false;

            //Also I Have To Check MedicalRecordID and PaymentID if exists before to add, They Allow Null

            this.ID = clsAppointmentData.AddNewAppointment(this.PatientID, this.DoctorID, this.DateTime, this.Status, this.MedicalRecordID, this.PaymentID);
           return (this.ID != -1);
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Update:
                    return _UpdateAppointment();
                case enMode.Addnew:
                    if(_AddNewAppointment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }else
                    {  return false;}
            }
            return false;
        }

        public static bool IsAppointmentExists(int AppointmentID)
        {
            return clsAppointmentData.IsAppointmentExists(AppointmentID);
        }

        public static bool DeleteAppointment(int AppointmentID)
        {
            return clsAppointmentData.DeleteAppointment(AppointmentID);
        }
    }
}
