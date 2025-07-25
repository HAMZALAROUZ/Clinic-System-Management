using ClinicAppointmentBusinessLayer;
using ClinicPaymentBusinessLayer;
using ClinicPersonBusinessLayer;
using ClinicUsersBusinessLayer;
using ClinicPatientBusinessLayer;
using ClinicDoctorsBusinessLayer;
using System;
using System.Data;
using System.Drawing;

//using System.Windows;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ClinicSystemFormProject
{
    public partial class ClinicMainForm : Form
    {
        public ClinicMainForm(clsUser CurrentUser1 = null)
        {
            InitializeComponent();
            CurrentUser = CurrentUser1;
        }
        
        public clsUser CurrentUser;
        DataTable Table = new DataTable();
        public enum enMode { enUpdate = 0,enAdd= 1 }    
        public static enMode Mode = enMode.enUpdate;
        public enum enSections { enDashboard = 0,enPatient = 1,enDoctor = 2,enAppointment = 3,enUser = 4,enPayment = 5 };
        public enSections Section = enSections.enDashboard;
        public enum enPermissions { enPatient = 1,enDoctor = 2,enAppointment = 4,enUser = 8,enPayment = 16 };
        enPermissions Permissions ;
        private void ResizeDGVWidth(DataGridView dgv)
        {
            
            int TotalWidth = 0;

            foreach (DataGridViewColumn Column in dgv.Columns)
            {
                TotalWidth += Column.Width;
            }
            dgv.Width = TotalWidth + dgv.RowHeadersWidth + 2;
            
        }
        private bool LoadData()
        {
            
            
            switch (Section)
            {
                case enSections.enDashboard:
                    //code
                    break;
                case enSections.enPatient:                    
                    Table = clsPatient.GetAllPatientsData();
                    if (Table == null)
                        return false;
                    dgvPatients.DataSource = Table;
                    dgvPatients.Columns["DateOfBirth"].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dgvPatients.Columns["DateOfBirth"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvPatients.Columns["DateOfBirth"].DefaultCellStyle.ForeColor = Color.Blue;                   
                    break;
                case enSections.enDoctor:                    
                    Table = clsDoctor.GetAllDoctorsData();
                    if (Table == null)
                        return false;
                    dgvDoctors.DataSource = Table;                   
                    break;
                case enSections.enAppointment:                    
                    Table = clsAppointment.GetAllAppointments();
                    if (Table == null)
                        return false;
                    dgvAppointments.DataSource = Table;
                    dgvAppointments.Columns["AppointmentDateTime"].DefaultCellStyle.Format = "MM/dd/yyyy";                    
                    break;
                case enSections.enUser:                    
                    Table = clsUser.GetAllUsersData();
                    if (Table == null)
                        return false;
                    dgvUsers.DataSource = Table;                   
                    break;
                case enSections.enPayment:                   
                    Table = clsPayment.GetAllPayment();
                    if (Table == null)
                        return false;
                    dgvPayments.DataSource = Table;                   
                    break;

            }
            return true;
           
        }
        void AddImageColumn(DataGridView DGV)
        {
            DataGridViewImageColumn UpdateImage = new DataGridViewImageColumn();
            DataGridViewImageColumn DeleteImage = new DataGridViewImageColumn();
            UpdateImage.Name = "UP";
            DeleteImage.Name = "DE";

            UpdateImage.HeaderText = "";
            DeleteImage.HeaderText = "";

            UpdateImage.Image = Properties.Resources.icons8_edit_32;
            DeleteImage.Image = Properties.Resources.icons8_trash_32;
            DGV.Columns.Add(UpdateImage);
            DGV.Columns.Add(DeleteImage);
        }
        private bool HasPermission(clsUser User,enPermissions Permission)
        {
            if (User.Permission == -1)
                return true;
            enPermissions UserPermission =(enPermissions)User.Permission;
            if(UserPermission.HasFlag(Permission))
                return true;
            return false;
        }
        private void BtnPatients_Click(object sender, EventArgs e)
        {
            if(!HasPermission(CurrentUser,enPermissions.enPatient))
            {
                AccessDeniedMessage();
                return;
            }

            if (Section == enSections.enPatient)
                return;

            pnDashboard.Visible = false;
            pnUsers.Visible = false;
            pnAppointments.Visible = false;
            pnDoctors.Visible = false;
            pnPayments.Visible = false;
            pnPatients.Visible = true;
            
            Section = enSections.enPatient;
            LbTitle.Text = "Patients";

            if (LoadData())
            {
                if (!dgvPatients.Columns.Contains("UP") && !dgvPatients.Columns.Contains("DE"))
                    AddImageColumn(dgvPatients);
                ResizeDGVWidth(dgvPatients);

                dgvPatients.Top = (pnMain.Height - dgvPatients.Height) / 2;
                dgvPatients.Left = (pnMain.Width - dgvPatients.Width) / 2;
            }
            


        }
        
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            if (Section == enSections.enDashboard)
                return;
            
            pnDashboard.Visible = true;
            pnUsers.Visible = false;
            pnAppointments.Visible = false;
            pnDoctors.Visible = false;
            pnPayments.Visible = false;
            pnPatients.Visible = false;

            Section = enSections.enDashboard;
            LbTitle.Text = "Dashboard";
            LoadData();
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

        private void BtnDoctors_Click(object sender, EventArgs e)
        {
            if (!HasPermission(CurrentUser, enPermissions.enDoctor))
            {
                AccessDeniedMessage();
                return;
            }

            if (Section == enSections.enDoctor)
                return;


            pnDashboard.Visible = false;
            pnUsers.Visible = false;
            pnAppointments.Visible = false;
            pnDoctors.Visible = true;
            pnPayments.Visible = false;
            pnPatients.Visible = false;
            
            

            Section = enSections.enDoctor;
            LbTitle.Text = "Doctors";
            
            if(LoadData())
            {
                if (!dgvDoctors.Columns.Contains("UP") && !dgvDoctors.Columns.Contains("DE"))
                    AddImageColumn(dgvDoctors);
                ResizeDGVWidth(dgvDoctors);

                dgvDoctors.Top = (pnMain.Height - dgvDoctors.Height) / 2;
                dgvDoctors.Left = (pnMain.Width - dgvDoctors.Width) / 2;
            }
        }

        private void BtnAppointments_Click(object sender, EventArgs e)
        {
            if (!HasPermission(CurrentUser, enPermissions.enAppointment))
            {
                AccessDeniedMessage();
                return;
            }
            if (Section == enSections.enAppointment)
                return;

            pnDashboard.Visible = false;
            pnUsers.Visible = false;
            pnAppointments.Visible = true;
            pnDoctors.Visible = false;
            pnPayments.Visible = false;
            pnPatients.Visible = false;
            
           
            Section = enSections.enAppointment;
            LbTitle.Text = "Appointments";

            if (LoadData())
            {
                if(!dgvAppointments.Columns.Contains("UP") && !dgvAppointments.Columns.Contains("DE"))
                AddImageColumn(dgvAppointments);
                ResizeDGVWidth(dgvAppointments);

                dgvAppointments.Top = (pnMain.Height - dgvAppointments.Height) / 2;
                dgvAppointments.Left = (pnMain.Width - dgvAppointments.Width) / 2;               
            }
        }
        void AccessDeniedMessage()
        {
            MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private void BtnUsers_Click(object sender, EventArgs e)
        {
            if (!HasPermission(CurrentUser, enPermissions.enUser))
            {
                AccessDeniedMessage();
                return;
            }

            if (Section == enSections.enUser)
                return;

            pnDashboard.Visible = false;
            pnUsers.Visible = true;
            pnAppointments.Visible = false;
            pnDoctors.Visible = false;
            pnPayments.Visible = false;
            pnPatients.Visible = false;


            Section = enSections.enUser;
            LbTitle.Text = "Users";

            if (LoadData())
            {
                if (!(dgvUsers.Columns.Contains("UP") && dgvUsers.Columns.Contains("DE")))
                    AddImageColumn(dgvUsers);
                ResizeDGVWidth(dgvUsers);

                dgvUsers.Top = (pnMain.Height - dgvUsers.Height) / 2;
                dgvUsers.Left = (pnMain.Width - dgvUsers.Width) / 2;
            }

        }

        private void BtnPayments_Click(object sender, EventArgs e)
        {
            
            if (!HasPermission(CurrentUser, enPermissions.enPayment))
            {
                AccessDeniedMessage();
                return;
            }

            //This is Prevent for not loading data again 
            if (Section == enSections.enPayment)
                return;

            pnDashboard.Visible = false;
            pnUsers.Visible = false;
            pnAppointments.Visible = false;
            pnDoctors.Visible = false;
            pnPayments.Visible = true;
            pnPatients.Visible = false;


            Section = enSections.enPayment;
            LbTitle.Text = "Payments";
            
            if (LoadData())
            {
                //and this is for not add images that dgvpayment has alreday
                if(!(dgvPayments.Columns.Contains("UP") && dgvPayments.Columns.Contains("DE")))
                AddImageColumn(dgvPayments);

                ResizeDGVWidth(dgvPayments);

                dgvPayments.Top  = (pnMain.Height - dgvPayments.Height) / 2;
                dgvPayments.Left = (pnMain.Width - dgvPayments.Width) / 2;
            }


        }

        

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int PatientID = -1;
            clsPatient Patient = new clsPatient();

            if (dgvPatients.Columns[e.ColumnIndex].Name == "UP")
            {
                
                DataGridViewRow Row = dgvPatients.Rows[e.RowIndex];
                
                if(!(int.TryParse(Row.Cells["PatientID"].Value.ToString(), out PatientID) ))
                {
                    return;
                }
                
                
                

                Patient = clsPatient.FindPatient(PatientID);
                

                if (Patient == null)
                {
                    MessageBox.Show($"We couldn't find a patient with ID [{PatientID}]. Please check the ID and try again.", "Patient Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    ClinicMainForm.Mode = enMode.enUpdate;
                    Form frm = new FrmAddPatient(Patient);
                    frm.ShowDialog();
                    RefreshPatientList();
                }

                

               
            }
            if(dgvPatients.Columns[e.ColumnIndex].Name == "DE")
            {
               
                DataGridViewRow Row = dgvPatients.Rows[e.RowIndex];

                if (!(int.TryParse(Row.Cells["PatientID"].Value.ToString(), out PatientID)))
                {
                    return;
                }
                if(clsPatient.IsPatientHasAppointments(PatientID))
                {
                    if(MessageBox.Show("All appointments related to this patient will be deleted. Do you want to continue?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                if(MessageBox.Show("Are You Sure You Want To Delete \'" + Row.Cells["Name"].Value.ToString() + "\'?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(clsPatient.DeletePatient(PatientID))
                    {
                        MessageBox.Show("The record was deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshPatientList();
                    }
                    else
                    {
                        MessageBox.Show("The record could not be deleted.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int DoctorID = -1;
            
            if (dgvDoctors.Columns[e.ColumnIndex].Name == "UP")
            {
                
                DataGridViewRow Row = dgvDoctors.Rows[e.RowIndex];

                if (!(int.TryParse(Row.Cells["DoctorID"].Value.ToString(), out DoctorID)))
                {
                    return;
                }


                

                clsDoctor Doctor = clsDoctor.FindDoctor(DoctorID);
                

                if (Doctor == null)
                {
                    MessageBox.Show($"Doctor ID [{DoctorID}] was not found in the system.", "Doctor Not Found",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    ClinicMainForm.Mode = enMode.enUpdate;
                    Form frm = new AddDoctorFrm(Doctor);
                    frm.ShowDialog();
                    RefreshDoctorList();
                }

                


            }
            if (dgvDoctors.Columns[e.ColumnIndex].Name == "DE")
            {
                
                DataGridViewRow Row = dgvDoctors.Rows[e.RowIndex];

                if (!(int.TryParse(Row.Cells["DoctorID"].Value.ToString(), out DoctorID)))
                {
                    return;
                }

                if (clsDoctor.IsDoctorHasAppointments(DoctorID))
                {
                    if (MessageBox.Show("All appointments related to this doctor will be deleted. Do you want to continue?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                
                if (MessageBox.Show("Are You Sure You Want To Delete \'" + Row.Cells["Name"].Value.ToString() + "\'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsDoctor.DeleteDoctor(DoctorID))
                    {
                        MessageBox.Show("The record was deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        RefreshDoctorList();
                    }
                    else
                    {
                        MessageBox.Show("The record could not be deleted.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            
            
        }
        public void RefreshPatientList()
        {
            if (LoadData())
            {                
                ResizeDGVWidth(dgvPatients);

                dgvPatients.Top = (pnMain.Height - dgvPatients.Height) / 2;
                dgvPatients.Left = (pnMain.Width - dgvPatients.Width) / 2;
            }
        }
        private void btnPatientAdd_Click(object sender, EventArgs e)
        {
            Mode = enMode.enAdd;
            Form frm = new FrmAddPatient();
            frm.ShowDialog();
            RefreshPatientList();
        }

        void RefreshDoctorList()
        {
            if (LoadData())
            {
                
                ResizeDGVWidth(dgvDoctors);

                dgvDoctors.Top = (pnMain.Height - dgvDoctors.Height) / 2;
                dgvDoctors.Left = (pnMain.Width - dgvDoctors.Width) / 2;
            }
        }
        private void btnDoctorAdd_Click(object sender, EventArgs e)
        {
            Mode = enMode.enAdd;
            Form frm = new AddDoctorFrm();
            frm.ShowDialog();
            RefreshDoctorList();
        }
        void RefreshAppointmentList()
        {
            if (LoadData())
            {
                
                ResizeDGVWidth(dgvAppointments);

                dgvAppointments.Top = (pnMain.Height - dgvAppointments.Height) / 2;
                dgvAppointments.Left = (pnMain.Width - dgvAppointments.Width) / 2;
            }
        }
        private void btnAppointmentAdd_Click(object sender, EventArgs e)
        {
            if(clsPatient.IsTableEmpty() || clsDoctor.IsTableEmpty())
            {
                MessageBox.Show("Sorry There's No Any Patient or Doctor To Add An Appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Mode = enMode.enAdd;
            Form frm = new AddAppointmentFrm();
            frm.ShowDialog();
            RefreshAppointmentList();
        }
        void RefreshUserList()
        {
            if (LoadData())
            {                
                ResizeDGVWidth(dgvUsers);

                dgvUsers.Top = (pnMain.Height - dgvUsers.Height) / 2;
                dgvUsers.Left = (pnMain.Width - dgvUsers.Width) / 2;
            }
        }
        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int AppointmentID = -1;

            if (dgvAppointments.Columns[e.ColumnIndex].Name == "UP")
            {
                
                DataGridViewRow Row = dgvAppointments.Rows[e.RowIndex];

                if (!(int.TryParse(Row.Cells["AppointmentID"].Value.ToString(), out AppointmentID)))
                {
                    return;
                }

                clsAppointment Appointment = clsAppointment.FindAppointment(AppointmentID);

                if (Appointment == null)
                {
                    MessageBox.Show($"Appointment ID [{AppointmentID}] was not found.", "Appointment Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Mode = enMode.enUpdate; 
                    Form frm = new AddAppointmentFrm(Appointment);
                    frm.ShowDialog();
                    RefreshAppointmentList();
                }

            }
            if (dgvAppointments.Columns[e.ColumnIndex].Name == "DE")
            {
                

                DataGridViewRow Row = dgvAppointments.Rows[e.RowIndex];
                

                if (!(int.TryParse(Row.Cells["AppointmentID"].Value.ToString(), out AppointmentID)))
                {
                    return;
                }

                if (MessageBox.Show("Are You Sure You Want To Delete Appointment ID \'" + Row.Cells["AppointmentID"].Value.ToString() + "\'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsAppointment.IsAppointmentExists(AppointmentID))
                    {
                        if (clsAppointment.DeleteAppointment(AppointmentID))
                        {
                            MessageBox.Show("The record was deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshAppointmentList();
                        }
                        else
                        {

                            MessageBox.Show("The record could not be deleted.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }



                    }
                    else
                    {
                        MessageBox.Show("Sorry, the appointment was not found.", "Appointment Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            
                
            }
            
        }
        void RefreshPaymentList()
        {

            if (LoadData())
            {                
                ResizeDGVWidth(dgvPayments);

                dgvPayments.Top = (pnMain.Height - dgvPayments.Height) / 2;
                dgvPayments.Left = (pnMain.Width - dgvPayments.Width) / 2;
            }
        }

       
        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            Mode = enMode.enAdd;
           Form frm = new AddUserFrm();
            frm.ShowDialog();
            RefreshUserList();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers.Columns[e.ColumnIndex].Name == "UP")
            {
                DataGridViewRow Row = dgvUsers.Rows[e.RowIndex];

                if (!(int.TryParse(Row.Cells["UserID"].Value.ToString(), out int UserID)))
                {
                    return;
                }

                clsUser User = clsUser.FindUser(UserID);

                if(User!=null)
                {
                    Mode = enMode.enUpdate;
                    Form frm = new AddUserFrm(User);
                    frm.ShowDialog();
                    RefreshUserList();
                }
            }
            if (dgvUsers.Columns[e.ColumnIndex].Name == "DE")
            {
                DataGridViewRow Row = dgvUsers.Rows[e.RowIndex];

                if (!(int.TryParse(Row.Cells["UserID"].Value.ToString(), out int UserID)))
                {
                    return;
                }

                if (MessageBox.Show("Are You Sure You Want To Delete User ID \'" + Row.Cells["UserID"].Value.ToString() + "\'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsUser.DeleteUser(UserID))
                    {
                        MessageBox.Show("The record was deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshUserList();
                    }
                    else
                    {
                        MessageBox.Show("The record could not be deleted.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            Mode = enMode.enAdd;
            Form frm = new AddPaymentFrm();
            frm.ShowDialog();
            RefreshPaymentList();
        }

        private void dgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvPayments.Rows[e.RowIndex];
            
            if (dgvPayments.Columns[e.ColumnIndex].Name == "UP")
            {
                if (!int.TryParse(row.Cells["PaymentID"].Value.ToString(), out int ID))
                    return;

                clsPayment Payment = clsPayment.FindPayment(ID);

                Mode = enMode.enUpdate;
                Form frm = new AddPaymentFrm(Payment);
                frm.ShowDialog();
                RefreshPaymentList();
            }
            if (dgvPayments.Columns[e.ColumnIndex].Name == "DE")
            {
                if (!int.TryParse(row.Cells["PaymentID"].Value.ToString(), out int ID))
                    return;

                if (clsPayment.IsPaymentRelatedToAnyAppointment(ID))
                {
                    MessageBox.Show("Sorry You Can't Delete This Payment \'Related To An Appointment\'", "Result", MessageBoxButtons.OK)
                        ; return;
                }

                if (MessageBox.Show("Are You Sure You Want To Delete This Payment", "Confirme", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return;
                

                

                if(clsPayment.DeletePayment(ID))
                {
                    MessageBox.Show("The record was deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshPaymentList() ;
                }
                else
                {
                    MessageBox.Show("The record could not be deleted.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void txbPaymentSearch_TextChanged(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(txbPaymentSearch.Text) && int.TryParse(txbPaymentSearch.Text,out int ID))
            {                                
                if (Table == null)
                    return;
                
                Table.DefaultView.RowFilter = "PaymentID = " + ID;
                dgvPayments.DataSource = Table.DefaultView;
            }
            else if(string.IsNullOrWhiteSpace(txbPaymentSearch.Text))
            {
                Table.DefaultView.RowFilter = "";
                dgvPayments.DataSource = Table.DefaultView;
            }
        }

        private void txbUserSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbUserSearch.Text) && int.TryParse(txbUserSearch.Text, out int ID))
            {
                if (Table == null)
                    return;

                Table.DefaultView.RowFilter = "UserID = " + ID;
                dgvUsers.DataSource = Table.DefaultView;
            }
            else if(!(string.IsNullOrWhiteSpace(txbUserSearch.Text) && int.TryParse(txbUserSearch.Text, out int ID1)))
            {
                if (Table == null)
                    return;

                Table.DefaultView.RowFilter = $"UserName LIKE '{txbUserSearch.Text}%'"; ;
                dgvUsers.DataSource = Table.DefaultView;
            }
            else if (string.IsNullOrWhiteSpace(txbPaymentSearch.Text))
            {
                Table.DefaultView.RowFilter = "";
                dgvPayments.DataSource = Table.DefaultView;
            }
        }

        

        private void txbDoctorSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbDoctorSearch.Text) && int.TryParse(txbDoctorSearch.Text, out int ID))
            {
                if (Table == null)
                    return;

                Table.DefaultView.RowFilter = "DoctorID = " + ID;
                dgvDoctors.DataSource = Table.DefaultView;
            }
            else if (!(string.IsNullOrWhiteSpace(txbDoctorSearch.Text) && int.TryParse(txbDoctorSearch.Text, out int ID1)))
            {
                if (Table == null)
                    return;

                Table.DefaultView.RowFilter = $"Name LIKE '{txbDoctorSearch.Text}%'"; ;
                dgvDoctors.DataSource = Table.DefaultView;
            }
            else if (string.IsNullOrWhiteSpace(txbDoctorSearch.Text))
            {
                Table.DefaultView.RowFilter = "";
                dgvDoctors.DataSource = Table.DefaultView;
            }
        }

        private void txbPatientSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbPatientSearch.Text) && int.TryParse(txbPatientSearch.Text, out int ID))
            {
                if (Table == null)
                    return;

                Table.DefaultView.RowFilter = "PatientID = " + ID;
                dgvPatients.DataSource = Table.DefaultView;
            }
            else if (!(string.IsNullOrWhiteSpace(txbPatientSearch.Text) && int.TryParse(txbPatientSearch.Text, out int ID1)))
            {
                if (Table == null)
                    return;

                Table.DefaultView.RowFilter = $"Name LIKE '{txbPatientSearch.Text}%'"; ;
                dgvPatients.DataSource = Table.DefaultView;
            }
            else if (string.IsNullOrWhiteSpace(txbPatientSearch.Text))
            {
                Table.DefaultView.RowFilter = "";
                dgvPatients.DataSource = Table.DefaultView;
            }
        }

        private void txbAppointmentSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbAppointmentSearch.Text) && int.TryParse(txbAppointmentSearch.Text, out int ID))
            {
                if (Table == null)
                    return;

                Table.DefaultView.RowFilter = "AppointmentID = " + ID;
                dgvAppointments.DataSource = Table.DefaultView;
            }
            else if (string.IsNullOrWhiteSpace(txbAppointmentSearch.Text))
            {
                Table.DefaultView.RowFilter = "";
                dgvAppointments.DataSource = Table.DefaultView;
            }
        }

        
    }
    
}