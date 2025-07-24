using ClinicUsersBusinessLayer;
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
    public partial class AddUserFrm : Form
    {
        public AddUserFrm()
        {
            InitializeComponent();
        }
        public AddUserFrm(clsUser _User)
        {
            InitializeComponent();
            lbTitle.Text = "Update User";
            //btnClear.Text = "Cancel";
            //btnAdd.Text = "Update";
            User = _User;
        }
        clsUser User = new clsUser();
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

       
        bool IsProgramaticChange = false;
        private void chbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (IsProgramaticChange) return;

            IsProgramaticChange=true;

            bool Check = chbAll.Checked;

            foreach(Control control in gbPermissions.Controls)
            {
                if(control is CheckBox cb && cb != chbAll)
                {
                    cb.Checked=Check;
                }
            }
            IsProgramaticChange = false;

        }
        private void IndividualCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsProgramaticChange) return;

            IsProgramaticChange = true;

            bool AllChecked = true;


            foreach (Control control in gbPermissions.Controls)
            {
                if (control is CheckBox cb && cb != chbAll)
                {
                    if (!cb.Checked)
                    {
                        AllChecked = false;
                        break;
                    }
                }
            }
            chbAll.Checked=AllChecked;
            IsProgramaticChange = false;
        }
       

        bool ValidateData()
        {
            if(txbName.Text == string.Empty)
            {
                ShowError("Set Name");
                
                return false;
            }

            if (txbUserName.Text == string.Empty)
            {
                ShowError("Set UserName");
                
                return false;
            }

            if (txbPassword.Text == string.Empty)
            {
                ShowError("Set Password");
                
                return false;
            }

            return true;
        }
        void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        int GetPermission()
        {
            int Permission = 0;
            if(chbAll.Checked)
            {
                Permission = -1;
                return Permission;
            }
            if (chbPatients.Checked)
                Permission |= (int)ClinicMainForm.enPermissions.enPatient;
            if(chbDoctors.Checked)
                Permission |= (int)ClinicMainForm.enPermissions.enDoctor;
            if (chbAppointments.Checked)
                Permission |= (int)ClinicMainForm.enPermissions.enAppointment;
            if (chbUsers.Checked)
                Permission |= (int)ClinicMainForm.enPermissions.enUser;
            if (chbPayments.Checked)
                Permission |= (int)ClinicMainForm.enPermissions.enPayment;

            return Permission;
        }

        void AddNewUser()
        {
            User.Permission = GetPermission();
            User.Name = txbName.Text;
            User.UserName = txbUserName.Text;
            User.Password = txbPassword.Text;
            if (User.Save())
            {
                MessageBox.Show("Added", "Result", MessageBoxButtons.OK);
                ClinicMainForm.Mode = ClinicMainForm.enMode.enUpdate;
                lbID.Text = User.ID.ToString();
                lbTitle.Text = "Update User";
            }
            else
            {
                MessageBox.Show("Not Added", "Result", MessageBoxButtons.OK);

            }
        }

        void UpdateUser()
        {
            User.Permission = GetPermission();
            User.Name = txbName.Text;
            User.UserName = txbUserName.Text;
            User.Password = txbPassword.Text;

            if (User.Save())
            {
                MessageBox.Show("Updated", "Result", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Not Updated", "Result", MessageBoxButtons.OK);

            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
                return;

            
            if (ClinicMainForm.Mode == ClinicMainForm.enMode.enAdd)
            {
                AddNewUser();
            }
            else if (ClinicMainForm.Mode == ClinicMainForm.enMode.enUpdate)
            {
                UpdateUser();
            }
        }

       

        private void AddUserFrm_Load(object sender, EventArgs e)
        {
            if(ClinicMainForm.Mode == ClinicMainForm.enMode.enAdd)
            {

            }
            else if(ClinicMainForm.Mode == ClinicMainForm.enMode.enUpdate)
            {
                txbName.Text = User.Name;
                txbUserName.Text = User.UserName;
                txbPassword.Text = User.Password;
                lbID.Text = User.ID.ToString();

                if(User.Permission==-1)
                    chbAll.Checked = true;

                if((User.Permission & (int)ClinicMainForm.enPermissions.enPatient) == (int)ClinicMainForm.enPermissions.enPatient)
                {
                    chbPatients.Checked =true;
                }
                if ((User.Permission & (int)ClinicMainForm.enPermissions.enDoctor) == (int)ClinicMainForm.enPermissions.enDoctor)
                {
                    chbDoctors.Checked = true;
                }
                if ((User.Permission & (int)ClinicMainForm.enPermissions.enUser) == (int)ClinicMainForm.enPermissions.enUser)
                {
                    chbUsers.Checked = true;
                }
                if ((User.Permission & (int)ClinicMainForm.enPermissions.enAppointment) == (int)ClinicMainForm.enPermissions.enAppointment)
                {
                    chbAppointments.Checked = true;
                }
                if ((User.Permission & (int)ClinicMainForm.enPermissions.enPayment) == (int)ClinicMainForm.enPermissions.enPayment)
                {
                    chbPayments.Checked = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
                return;


            if (ClinicMainForm.Mode == ClinicMainForm.enMode.enAdd)
            {
                AddNewUser();
            }
            else if (ClinicMainForm.Mode == ClinicMainForm.enMode.enUpdate)
            {
                UpdateUser();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
