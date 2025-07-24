using ClinicAppointmentBusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppointmentsProject
{
    internal class Program
    {
        public static void GetAllApointments()
        {
            DataTable dt = clsAppointment.GetAllAppointments();

            if(dt != null)
            {
                Console.WriteLine("Appointments Records :\n");
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine(row["AppointmentID"]);
                    Console.WriteLine(row["PatientID"]);
                    Console.WriteLine(row["DoctorID"]);
                    Console.WriteLine(row["AppointmentDateTime"]);
                    Console.WriteLine(row["AppointmentStatus"]);
                    Console.WriteLine(row["MedicalRecordID"]);
                    Console.WriteLine(row["PaymentID"]);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No Records");
            }
        }

        public static void AddNewAppoin()
        {
            clsAppointment Appointment = new clsAppointment();

            Appointment.PatientID = 6;
            Appointment.DoctorID = 8;
            Appointment.DateTime = DateTime.Now;
            Appointment.Status = "Pending";
            Appointment.MedicalRecordID = null;
            Appointment.PaymentID = 4;

            if(Appointment.Save())
            {
                Console.WriteLine("Added ID :"+Appointment.CurrentID);
            }else
            {
                Console.WriteLine("Not Added");
            }

        }

        public static void DeleteAppointment(int ID)
        {
            if(clsAppointment.DeleteAppointment(ID))
            {
                Console.WriteLine("Deleted");
            }
            else
            {
                Console.WriteLine("Not Deleted");
            }
        }
        public static void UpdateAppointment(int AppointmentID)
        {
            clsAppointment appointment = clsAppointment.FindAppointment(AppointmentID);

            if(appointment != null)
            {
                appointment.PatientID = 3;
                appointment.DateTime = DateTime.Now;
                appointment.DoctorID = 1;                
                appointment.Status = "Canceled";
                appointment.PaymentID = 3;
                appointment.MedicalRecordID = null;

                if(appointment.Save())
                {
                    Console.WriteLine("Updated");
                }
                else
                {
                    Console.WriteLine("Not Updated");
                }
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }

        public static void IsExists(int ID)
        {
            if(clsAppointment.IsAppointmentExists(ID))
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
        static void Main(string[] args)
        {
            //GetAllApointments();
            AddNewAppoin();
            //DeleteAppointment(7);
            //UpdateAppointment(1);
            //IsExists(1);
            Console.ReadKey();
        }
    }
}
