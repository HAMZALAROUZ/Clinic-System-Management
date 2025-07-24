using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using ClinicPrescriptionDataAccessLayer;
namespace ClinicPrescriptionBusinessLayer
{
    public class clsPrescription
    {
        enum enMode { enAddNew = 0,enUpdate = 1 }
        enMode Mode = enMode.enAddNew;

        

        public int ID {  get; set; }
        public int MedicalRecordID { get; set; }
        public string MedicationName { get; set; }
        public string Dosage {  get; set; }
        public string Frequency {  get; set; }

        public DateTime StartDate {  get; set; }
        public DateTime EndDate {  get; set; }
        public string SpecialInstructions {  get; set; }

        public clsPrescription()
        {
            ID = -1;
            MedicalRecordID = -1;
            MedicationName = string.Empty;
            Dosage = string.Empty;
            Frequency = string.Empty;
            StartDate = DateTime.MinValue;
            EndDate = DateTime.MinValue;
            SpecialInstructions = string.Empty;
            Mode = enMode.enAddNew;
        }
        clsPrescription(int _ID, int _MedicalRecordID, string _MedicationName, string _Dosage, string _Frequency, DateTime _StartDate, DateTime _EndDate, string _SpecialInstructions)
        {
            ID = _ID;
            MedicalRecordID = _MedicalRecordID;
            MedicationName = _MedicationName;
            Dosage = _Dosage;
            Frequency = _Frequency;
            StartDate = _StartDate;
            EndDate = _EndDate;
            SpecialInstructions = _SpecialInstructions;
            Mode = enMode.enUpdate;
        }
        bool _AddNewPrescription()
        {
            this.ID = clsPrescriptionData.AddNewPrescription(this.MedicalRecordID, this.MedicationName, this.Dosage, this.Frequency, this.StartDate, this.EndDate, this.SpecialInstructions);
                return (this.ID != -1);
        }
        bool _UpdatePrescription()
        {
            return clsPrescriptionData.UpdatePrescription(this.ID,this.MedicalRecordID, this.MedicationName, this.Dosage, this.Frequency, this.StartDate, this.EndDate, this.SpecialInstructions);
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.enAddNew:
                    if (_AddNewPrescription())
                    {
                        Mode = enMode.enUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.enUpdate:
                    return _UpdatePrescription();
            }
            return false;
        }

        public static clsPrescription FindPrescription(int ID)
        {
            
            int _MedicalRecordID = -1;
            string _MedicationName = "";
            string _Dosage = "";
            string _Frequency = "";
            DateTime _StartDate = DateTime.MinValue;
            DateTime _EndDate = DateTime.MinValue;
            string _SpecialeInstructions = "";

            if(clsPrescriptionData.FindPrescription(ID,ref _MedicalRecordID, ref _MedicationName, ref _Dosage, ref _Frequency, ref _StartDate, ref _EndDate, ref _SpecialeInstructions))
            {
                return new clsPrescription(ID, _MedicalRecordID, _MedicationName, _Dosage, _Frequency, _StartDate, _EndDate, _SpecialeInstructions);
            }
            return null;
        }

        public static bool DeletePrescription(int ID)
        {
            return clsPrescriptionData.DeletePrescription(ID);
        }

        public static DataTable GelAllPrescriptions()
        {
            return clsPrescriptionData.GetAllPrescriptions();
        }
        public static bool IsPrescriptionExists(int ID)
        {
            return clsPrescriptionData.IsPrescriptionExists(ID);
        }
    }
}
