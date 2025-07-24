using ClinicPaymentBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSystemFormProject
{
    public partial class AddPaymentFrm : Form 
    {
        public AddPaymentFrm()
        {
            InitializeComponent();
        }
        public AddPaymentFrm(clsPayment _Payment)
        {
            InitializeComponent();
            Payment = _Payment;
        }
        bool IsLoading = false;
        clsPayment Payment = new clsPayment();
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void FillPaymentMethodCMB()
        {
            string[] arData = { "Cash", "Credit/Debit Cards" , "Bank Transfers", "Digital Wallets", "Crypto Wallets" };
            cmbPaymentMethod.Items.AddRange(arData);
            
        }
        private void AddPaymentFrm_Load(object sender, EventArgs e)
        {
            IsLoading = true;
            FillPaymentMethodCMB();
            if(ClinicMainForm.Mode == ClinicMainForm.enMode.enAdd)
            {
                //btnAdd.Text = "Add";
                //btnClear.Text = "Clear";
                lbTitle.Text = "Add New Payment";
            }
            if (ClinicMainForm.Mode == ClinicMainForm.enMode.enUpdate)
            {
                dtpPaymentDateTime.Value = Payment.PaymentDate;
                txbAmount.Text = Payment.AmountPaid.ToString();
                rtbNotes.Text = Payment.AdditionalNotes;
                cmbPaymentMethod.SelectedItem = Payment.PaymentMethod.ToString();
                lbID.Text = Payment.ID.ToString();
                //btnAdd.Text = "Update";
                //btnClear.Text = "Cancel";
                lbTitle.Text = "Update Payment";
                
            }
            IsLoading = false;
        }

        bool ValidateData()
        {
            if (cmbPaymentMethod.SelectedItem == null)
            {
                MessageBox.Show("Select Payment Method", "Invalide Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txbAmount.Text == string.Empty)
            {
                MessageBox.Show("Set Amount", "Invalide Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }
            if (!decimal.TryParse(txbAmount.Text, out decimal amount))
            {
                MessageBox.Show("Enter Only Digits For Amount Please", "Invalide Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        bool SavePayment()
        {
            Payment.PaymentDate = dtpPaymentDateTime.Value;
            if (rtbNotes.Text == string.Empty)
                Payment.AdditionalNotes = null;
            else
                Payment.AdditionalNotes = rtbNotes.Text;

            if (decimal.TryParse(txbAmount.Text, out decimal amount))
                Payment.AmountPaid = amount;

            Payment.PaymentMethod = cmbPaymentMethod.SelectedItem.ToString();

            if (Payment.Save())
            {
                return true;
            }
            return false;
        }
        //I Replace This Method With SavePayment()
        bool AddNewPayment()
        {
            Payment.PaymentDate = dtpPaymentDateTime.Value;
            if (rtbNotes.Text == string.Empty)
                Payment.AdditionalNotes = null;
            else
                Payment.AdditionalNotes = rtbNotes.Text;

            if (decimal.TryParse(txbAmount.Text, out decimal amount))
                Payment.AmountPaid = amount;

            Payment.PaymentMethod = cmbPaymentMethod.SelectedItem.ToString();

            if (Payment.Save())
            {
                return true;
            }
            return false;
        }

        
        bool UpdatePayment()
        {
            Payment.PaymentDate = dtpPaymentDateTime.Value;

            if (rtbNotes.Text == string.Empty)
                Payment.AdditionalNotes = null;
            else
                Payment.AdditionalNotes = rtbNotes.Text;

            Payment.PaymentMethod = cmbPaymentMethod.SelectedItem.ToString();

            if(decimal.TryParse(txbAmount.Text,out decimal amount))
            {
                Payment.AmountPaid = amount;
            }
            if (Payment.Save())
            {
                return true;
            }
            return false;
        }
       

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
                return;

            if (ClinicMainForm.Mode == ClinicMainForm.enMode.enAdd)
            {

                if (SavePayment())
                {
                    MessageBox.Show("Added", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbTitle.Text = "Update Payment";
                    lbID.Text = Payment.ID.ToString();
                    ClinicMainForm.Mode = ClinicMainForm.enMode.enUpdate;
                    return;
                }
                else
                {
                    MessageBox.Show("Not Added", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (ClinicMainForm.Mode == ClinicMainForm.enMode.enUpdate)
            {

                if (SavePayment())
                {
                    MessageBox.Show("Updated", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Not Updated", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Cash//Credit/Debit Cards//Bank Transfers//Digital Wallets//Crypto Wallets
        //before to delete i have first delete appointment and then payment recorde
    }
}
