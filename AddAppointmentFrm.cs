using ClinicDoctorsBusinessLayer;
using ClinicPatientBusinessLayer;
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
using ClinicPaymentBusinessLayer;
using ClinicAppointmentBusinessLayer;
using System.Windows.Controls;
//using System.Windows.Controls;

namespace ClinicSystemFormProject
{
    public partial class AddAppointmentFrm : Form
    {
        public AddAppointmentFrm()
        {
            InitializeComponent();
            TbPatients = clsPatient.GetAllPatientsData();
            TbDoctors = clsDoctor.GetAllDoctorsData();
            TbMedicalRecord = clsMedicalRecord.GetAllMedicalRecords();
            TbPayment = clsPayment.GetAllPayment();
        }
        public AddAppointmentFrm(clsAppointment Appointment)
        {
            InitializeComponent();
            TbPatients = clsPatient.GetAllPatientsData();
            TbDoctors = clsDoctor.GetAllDoctorsData();
            TbMedicalRecord = clsMedicalRecord.GetAllMedicalRecords();
            TbPayment = clsPayment.GetAllPayment();
            lbTitle.Text = "Update Appointment";
            btnCancel.Text = "Cancel";
             appointment = Appointment;
        }
        clsAppointment appointment = new clsAppointment();
        DataTable TbPatients = new DataTable();
        DataTable TbDoctors = new DataTable();
        DataTable TbMedicalRecord = new DataTable();
        DataTable TbPayment = new DataTable();

        bool IsLoading = false;
        enum enAppointmentStatus { Pending = 0, Confirmed = 1, Completed = 2, Canceled = 3, Reschedule = 4, NoShow = 5 }
        enAppointmentStatus Status = enAppointmentStatus.Pending;
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

        void FillPatientCombo()
        {
            //it store item as dataRowView
            cmbPatientID.DataSource = TbPatients;
            cmbPatientID.DisplayMember = "PatientID";
            cmbPatientID.ValueMember = "PatientID";
            cmbPatientID.SelectedValue = -1;
            cmbPatientID.Text = "Select";
        }
        void FillDoctorCombo()
        {
            cmbDoctorID.DataSource = TbDoctors;
            cmbDoctorID.DisplayMember = "DoctorID";
            cmbDoctorID.ValueMember = "DoctorID";
            cmbDoctorID.SelectedValue = -1;
            cmbDoctorID.Text = "Select";
        }
        void FillMedicalRecordCombo()
        {
            cmbMedicalRecord.DataSource = TbMedicalRecord;
            cmbMedicalRecord.DisplayMember = "MedicalRecordID";
            cmbMedicalRecord.ValueMember = "MedicalRecordID";
            cmbMedicalRecord.SelectedValue = -1;
            cmbMedicalRecord.Text = "Select";
        }
        void FillPaymentCombo()
        {
            cmbPayment.DataSource = TbPayment;
            cmbPayment.DisplayMember = "PaymentID";
            cmbPayment.ValueMember = "PaymentID";
            cmbPayment.SelectedValue = -1;
            cmbPayment.Text = "Select";
        }
        private void AddAppointmentFrm_Load(object sender, EventArgs e)
        {
            IsLoading = true;
            
            FillPatientCombo();
            FillDoctorCombo();
            FillMedicalRecordCombo();
            FillPaymentCombo();
            IsLoading = false;
            //foreach (DataRow row in TbPatients.Rows)
            //{
            //    cmbPatientID.Items.Add(row["PatientID"]);
            //}



            if (ClinicMainForm.Mode == ClinicMainForm.enMode.enAdd)
            {
                
            }
            if (ClinicMainForm.Mode == ClinicMainForm.enMode.enUpdate)
            {
                
                cmbPatientID.SelectedValue = appointment.PatientID;
                cmbDoctorID.SelectedValue = appointment.DoctorID;
                dtpAppointmentDateTime.Value = appointment.DateTime;
                cmbStatus.SelectedItem = appointment.Status.Trim();

                if(appointment.MedicalRecordID != null)
                {
                    cmbMedicalRecord.SelectedValue = appointment.MedicalRecordID;
                }
                if (appointment.PaymentID != null)
                {
                    cmbPayment.SelectedValue = appointment.PaymentID;
                }

                cmbPatientID_SelectedIndexChanged(cmbPatientID, EventArgs.Empty);
                cmbDoctorID_SelectedIndexChanged(cmbDoctorID, EventArgs.Empty);

                if (cmbMedicalRecord.SelectedValue != null) //i do this because it's allow null in database
                    cmbMedicalRecord_SelectedIndexChanged(cmbMedicalRecord, EventArgs.Empty);

                if (cmbPayment.SelectedValue != null) //i do this because it's allow null in database
                    cmbPayment_SelectedIndexChanged(cmbPayment, EventArgs.Empty);
            }
            
            
            
            
        }
        //this is get row of what i select in Patient combo then return it to method who fill patient control screen to show data
        DataRow GetPatientRowData()
        {
            
            foreach (DataRow row in TbPatients.Rows)
            {
                if (row["PatientID"].ToString() == cmbPatientID.SelectedValue.ToString())
                {
                    return row;
                }
            }
            return null;
        }
        DataRow GetDoctorRowData()
        {
            foreach (DataRow row in TbDoctors.Rows)
            {
                if (row["DoctorID"].ToString() == cmbDoctorID.SelectedValue.ToString())
                {
                    return row;
                }
            }
            return null;
        }
        DataRow GetMedicalRecordData()
        {
            foreach (DataRow row in TbMedicalRecord.Rows)
            {
                if (row["MedicalRecordID"].ToString() == cmbMedicalRecord.SelectedValue.ToString())
                {
                    return row;
                }
            }
            return null;
        }
        DataRow GetPaymentData()
        {
            foreach (DataRow row in TbPayment.Rows)
            {
                if (row["PaymentID"].ToString() == cmbPayment.SelectedValue.ToString())
                {
                    return row;
                }
            }
            return null;
        }

