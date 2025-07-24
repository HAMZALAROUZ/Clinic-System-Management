using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicPrescriptionBusinessLayer;
namespace ClinicPrescriptionsProject
{
    internal class Program
    {
        public static void GetAllData()
        {
            DataTable dt = clsPrescription.GelAllPrescriptions();

            if(dt != null )
            {
                Console.WriteLine("Record :\n");
                foreach(DataRow row in dt.Rows)
                {
                    Console.WriteLine("ID                 :"+row["PrescriptionID"]);
                    Console.WriteLine("MedicalRecordID    :" + row["MedicalRecordID"]);
                    Console.WriteLine("MedicationName     :" + row["MedicationName"]);
                    Console.WriteLine("Dosage             :" + row["Dosage"]);
                    Console.WriteLine("Frequency          :" + row["Frequency"]);
                    Console.WriteLine("StartDate          :" + row["StartDate"]);
                    Console.WriteLine("EndDate            :" + row["EndDate"]);
                    Console.WriteLine("SpecialInstructions:" + row["SpecialInstructions"]);
                    Console.WriteLine();
                }
            }else
            {
                Console.WriteLine("No Data");
            }
        }

        public static void AddNew()
        {
            clsPrescription prescription = new clsPrescription();

            prescription.MedicalRecordID = 2;
            prescription.MedicationName = "X-ray";
            prescription.Dosage = "Two";
            prescription.Frequency = "one per day";
            prescription.StartDate = DateTime.UtcNow;
            prescription.EndDate = new DateTime(2025,04,15);
            prescription.SpecialInstructions = null;

            if(prescription.Save())
            {
                Console.WriteLine("added");

            }
            else
            { Console.WriteLine("Not Added"); }
        }

        public static void Update(int id)
        {
            clsPrescription prescription = clsPrescription.FindPrescription(id);
            if (prescription != null)
            {
                prescription.MedicalRecordID = 2;
                prescription.MedicationName = "X-";
                prescription.Dosage = "one";
                prescription.Frequency = "two per day";
                prescription.StartDate = DateTime.UtcNow;
                prescription.EndDate = new DateTime(2025, 04, 15);
                prescription.SpecialInstructions = null;

                if(prescription.Save())
                {
                    Console.WriteLine("Updated");
                }
                else { Console.WriteLine("Not Updated"); }
            }
                else { Console.WriteLine("Not Found"); }
        }

        public static void IsExists(int id)
        {
            if(clsPrescription.IsPrescriptionExists(id))
            {
                Console.WriteLine("Exists");
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }
        public static void Delete(int id)
        {
            if(clsPrescription.DeletePrescription(id))
            {
                Console.WriteLine("Deleted");
            }
            else
            {
                Console.WriteLine("Not Deleted");
            }
        }
        static void Main(string[] args)
        {
            //GetAllData();
            //AddNew();
            //Update(1);
            //IsExists(2);
            //Delete(1);
            Console.ReadKey();
        }
    }
}
