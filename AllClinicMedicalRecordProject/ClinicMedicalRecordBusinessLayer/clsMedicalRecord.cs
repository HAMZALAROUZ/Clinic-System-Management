using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicMedicalRecordDataAcccessLayer;
namespace ClinicMedicalRecordBusinessLayer
{
    public class clsMedicalRecord
    {
        enum enMode { enAddNew = 0, enUpdate = 1 }
        enMode Mode = enMode.enAddNew;

        //public int CurrentID = -1;
        public int ID { get; set; }
        public string VisitDescription { get; set; }
        public string Diagnosis { get; set; }
        public string AdditionalNotes { get; set; }

        public clsMedicalRecord()
        {
            Mode = enMode.enAddNew;
            ID = -1;
            VisitDescription = "";
            Diagnosis = "";
            AdditionalNotes = "";
        }
        clsMedicalRecord(int iD, string visitDescription, string diagnosis, string additionalNotes)
        {
            Mode = enMode.enUpdate;            
            ID = iD;
            VisitDescription = visitDescription;
            Diagnosis = diagnosis;
            AdditionalNotes = additionalNotes;
        }

        bool _UpdateMedicalRecord()
        {
            return clsMedicalRecordData.UpdateMedicalRecord(this.ID,this.VisitDescription, this.Diagnosis, this.AdditionalNotes);
        }
        bool _AddNewMedicalRecord()
        {
            this.ID = clsMedicalRecordData.AddNewMedicalRecord(this.VisitDescription, this.Diagnosis, this.AdditionalNotes);
            return (this.ID != -1);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.enAddNew:
                    if (_AddNewMedicalRecord())
                    {
                        Mode = enMode.enUpdate;
                        return true;
                    }
                    else { return false; }

                case enMode.enUpdate:
                    return _UpdateMedicalRecord();
            }

            return false;
        }

        public static bool DeleteMedicalRecord(int Id)
        {
            return clsMedicalRecordData.DeleteMedicalRecord(Id);
        }

        public static clsMedicalRecord FindMedicalRecord(int MedicalRecord)
        {
           
            string visitDescription = "";
            string diagnosis = "";
            string additionalNotes = "";

            if(clsMedicalRecordData.FindMedicalRecord(MedicalRecord, ref visitDescription, ref diagnosis, ref additionalNotes))
            {
                return new clsMedicalRecord(MedicalRecord, visitDescription, diagnosis, additionalNotes);
            }
            return null;
        }

        public static bool IsMedicalRecordExists(int Id)
        {
            return clsMedicalRecordData.IsMedicalRecordExists(Id);
        }

        public static DataTable GetAllMedicalRecords()
        {
            return clsMedicalRecordData.GelAllMedicalRecords();
        }
    }
}