        //This For Check If User Enter Necessary Data Or Not
        bool ValidateData()
        {
            if (cmbPatientID.SelectedItem == null)
            {
                MessageBox.Show("Please select a patient ID before proceeding.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (cmbDoctorID.SelectedItem == null)
            {
                MessageBox.Show("Please select a doctor ID before proceeding.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status before proceeding.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            return true;
        }
        //this is fill patient control who show data
        private void cmbPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsLoading) //this called flag
                return;
            //int.TryParse(cmbPatientID.SelectedItem.ToString(), out int PatientID);
            DataRow row = GetPatientRowData();

            lbNamePatient.Text = row["Name"].ToString();
            lbGenderPatient.Text = row["Gender"].ToString();
            lbPhonePatient.Text = row["PhoneNumber"].ToString();
        }

        private void cmbDoctorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsLoading)
                return;
            //int.TryParse(cmbDoctorID.SelectedItem.ToString(), out int DoctorID);
            DataRow row = GetDoctorRowData();

            lbNameDoctor.Text = row["Name"].ToString();
            lbGenderDoctor.Text = row["Gender"].ToString();
            lbPhoneDoctor.Text = row["PhoneNumber"].ToString();
            lbSpecDoctor.Text = row["Specialization"].ToString();
        }

        

        private void cmbMedicalRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsLoading)
                return;
            
            DataRow row = GetMedicalRecordData();

            


            //lbDiagnosisMeRecord.Text = row["Diagnosis"].ToString();
            rtbDiagnosis.Text = row["Diagnosis"].ToString();
           

            rtbNotes.Text = row["AdditionalNotes"].ToString();
            

