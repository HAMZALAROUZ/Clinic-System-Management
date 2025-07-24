
using ClinicUsersBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows;
using System.Windows.Forms;



namespace ClinicSystemFormProject
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();

           
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                mtxbPassword.PasswordChar = '\0' ;
            }
            else
            {
                mtxbPassword.PasswordChar = '*';
            }

        }
        bool ValidateInsertedData()
        {
            
            if (string.IsNullOrWhiteSpace(txbUsername.Text))
            {
                MessageBox.Show("Please enter a Username.", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(string.IsNullOrWhiteSpace(mtxbPassword.Text))
            {
                MessageBox.Show("Please enter a Password.", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateInsertedData()) 
                return ;

            

            clsUser User = clsUser.FindUserByUserName(txbUsername.Text);
           
            if (User == null || User.Password != mtxbPassword.Text)
            {
                MessageBox.Show("The username or password you entered is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            
            Form frm = new ClinicMainForm(User);
            frm.ShowDialog();

            
            mtxbPassword.Text = string.Empty;

        }
    }
}
