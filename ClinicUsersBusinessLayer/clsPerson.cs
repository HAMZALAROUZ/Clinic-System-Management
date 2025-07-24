using ClinicPersonDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicPersonsBusinessLayer
{
    public class clsPerson
    {
        enum enMode { Update = 0, AddNew = 1 }

        enMode Mode = enMode.Update;

        public int CurrentPersonID = -1;//turn this to Private When Using Forms
        public int ID { get; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }        
        public char Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public clsPerson()
        {
            ID = -1;
            Name = "";
            DateOfBirth = new DateTime();           
            Gender = '\0';
            PhoneNumber = "";
            Email = "";
            Address = "";
            Mode = enMode.AddNew;
        }
        clsPerson(int iD, string name, DateTime dateOfBirth, char gender, string phoneNumber, string email, string address)
        {
            Mode = enMode.Update;
            ID = iD;
            Name = name;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
        }

        bool _AddNewPerson()
        {
           CurrentPersonID = clsPersonData.AddNewPerson(this.Name, this.Gender, this.DateOfBirth,this.PhoneNumber, this.Email,this.Address);
            return (CurrentPersonID!=-1);
        }
        bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.ID, this.Name, this.DateOfBirth, this.Gender, this.PhoneNumber, this.Email, this.Address);
        }
        public static DataTable GetAllPersonsData()
        {
            return clsPersonData.GetAllPersonsData();
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                   if(_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                   else{ return false; }

                case enMode.Update:
                    return _UpdatePerson();
            }

            return false;
        }

        public static clsPerson FindPerson(int PersonID)
        {
            string Name = "";
            DateTime DateOfBirth = new DateTime();
            string Email = "", Address = "";
            char Gender = '\0';
            string PhoneNumber = "";

            if(clsPersonData.FindPerson(PersonID, ref Name, ref DateOfBirth, ref Gender, ref PhoneNumber, ref Email, ref Address))
            {
                return new clsPerson(PersonID, Name, DateOfBirth, Gender, PhoneNumber, Email, Address);
            }
            return null;
        }

        public static clsPerson FindPerson(string PersonName)
        {
            int PersonID = -1;
            DateTime DateOfBirth = new DateTime();
            string Email = "", Address = "";
            char Gender = '\0';
            string PhoneNumber = "";

            if (clsPersonData.FindPerson(ref PersonID,  PersonName, ref DateOfBirth, ref Gender, ref PhoneNumber, ref Email, ref Address))
            {
                return new clsPerson(PersonID, PersonName, DateOfBirth, Gender, PhoneNumber, Email, Address);
            }
            return null;
        }
        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }

        public static bool IsPersonExists(int PersonID)
        {
            return clsPersonData.IsPersonExists(PersonID);
        }
    }
}
