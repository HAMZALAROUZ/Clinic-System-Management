using ClinicPatientBusinessLayer;
using ClinicPersonBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace ClinicSystemFormProject
{
    public partial class FrmAddPatient : Form
    {
        public FrmAddPatient()
        {
            InitializeComponent();
        }
        clsPatient Patient = new clsPatient();
        public FrmAddPatient(clsPatient _Patient) 
        {
            InitializeComponent();
            Patient = _Patient;
        }
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
        bool ValidateInsertedData()
        {
            if (string.IsNullOrEmpty(txbName.Text))
            {
                MessageBox.Show("Please enter the doctor's name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txbPhoneNumber.Text))
            {
                MessageBox.Show("Please enter the doctor's phone number.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            

            if (!DateTime.TryParse(mtxbDateOfBirth.Text, out DateTime Date))
            {


                MessageBox.Show("The entered date is invalid. Please check the format and try again.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            return true;
        }

        void FillObjectWithData()
        {
            Patient.Name = txbName.Text;
            Patient.PhoneNumber = txbPhoneNumber.Text;
            DateTime.TryParse(mtxbDateOfBirth.Text, out DateTime Date);
            Patient.DateOfBirth = Date;
            if (rbMale.Checked)
            {
                Patient.Gender = 'M';
            }
            else
            {
                Patient.Gender = 'F';
            }

            if (txbEmail.Text != string.Empty)
                Patient.Email = txbEmail.Text;
            else
                Patient.Email = null;

            if (txbAddress.Text != string.Empty)
                Patient.Address = txbAddress.Text;
            else
                Patient.Address = null;
        }
        private void AddNewPatient()
        {
            if(!ValidateInsertedData())
            {
                return;
            }

            



            FillObjectWithData();




            if (Patient.Save())
            {
                MessageBox.Show($"Successfully added patient: {Patient.Name}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lbTitle.Text = "Update Patient";
                lbPatientID.Text = Patient.PatientID.ToString();
                ClinicMainForm.Mode = ClinicMainForm.enMode.enUpdate;
            }
            else
            {
                MessageBox.Show("The patient could not be added. Please try again.", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }
        private void UpdatePatient()
        {
            if (!ValidateInsertedData())
            {
                return;

            }

            int.TryParse(lbPatientID.Text, out int _PatientID);
            Patient = clsPatient.FindPatient(_PatientID);

            if(Patient == null)
            {
                MessageBox.Show("Sorry, this patient was not found.", "Patient Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            FillObjectWithData();


            if (Patient.Save())
            {
                MessageBox.Show("Patient \"" + Patient.Name + "\" has been updated successfully.", "Update Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Failed to update the patient.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
        
        
        

        
        private void FillFormWithData()
        {
            txbName.Text = Patient.Name;
            txbAddress.Text = Patient.Address;            
            txbPhoneNumber.Text = Patient.PhoneNumber;
            txbEmail.Text = Patient.Email;
            lbPatientID.Text = Patient.PatientID.ToString();

            if(DateTime.TryParse(Patient.DateOfBirth.ToString(),out DateTime date))
            {

            mtxbDateOfBirth.Text = Patient.DateOfBirth?.ToString("MM/dd/yyyy") ?? "N/A";
            }

            if(Patient.Gender == 'F')
            {
                rbFemale.Checked = true;
            }
            else
            {
                rbMale.Checked = true;
            }
        }
        private void FrmAddPatient_Load(object sender, EventArgs e)
        {
            
            if(ClinicMainForm.Mode == ClinicMainForm.enMode.enAdd)
            {
                lbTitle.Text = "Add New Patient";
                
            }
            if(ClinicMainForm.Mode == ClinicMainForm.enMode.enUpdate)
            {
                lbTitle.Text = "Update Patient";                                
                FillFormWithData();
            }
        }

        private void FrmAddPatient_FormClosed(object sender, FormClosedEventArgs e)
        {
           // _MainForm.RefreshPatientList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ClinicMainForm.Mode == ClinicMainForm.enMode.enAdd)
            {
                AddNewPatient();
            }
            else if (ClinicMainForm.Mode == ClinicMainForm.enMode.enUpdate)
            {
                UpdatePatient();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
