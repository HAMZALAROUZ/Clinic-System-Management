using ClinicMedicalRecordBusinessLayer;
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
    public partial class AddMedicalRecordsFrm : Form
    {
        public AddMedicalRecordsFrm()
        {
            InitializeComponent();
        }
        public AddMedicalRecordsFrm(clsMedicalRecord _medicalRecord)
        {
            InitializeComponent();
            MedicalRecord = _medicalRecord;

        }
        clsMedicalRecord MedicalRecord = new clsMedicalRecord();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool ValidateData()
        {
            if(string.IsNullOrWhiteSpace(txbVisitDescription.Text))
                { return false; }

            if (string.IsNullOrWhiteSpace(txbDiagnosis.Text))
            { return false; }

            return true;
        }

        void AddNewMedicalRecord()
        {
            

            MedicalRecord.VisitDescription = txbVisitDescription.Text;
            MedicalRecord.Diagnosis = txbDiagnosis.Text;
            
            if(string.IsNullOrWhiteSpace(txbAdditionalNotes.Text))
            {
                MedicalRecord.AdditionalNotes = null;
            }
            else
            {
                MedicalRecord.AdditionalNotes = txbAdditionalNotes.Text;

            }

            if(MedicalRecord.Save())
            {
                MessageBox.Show("Medical record added successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClinicMainForm.Mode = ClinicMainForm.enMode.enUpdate;
                lbTitle.Text = "Update Medical Records";
                lbMedicalID.Text = MedicalRecord.ID.ToString();
            }
            else
            {
                MessageBox.Show("Failed to add the medical record.", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void UpdateMedicalRecord()
        {
            if(!int.TryParse(lbMedicalID.Text.ToString(), out int ID))
                {
                return;
            }

             MedicalRecord = clsMedicalRecord.FindMedicalRecord(ID);

            if(MedicalRecord == null)
            {
                MessageBox.Show("Medical record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MedicalRecord.VisitDescription = txbVisitDescription.Text;
            MedicalRecord.Diagnosis = txbDiagnosis.Text;

            if (string.IsNullOrWhiteSpace(txbAdditionalNotes.Text))
            {
                MedicalRecord.AdditionalNotes = null;
            }
            else
            {
                MedicalRecord.AdditionalNotes = txbAdditionalNotes.Text;

            }

            if (MedicalRecord.Save())
            {
                MessageBox.Show("Medical record Updated successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                
            }
            else
            {
                MessageBox.Show("Failed to update the medical record.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
                return;

            if (ClinicMainForm.Mode == ClinicMainForm.enMode.enAdd)
            {
                AddNewMedicalRecord();
            }
            else if (ClinicMainForm.Mode == ClinicMainForm.enMode.enUpdate)
            {
                UpdateMedicalRecord();
            }
        }
        void FillFormWithData()
        {
            if (MedicalRecord == null)
                return;

            lbMedicalID.Text = MedicalRecord.ID.ToString();
            txbVisitDescription.Text = MedicalRecord.VisitDescription;
            txbDiagnosis.Text = MedicalRecord.Diagnosis;
            txbAdditionalNotes.Text = MedicalRecord.AdditionalNotes;

        }
        private void AddMedicalRecordsFrm_Load(object sender, EventArgs e)
        {
            

            if (ClinicMainForm.Mode == ClinicMainForm.enMode.enAdd)
            {
                lbTitle.Text = "Add New M.Record";
            }
            else if (ClinicMainForm.Mode == ClinicMainForm.enMode.enUpdate)
            {
                lbTitle.Text = "Update M.Record";
                FillFormWithData();
            }
        }
    }
}
