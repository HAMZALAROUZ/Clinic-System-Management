using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicPatientDataAccessLayer;
using System.Net;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using ClinicPersonBusinessLayer;
using System.Data;
namespace ClinicPatientBusinessLayer
{
    public class clsPatient : clsPerson
    {
        public int PatientID { get; set; } //I will Test to return this to protected

        //enum enMode { Addnew = 0, Update = 1 }
        //enMode Mode = enMode.Addnew;

        public clsPatient()
        {
            PatientID = -1;
            PersonID = -1;
            Mode = enMode.AddNew;

        }


        clsPatient(int _PatientID, int _PersonID)
        {
            PatientID = _PatientID;
            PersonID = _PersonID;
            Mode = enMode.Update;
        }

        public static bool IsExists(int id)
        {
            return clsPatientData.IsPatientExists(id);

        }
        public static DataTable GetAllPatientsData()
        {
            return clsPatientData.GetAllPatients();
        }

        bool _AddNewPatient()
        {
            if(base.Save())
            {
                this.PatientID = clsPatientData.AddNewPatient(this.PersonID);
                return (this.PatientID != -1);

            }
            return false;
            
            
        }
        public static bool IsPatientHasAppointments(int PatientID)
        {
            return clsPatientData.IsPatientHaveAppointments(PatientID);
        }
        public static bool DeletePatient(int id)
        {
            if (!clsPatientData.IsPatientExists(id))
                return false;

            //First Check is related in appointment if it's 
            //ask user that will lose any appointments related to this patient
            //if accepte then delete appointments by appointment method
            //then return record of this patient
            //then delete patient
            //then delete person 

            if (clsPatientData.IsPatientHaveAppointments(id))
            {
                //Ask User

                //Delete appointments
                if (!clsPatientData.DeleteAllAppointmentOfPatient(id))//this if not found any related patient will return false
                {
                    return false;
                }

            }

            int PersonID = -1;
            if (clsPatientData.FindPatient(id, ref PersonID))
            {
                if (!clsPatientData.DeletePatientByPatientID(id))
                {
                    return false;

                }
            }

            if (clsPerson.DeletePerson(PersonID))
            {
                return true;
            }

            return false;

        }

        public static clsPatient FindPatient(int PatientID)
        {
            int PersonID = -1;

            clsPatient Patient = new clsPatient();
            clsPerson Person = new clsPerson();

            if (clsPatientData.FindPatient(PatientID, ref PersonID))
            {

                Person = clsPerson.FindPerson(PersonID);
                //Patient = new clsPatient(PatientID,PersonID,Person.Name,Person.DateOfBirth,Person.Gender,Person.PhoneNumber,Person.Email,Person.Address);
                Patient = new clsPatient(PatientID, PersonID);

                //Patient.Mode = enMode.enUpdate;

                if (Person != null)
                {

                    Patient.Name = Person.Name;
                    Patient.Address = Person.Address;
                    Patient.Email = Person.Email;
                    Patient.DateOfBirth = Person.DateOfBirth;
                    Patient.Gender = Person.Gender;
                    Patient.PhoneNumber = Person.PhoneNumber;
                    return Patient;
                }
            }
            return null;
        }
        private bool _UpdatePatient()
        {
            if (base.Save())
            {
                return true;
            }
            return false;
        }
        public static bool IsTableEmpty()
        {
            return clsPatientData.IsTableEmpty();
        }
        public override bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPatient())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return _UpdatePatient();

            }
            return false;
        }
    }
}
