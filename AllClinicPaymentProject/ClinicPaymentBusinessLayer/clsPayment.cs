using ClinicPaymentDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicPaymentBusinessLayer
{
    public class clsPayment
    {
        protected enum enMode { enAddNew = 0, enUpdate = 1 }
        protected enMode Mode = enMode.enAddNew;
        public int CurrentPaymentID = -1;
        public int ID { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public decimal AmountPaid { get; set; }
        public string AdditionalNotes { get; set; }

        public clsPayment()
        {
            ID = -1;
            PaymentDate = new DateTime();
            PaymentMethod = "";
            AmountPaid = -1;
            AdditionalNotes = "";
            Mode = enMode.enAddNew;
        }
        clsPayment(int id,DateTime paymentdate,string paymentmethod,decimal amountpaid,string additionalnotes)
        {
            ID = id;
            PaymentDate = paymentdate;
            PaymentMethod = paymentmethod;
            AmountPaid = amountpaid;
            AdditionalNotes = additionalnotes;
            Mode = enMode.enUpdate;
        }
        public static bool IsPaymentRelatedToAnyAppointment(int PaymentID)
        {
            return clsPaymentData.IsPaymentRelatedToAnyAppointment(PaymentID);
        }
        public static DataTable GetAllPayment()
        {
            return clsPaymentData.GetAllPayments();
        }

        bool _AddNewPayment()
        {
            this.ID = clsPaymentData.AddNewPayment(this.PaymentDate, this.PaymentMethod, this.AmountPaid, this.AdditionalNotes);
            return (this.ID != -1);
        }
        bool _UpdatePayment()
        {
            return clsPaymentData.UpdatePayment(this.ID, this.PaymentDate, this.PaymentMethod, this.AmountPaid, this.AdditionalNotes);
        }
        public static bool DeletePayment(int PaymentID)
        {
            return clsPaymentData.DeletePayment(PaymentID);
        }
        public static clsPayment FindPayment(int PaymentID)
        {
            DateTime paymentdate = new DateTime(); 
            string paymentmethod = "";
            decimal amountpaid = -1;
            string additionalnotes = "";

            if(clsPaymentData.FindPayment(PaymentID,ref paymentdate, ref paymentmethod, ref amountpaid, ref additionalnotes))
            {
                return new clsPayment(PaymentID, paymentdate, paymentmethod, amountpaid, additionalnotes);
            }
            return null;
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.enAddNew:
                    if(_AddNewPayment())
                    {
                        Mode = enMode.enUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.enUpdate:
                    return _UpdatePayment();
            }
            return false;
        }
    }
}
