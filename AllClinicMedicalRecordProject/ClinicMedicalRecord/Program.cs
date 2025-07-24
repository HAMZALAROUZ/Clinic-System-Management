using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicMedicalRecordBusinessLayer;
namespace ClinicMedicalRecord
{
    internal class Program
    {
        public static void AddNew()
        {
            clsMedicalRecord MR = new clsMedicalRecord();

            MR.VisitDescription = "nothing";
            MR.Diagnosis = "nothing";
            MR.AdditionalNotes = null;

            if (MR.Save())
            {
                Console.WriteLine("Added");
            }
            else
            {
                Console.WriteLine("Not added");
            }

        }
        public static void Update(int id)
        {
            clsMedicalRecord MR = clsMedicalRecord.FindMedicalRecord(id);

            if(MR != null )
            {
                MR.VisitDescription = "nothing1";
                MR.Diagnosis = null;
                MR.AdditionalNotes = "nothing1";
                if(MR.Save())
                {
                    Console.WriteLine("Updated");
                }
                else
                {
                    Console.WriteLine("not Updated");

                }
            }
        }
        public static void GetAlldata()
        {
            DataTable dt = clsMedicalRecord.GetAllMedicalRecords();

            if(dt != null)
            {
                foreach(DataRow row in dt.Rows)
                {
                    Console.WriteLine(row["MedicalRecordID"]);
                    Console.WriteLine(row["visitDescription"]);
                    Console.WriteLine(row["Diagnosis"]);
                    Console.WriteLine(row["AdditionalNotes"]);
                }
            }
        }
        public static void Delete(int id)
        {
            if(clsMedicalRecord.DeleteMedicalRecord(id))
            {
                Console.WriteLine("Deleted");
            }
            else
            {
                Console.WriteLine("Not Deleted");
            }
        }
        public static void IsExists(int id)
        {
            if (clsMedicalRecord.IsMedicalRecordExists(id))
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("not found");
            }
        }
        static void Main(string[] args)
        {
            //AddNew();
            //GetAlldata();
            //Update(1);
            //Find()
            //IsExists(2);

            Console.ReadKey();
        }
    }
}
