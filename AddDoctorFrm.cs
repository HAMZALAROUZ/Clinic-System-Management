using ClinicDoctorsBusinessLayer;
using ClinicPatientBusinessLayer;
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
    public partial class AddDoctorFrm : Form
    {
        public AddDoctorFrm()
        {
            InitializeComponent();
        }

        clsDoctor Doctor = new clsDoctor();
        public AddDoctorFrm(clsDoctor _Doctor)
        {
            InitializeComponent();
            Doctor = _Doctor;
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
        bool ValidateInsertedData()
        {
            if (string.IsNullOrWhiteSpace(txbName.Text))
            {
                MessageBox.Show("Set Name", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            if (string.IsNullOrWhiteSpace(txbPhoneNumber.Text))
            {
                MessageBox.Show("Please set the phone number.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }


            if (!DateTime.TryParse(mtxbDateOfBirth.Text, out DateTime Date))
            {


                MessageBox.Show("The entered date is invalid.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        void FillObjectWithData()
        {
            Doctor.Name = txbName.Text;
            Doctor.PhoneNumber = txbPhoneNumber.Text;
            DateTime.TryParse(mtxbDateOfBirth.Text, out DateTime Date);
            Doctor.DateOfBirth = Date;

            if (rbMale.Checked)
            {
                Doctor.Gender = 'M';
            }
            else
            {
                Doctor.Gender = 'F';
            }

            if (!string.IsNullOrWhiteSpace(txbEmail.Text))
                Doctor.Email = txbEmail.Text;
            else
                Doctor.Email = null;

            if (!string.IsNullOrWhiteSpace(txbAddress.Text))
                Doctor.Address = txbAddress.Text;
            else
                Doctor.Address = null;

            if (!string.IsNullOrWhiteSpace(txbSpecialization.Text))
                Doctor.Specialization = txbSpecialization.Text;
            else
                Doctor.Specialization = null;

        }
        void AddNewDoctor()
        {
            if (!ValidateInsertedData())
                return;



            FillObjectWithData();

            if (Doctor.Save())
            {
                MessageBox.Show("Doctor added successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbTitle.Text = "Update Doctor";
                ClinicMainForm.Mode = ClinicMainForm.enMode.enUpdate;
                lbID.Text = Doctor.DoctorID.ToString();
            }
            else
            {
                MessageBox.Show("Failed to add the doctor.", "Action Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        void UpdateDoctor()
        {
            if (!ValidateInsertedData())
                return;

            int.TryParse(lbID.Text, out int _DoctorID);
            Doctor = clsDoctor.FindDoctor(_DoctorID);

            if (Doctor == null)
            {
                MessageBox.Show("Sorry, this doctor was not found.", "Doctor Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            FillObjectWithData();


            if (Doctor.Save())
            {
                MessageBox.Show("Doctor updated successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update the doctor.", "Action Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

                        
        private void FillFormWithData()
        {
            txbName.Text = Doctor.Name;
            txbAddress.Text = Doctor.Address;
            txbPhoneNumber.Text = Doctor.PhoneNumber;
            txbEmail.Text = Doctor.Email;
            txbSpecialization.Text= Doctor.Specialization;

            if (DateTime.TryParse(Doctor.DateOfBirth.ToString(), out DateTime date))
            {
                mtxbDateOfBirth.Text = Doctor.DateOfBirth?.ToString("MM/dd/yyyy") ?? "N/A";
            }

            if (Doctor.Gender == 'F')
            {
                rbFemale.Checked = true;
            }
            else
            {
                rbMale.Checked = true;
            }
        }
        private void AddDoctorFrm_Load(object sender, EventArgs e)
        {
            if (ClinicMainForm.Mode == ClinicMainForm.enMode.enAdd)
            {
                lbTitle.Text = "Add New Doctor";
                
            }
            if (ClinicMainForm.Mode == ClinicMainForm.enMode.enUpdate)
            {
                lbTitle.Text = "Update Doctor";
                lbID.Text = Doctor.DoctorID.ToString();
                FillFormWithData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ClinicMainForm.Mode == ClinicMainForm.enMode.enAdd)
            {
                AddNewDoctor();
            }
            else if (ClinicMainForm.Mode == ClinicMainForm.enMode.enUpdate)
            {
                UpdateDoctor();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
