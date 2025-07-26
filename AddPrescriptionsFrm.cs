using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicMedicalRecordBusinessLayer;
using ClinicPrescriptionBusinessLayer;

namespace ClinicSystemFormProject
{
    public partial class AddPrescriptionsFrm : Form
    {
        public AddPrescriptionsFrm()
        {
            InitializeComponent();
            TbMedicalRecord = clsMedicalRecord.GetAllMedicalRecords();
        }
        public AddPrescriptionsFrm(clsPrescription _Prescription)
        {
            InitializeComponent();
            TbMedicalRecord = clsMedicalRecord.GetAllMedicalRecords();
            Prescription = _Prescription;
        }
        clsPrescription Prescription = new clsPrescription();
        DataTable TbMedicalRecord = new DataTable();


        void FillMedicalRecordCombo()
        {
            cmbMedicalID.DataSource = TbMedicalRecord;
            cmbMedicalID.DisplayMember = "MedicalRecordID";
            cmbMedicalID.ValueMember = "MedicalRecordID";
            cmbMedicalID.SelectedValue = -1;
            cmbMedicalID.Text = "Select";
        }


        private void AddPrescriptionsFrm_Load(object sender, EventArgs e)
        {
            if(ClinicMainForm.Mode == ClinicMainForm.enMode.enAdd)
            {
                lbTitle.Text = "Add New Prescription";
                lbPrescriptionID.Text = "-";
            }

            FillMedicalRecordCombo();

            if(ClinicMainForm.Mode == ClinicMainForm.enMode.enUpdate)
            {
                    lbTitle.Text = "Update Prescription";
                    lbPrescriptionID.Text = Prescription.ID.ToString();
                    cmbMedicalID.SelectedValue = Prescription.MedicalRecordID;
                    txbDosage.Text = Prescription.Dosage;
                    txbFrequency.Text = Prescription.Frequency;
                    txbMedicationName.Text = Prescription.MedicationName;
                    txbSpecialInstructions.Text = Prescription.SpecialInstructions;
                    dtmStartDate.Value = Prescription.StartDate;
                    dtmEndDate.Value = Prescription.EndDate;                
                    
            }
        }

        private void cmbMedicalID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbPrescriptionID_Click(object sender, EventArgs e)
        {

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
        bool ValidateData()
        {
            if (string.IsNullOrEmpty(txbMedicationName.Text))
            {
                MessageBox.Show("Please enter Medication Name before continuing.", "Missing Input",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txbDosage.Text))
            {
                MessageBox.Show("Please enter Dosage before continuing.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txbFrequency.Text))
            {
                MessageBox.Show("Please enter Frequency before continuing.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txbSpecialInstructions.Text))
            {
                MessageBox.Show("Please enter Special Instructions before continuing.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbMedicalID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select M.ID before continuing.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
            
        }
        bool SavePrescriptions()
        {
            if (!ValidateData())
                return false;

            Prescription.MedicationName = txbMedicationName.Text;
            Prescription.Dosage = txbDosage.Text;
            Prescription.StartDate = dtmStartDate.Value;
            Prescription.EndDate = dtmEndDate.Value;
            Prescription.Frequency = txbFrequency.Text;
            if(int.TryParse(cmbMedicalID.SelectedValue.ToString(), out int MRecordID))
            Prescription.MedicalRecordID = MRecordID;
            Prescription.SpecialInstructions = txbSpecialInstructions.Text;

            if(Prescription.Save())
            {
                MessageBox.Show("Record saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {

                MessageBox.Show("Record Not saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ClinicMainForm.Mode == ClinicMainForm.enMode.enAdd)
            {
                if(SavePrescriptions())
                {
                    
                    lbPrescriptionID.Text = Prescription.ID.ToString();
                    lbTitle.Text = "Update Prescription";
                    ClinicMainForm.Mode = ClinicMainForm.enMode.enUpdate;
                }
                
            }
            else
            {
                SavePrescriptions();
            }
            //else
            //{
            //    if (SavePrescriptions())
            //    {
            //        MessageBox.Show("prescription Updated successfuly.", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("prescription Update failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }

            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
