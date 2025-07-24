using ClinicPersonDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml.Linq;
namespace ClinicPersonBusinessLayer
{
    public class clsPerson
    {
        protected enum enMode { Update = 0, AddNew = 1 }

        protected enMode Mode = enMode.Update;

        //i can delete this
        public enum enAnyPerson { enPatient = 0, enDoctor = 1, enNoOne = 2 }
        public enAnyPerson AnyPerson = enAnyPerson.enNoOne;

        //public int NewPersonID = -1;//turn this to Private When Using Forms

        protected int PersonID { get; set; }
        public string Name { get; set; }
        public Nullable<DateTime> DateOfBirth { get; set; }
        public char Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }



        public clsPerson()
        {
            PersonID = -1;
            Name = "g";
            DateOfBirth = new DateTime();
            Gender = '\0';
            PhoneNumber = "";
            Email = "";
            Address = "";
            Mode = enMode.AddNew;



        }
        protected clsPerson(int PersonID, string name, Nullable<DateTime> dateOfBirth, char gender, string phoneNumber, string email, string address)
        {
            Mode = enMode.Update;
            this.PersonID = PersonID;
            Name = name;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;

        }
        protected static clsPerson GetPersonData(int PersonID)
        {
            string Name = "";
            Nullable<DateTime> DateOfBirth = new DateTime();
            string Email = "", Address = "";
            char Gender = '\0';
            string PhoneNumber = "";

            clsPerson person = new clsPerson();
            if (clsPersonData.FindPerson(PersonID, ref Name, ref DateOfBirth, ref Gender, ref PhoneNumber, ref Email, ref Address))
            {

                return new clsPerson(PersonID, Name, DateOfBirth, Gender, PhoneNumber, Email, Address);


            }
            return null;
        }

        bool _AddNewPerson()
        {
            this.PersonID = clsPersonData.AddNewPerson(this.Name, this.Gender, this.DateOfBirth, this.PhoneNumber, this.Email, this.Address);

            return (this.PersonID != -1);
        }

        bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.PersonID, this.Name, this.DateOfBirth, this.Gender, this.PhoneNumber, this.Email, this.Address);


        }
        protected static DataTable GetAllPersonsData()
        {
            return clsPersonData.GetAllPersonsData();
        }

        public virtual bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }

                case enMode.Update:
                    return _UpdatePerson();
            }

            return false;
        }

        protected static clsPerson FindPerson(int PersonID) //by ID
        {
            string Name = "";
            Nullable<DateTime> DateOfBirth = new DateTime();
            string Email = "", Address = "";
            char Gender = '\0';
            string PhoneNumber = "";


            if (clsPersonData.FindPerson(PersonID, ref Name, ref DateOfBirth, ref Gender, ref PhoneNumber, ref Email, ref Address))
            {
                return new clsPerson(PersonID, Name, DateOfBirth, Gender, PhoneNumber, Email, Address);
            }
            return null;
        }

        protected static clsPerson FindPerson(string PersonName) //by Name
        {
            int PersonID = -1;
            Nullable<DateTime> DateOfBirth = new DateTime();
            string Email = "", Address = "";
            char Gender = '\0';
            string PhoneNumber = "";

            if (clsPersonData.FindPerson(ref PersonID, PersonName, ref DateOfBirth, ref Gender, ref PhoneNumber, ref Email, ref Address))
            {
                return new clsPerson(PersonID, PersonName, DateOfBirth, Gender, PhoneNumber, Email, Address);
            }
            return null;
        }

        protected static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }
        protected static bool IsPersonExists(int PersonID)
        {
            return clsPersonData.IsPersonExists(PersonID);
        }
    }
}

