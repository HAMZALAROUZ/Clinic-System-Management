using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicDoctorDataAccessLayer;
using ClinicPersonBusinessLayer;
using System.Data;
using System.Xml.Linq;

namespace ClinicDoctorsBusinessLayer
{
    public class clsDoctor : clsPerson
    {
        public int DoctorID { get; set; }

        public string Specialization { get; set; }

        //public int NewDoctorID = -1;

        public clsDoctor()
        {
            DoctorID = -1;
            Specialization = null;
            PersonID = -1;
            Mode = enMode.AddNew;
        }
        clsDoctor(int _DoctorID, int _PersonID, string _Specialization)
        {
            DoctorID = _DoctorID;
            Specialization = _Specialization;
            PersonID = _PersonID;
            Mode = enMode.Update;
        }
        public static bool IsDoctorHasAppointments(int DoctorID)
        {
            return clsDoctorData.IsDoctorHasAppointments(DoctorID);
        }
        public static bool DeleteDoctor(int DoctorID)
        {
            if (!clsDoctorData.IsDoctorExists(DoctorID))
                return false;

            if (clsDoctorData.IsDoctorHasAppointments(DoctorID))
            {

                if (!clsDoctorData.DeleteAllAppointmentsOfDoctor(DoctorID))
                    return false;
            }


            int PersonID = -1;
            string Specialization = "";
            if (clsDoctorData.FindDoctor(DoctorID, ref PersonID, ref Specialization))
            {
                if (!clsDoctorData.DeleteDoctorByDoctorID(DoctorID))
                {
                    return false;
                }
            }
            if (clsPerson.DeletePerson(PersonID))
            {
                return true;
            }
            //return false if deleted

            return false;
        }
        public static bool IsTableEmpty()
        {
            return clsDoctorData.IsTableEmpty();
        }
        public static DataTable GetAllDoctorsData()
        {
            return clsDoctorData.GetAllDoctorsData();
        }

        public static clsDoctor FindDoctor(int DoctorID)
        {
            int PersonID = -1;
            string Specialization = null;

            clsDoctor Doctor = new clsDoctor();
            clsPerson Person = new clsPerson();

            if (clsDoctorData.FindDoctor(DoctorID, ref PersonID, ref Specialization))
            {
                Doctor = new clsDoctor(DoctorID, PersonID, Specialization);
                Person = clsPerson.FindPerson(PersonID);

                if (Person != null)
                {


                    Doctor.Name = Person.Name;
                    Doctor.DateOfBirth = Person.DateOfBirth;
                    Doctor.Gender = Person.Gender;
                    Doctor.Email = Person.Email;
                    Doctor.Address = Person.Address;
                    Doctor.PhoneNumber = Person.PhoneNumber;
                    return Doctor;
                }

            }

            return null;
        }

        bool _AddNewDoctor()
        {
            if (base.Save())
            {
                
                this.DoctorID = clsDoctorData.AddNewDoctor(this.PersonID, this.Specialization);
                return (this.DoctorID != -1);
            }
            return false;
        }
        bool _UpdateDoctor()
        {
            if (base.Save())
            {

                return clsDoctorData.UpdateDoctor(this.DoctorID, this.Specialization);
            }
            return false;
        }
        public override bool Save()
        {
            switch (Mode)
            {

                case enMode.AddNew:
                    if (_AddNewDoctor())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return _UpdateDoctor();

            }
            return false;
        }
    }
}
