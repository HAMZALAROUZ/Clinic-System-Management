using ClinicPersonBusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicPersonPresentationLayer
{
    internal class Program
    {

        //public static void AddNewPatient()
        //{
        //    clsPerson Person = new clsPerson();
        //    //new DateTime(1998, 02, 04)
        //    Person.Name = "Patient2";
        //    Person.Gender = 'M';
        //    Person.DateOfBirth = new DateTime(2000,02,20);
        //    Person.PhoneNumber = "0633428793";
        //    Person.Email = "ER@gmail.com";
        //    Person.Address = null;
        //    //Person.Specialization = "Test";
        //    Person.AnyPerson = clsPerson.enAnyPerson.enPatient;

        //    if (Person.Save())
        //    {
        //        Console.WriteLine("Patient Add Successfully With ID[" + Person.CurrentPersonID + "] ");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Patient Add Faild");
        //    }
        //}
        //public static void AddNewDoctor()
        //{
        //    clsPerson Person = new clsPerson();
        //    //new DateTime(1998, 02, 04)
        //    Person.Name = "Doctor";
        //    Person.Gender = 'M';
        //    Person.DateOfBirth = new DateTime(2000, 02, 20);
        //    Person.PhoneNumber = "0633428793";
        //    Person.Email = "ER@gmail.com";
        //    Person.Address = null;
        //    Person.Specialization = "Test";
        //    Person.AnyPerson = clsPerson.enAnyPerson.enDoctor;

        //    if (Person.Save())
        //    {
        //        Console.WriteLine("Doctor Add Successfully With ID[" + Person.CurrentPersonID + "] ");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Doctor Add Faild");
        //    }
        //}
        //public static void GetAllPersonsData()
        //{
        //    DataTable dt = clsPerson.GetAllPersonsData();

        //    try
        //    {
        //        foreach (DataRow row in dt.Rows)
        //        {
        //            Console.WriteLine("ID          : {0}", row["PersonID"]);
        //            Console.WriteLine("Name        : {0}", row["Name"]);
        //            Console.WriteLine("DateOfBirth : {0}", row["DateOfBirth"]);
        //            Console.WriteLine("Gender      : {0}", row["Gender"]);
        //            Console.WriteLine("Phone Number: {0}", row["PhoneNumber"]);
        //            Console.WriteLine("Email       : {0}", row["Email"]);
        //            Console.WriteLine("Address     : {0}", row["Address"]);
        //            Console.WriteLine();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.ToString());
        //    }
        //}

        //public static void FindPerson(int ID)
        //{
        //    clsPerson person = clsPerson.FindPerson(ID);

        //    if (person != null)
        //    {
        //        Console.WriteLine("ID          : {0}", person.ID);
        //        Console.WriteLine("Name        : {0}", person.Name);
        //        Console.WriteLine("DateOfBirth : {0}", person.DateOfBirth);
        //        Console.WriteLine("Gender      : {0}", person.Gender);
        //        Console.WriteLine("Phone Number: {0}", person.PhoneNumber);
        //        Console.WriteLine("Email       : {0}", person.Email);
        //        Console.WriteLine("Address     : {0}", person.Address);
        //        Console.WriteLine();


        //    }
        //    else
        //    {
        //        Console.WriteLine("Person Not Found");
        //    }
        //}
        //public static void UpdateDoctor(int DoctorID)
        //{
        //    int PersonID = clsPerson.GetPersonIDFromDoctor(DoctorID);
        //    if (PersonID == -1)
        //        return;

        //    clsPerson Person = clsPerson.FindPerson(PersonID);

        //    if (Person != null)
        //    {
        //        Person.Name = "Doctor";
        //        Person.Gender = 'F';
        //        Person.DateOfBirth = new DateTime(2001, 02, 20);
        //        Person.PhoneNumber = "0633428793";
        //        Person.Email = null;
        //        Person.Address = null;
        //        Person.Specialization = "Changed";
        //        Person.AnyPerson = clsPerson.enAnyPerson.enDoctor;

        //        if (Person.Save())
        //        {
        //            Console.WriteLine("Doctor Updated Successfully With ID[" + Person.ID + "] ");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Doctor Update Faild");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Doctor Not Found");
        //    }
        //}
        //public static void UpdatePatient(int PatientID)
        //{
        //    int PersonID = clsPerson.GetPersonIDFromPatient(PatientID);
        //    if (PersonID == -1)
        //        return;

        //    clsPerson Person = clsPerson.FindPerson(PersonID);

        //    if (Person != null)
        //    {
        //        Person.Name = "Patient";
        //        Person.Gender = 'F';
        //        Person.DateOfBirth = new DateTime(2001, 02, 20);
        //        Person.PhoneNumber = "0633428793";
        //        Person.Email = null;
        //        Person.Address = null;
        //        Person.AnyPerson = clsPerson.enAnyPerson.enPatient;
                
        //        if (Person.Save())
        //        {
        //            Console.WriteLine("Patient Updated Successfully With ID[" + Person.ID + "] ");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Patient Update Faild");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Patient Not Found");
        //    }
        //}
        //public static void DeletePerson(int PersonID)
        //{

        //    if (clsPerson.DeletePerson(PersonID))
        //    {
        //        Console.WriteLine("Person Deleted Successfully");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not Deleted");
        //    }
        //}

        //public static void IsPersonExists(int PersonID)
        //{
        //    if (clsPerson.IsPersonExists(PersonID))
        //    {
        //        Console.WriteLine("Found");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not Found");
        //    }
        //}
        //public static void DeletePatient(int id)
        //{
        //    if(clsPerson.DeletePatient(id))
        //    {
        //        Console.WriteLine("Deleted");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not Deleted");
        //    }
        //}
        //public static void DeleteDoctor(int id)
        //{
        //    if (clsPerson.DeleteDoctor(id))
        //    {
        //        Console.WriteLine("Deleted");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not Deleted");
        //    }
        //}
        static void Main(string[] args)
        {
            //FindPerson(1);
            //AddNewPerson();
            //DeletePerson(2);
            //UpdatePerson(7);
            // UpdatePatient(6);
            //UpdateDoctor(7);
            //AddNewDoctor();
            //AddNewPatient();
            //DeletePatient(7);
           //DeleteDoctor(8);
            Console.ReadKey();
        }
    }
}