            rtbDescription.Text = row["VisitDescription"].ToString();
            

        }

        private void cmbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsLoading)
                return;
            DataRow row = GetPaymentData();

            lbMethodPayment.Text = row["PaymentMethod"].ToString();
            lbAmountPayment.Text = row["AmountPaid"].ToString();
            lbDatePayment.Text = row["PaymentDate"].ToString();

        }

        void AddNewAppointment()
        {
            clsAppointment appointment = new clsAppointment();

            int.TryParse(cmbPatientID.SelectedValue.ToString(), out int PatientID);
            int.TryParse(cmbDoctorID.SelectedValue.ToString(), out int DoctorID);

            appointment.PatientID = PatientID;
            appointment.DoctorID = DoctorID;

            if (DateTime.TryParse(dtpAppointmentDateTime.Value.ToString(), out DateTime date))
            {
                appointment.DateTime = date;
            }
            else
            {
                MessageBox.Show("Please select a valid date before proceeding.", "Date Not Set", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            appointment.Status = cmbStatus.SelectedItem.ToString(); //Selected value

            if (cmbMedicalRecord.SelectedValue != null)
            {
                int.TryParse(cmbMedicalRecord.SelectedValue.ToString(), out int MRecordID);
                appointment.MedicalRecordID = MRecordID;
            }
            else
            {
                appointment.MedicalRecordID = null;
            }

            if (cmbPayment.SelectedValue != null)
            {
                int.TryParse(cmbPayment.SelectedValue.ToString(), out int PaymentID);
                appointment.PaymentID = PaymentID;
            }
            else
            {
                appointment.PaymentID = null;
            }

            if (appointment.Save())
            {
                MessageBox.Show("The item was added successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbAppointmentID.Text = appointment.ID.ToString();
                ClinicMainForm.Mode = ClinicMainForm.enMode.enUpdate;
                lbTitle.Text = "Update Appointment";
            }
            else
            {
                MessageBox.Show("The item was not added.", "Action Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
        void UpdateAppointment()
        {
            
            int.TryParse(lbAppointmentID.Text.ToString(), out int AppointmentID);
            appointment = clsAppointment.FindAppointment(AppointmentID);

            if (appointment == null)
            {
                MessageBox.Show("The record has been not Found.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int.TryParse(cmbPatientID.SelectedValue.ToString(), out int PatientID);
            int.TryParse(cmbDoctorID.SelectedValue.ToString(), out int DoctorID);



            appointment.PatientID = PatientID;
            appointment.DoctorID = DoctorID;

            if (DateTime.TryParse(dtpAppointmentDateTime.Value.ToString(), out DateTime date))
            {
                appointment.DateTime = date;
            }
            else
            {
                MessageBox.Show("Please select a valid date before proceeding.", "Date Not Set", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            appointment.Status = cmbStatus.SelectedItem.ToString(); //Selected value

            if (cmbMedicalRecord.SelectedValue != null)
            {
                int.TryParse(cmbMedicalRecord.SelectedValue.ToString(), out int MRecordID);
                appointment.MedicalRecordID = MRecordID;
            }
            else
            {
                appointment.MedicalRecordID = null;
            }

            if (cmbPayment.SelectedValue != null)
            {
                int.TryParse(cmbPayment.SelectedValue.ToString(), out int PaymentID);
                appointment.PaymentID = PaymentID;
            }
            else
            {
                appointment.PaymentID = null;
            }

            if (appointment.Save())
            {
                MessageBox.Show("The record has been updated successfully.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("The record has been not updated.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
                return;

            if (ClinicMainForm.Mode == ClinicMainForm.enMode.enAdd)
            {
                AddNewAppointment();
            }
            else if (ClinicMainForm.Mode == ClinicMainForm.enMode.enUpdate)
            {
                UpdateAppointment();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowMedRecords_Click(object sender, EventArgs e)
        {
            Form frm = new ShowMedicalRecordsFrm();
            frm.ShowDialog();

        }

        private void btnShowPrescriptions_Click(object sender, EventArgs e)
        {
            Form frm = new ShowPrescriptionsFrm();
            frm.ShowDialog();
        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
