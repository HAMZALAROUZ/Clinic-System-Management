using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicPaymentBusinessLayer;

namespace ClinicPaymentProject
{
    internal class Program
    {
        public static void GetAllPayments()
        {
            DataTable dt_Payment = clsPayment.GetAllPayment();

            if(dt_Payment != null )
            {
                Console.WriteLine("Payment Records:\n");
                foreach(DataRow row in dt_Payment.Rows)
                {
                    Console.WriteLine("ID : "+row["PaymentID"]);
                    Console.WriteLine("Date : "+row["PaymentDate"]);
                    Console.WriteLine("Method : "+row["PaymentMethod"]);
                    Console.WriteLine("Method : "+row["AmountPaid"]);
                    Console.WriteLine("Notes : " + row["AdditionalNotes"]);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Payment Table Data Is Empty");
            }
        }
        public static void AddNewPayment()
        {
            clsPayment payment = new clsPayment();

            payment.PaymentDate = DateTime.Now;
            payment.PaymentMethod = null;
            payment.AmountPaid = 3000;
            payment.AdditionalNotes = null;

            if(payment.Save())
            {
                Console.WriteLine("New Payment Add With ID[" + payment.CurrentPaymentID + "]");
            }
            else
            {
                Console.WriteLine("Not Add");
            }
        }

        public static void UpdatePayment(int PaymentID)
        {
            clsPayment payment = clsPayment.FindPayment(PaymentID);

            if (payment != null)
            {
                payment.PaymentDate = DateTime.Now;
                payment.PaymentMethod = "pppp";
                payment.AmountPaid = 143;
                payment.AdditionalNotes = "pppp ";


                if (payment.Save())
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

        public static void FindPayment(int PaymentID)
        {
            clsPayment payment = clsPayment.FindPayment(PaymentID);

            if (payment != null)
            {
                Console.WriteLine(payment.ID);
                Console.WriteLine(payment.PaymentDate);
                Console.WriteLine(payment.PaymentMethod);
                Console.WriteLine(payment.AmountPaid);
                Console.WriteLine(payment.AdditionalNotes);
            }
            else { Console.WriteLine("not found"); }
        }

        public static void DeletePayment(int PaymentID)
        {
            if(clsPayment.DeletePayment(PaymentID))
            {
                Console.WriteLine("Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Not Deleted");
            }
        }
        static void Main(string[] args)
        {
            GetAllPayments();
            //AddNewPayment();
            //DeletePayment(1);
            Console.ReadKey();
        }
    }
}
