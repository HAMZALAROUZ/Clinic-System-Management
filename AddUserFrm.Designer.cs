namespace ClinicSystemFormProject
{
    partial class AddUserFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPermissions = new System.Windows.Forms.GroupBox();
            this.chbAll = new System.Windows.Forms.CheckBox();
            this.chbPayments = new System.Windows.Forms.CheckBox();
            this.chbUsers = new System.Windows.Forms.CheckBox();
            this.chbAppointments = new System.Windows.Forms.CheckBox();
            this.chbDoctors = new System.Windows.Forms.CheckBox();
            this.chbPatients = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnMaximize = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbPermissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 51);
            this.panel1.TabIndex = 28;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(365, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(163, 29);
            this.lbTitle.TabIndex = 65;
            this.lbTitle.Text = "Add New User\r\n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Controls.Add(this.BtnMaximize);
            this.panel2.Controls.Add(this.BtnMinimize);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(848, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 51);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 26);
            this.label1.TabIndex = 33;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 35;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 26);
            this.label3.TabIndex = 37;
            this.label3.Text = "Password";
            // 
            // gbPermissions
            // 
            this.gbPermissions.Controls.Add(this.chbAll);
            this.gbPermissions.Controls.Add(this.chbPayments);
            this.gbPermissions.Controls.Add(this.chbUsers);
            this.gbPermissions.Controls.Add(this.chbAppointments);
            this.gbPermissions.Controls.Add(this.chbDoctors);
            this.gbPermissions.Controls.Add(this.chbPatients);
            this.gbPermissions.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPermissions.Location = new System.Drawing.Point(588, 137);
            this.gbPermissions.Name = "gbPermissions";
            this.gbPermissions.Size = new System.Drawing.Size(383, 296);
            this.gbPermissions.TabIndex = 39;
            this.gbPermissions.TabStop = false;
            this.gbPermissions.Text = "Permissions";
            // 
            // chbAll
            // 
            this.chbAll.AutoSize = true;
            this.chbAll.Location = new System.Drawing.Point(208, 128);
            this.chbAll.Name = "chbAll";
            this.chbAll.Size = new System.Drawing.Size(66, 33);
            this.chbAll.TabIndex = 7;
            this.chbAll.Text = "All";
            this.chbAll.UseVisualStyleBackColor = true;
            this.chbAll.CheckedChanged += new System.EventHandler(this.chbAll_CheckedChanged);
            // 
            // chbPayments
            // 
            this.chbPayments.AutoSize = true;
            this.chbPayments.Location = new System.Drawing.Point(208, 56);
            this.chbPayments.Name = "chbPayments";
            this.chbPayments.Size = new System.Drawing.Size(139, 33);
            this.chbPayments.TabIndex = 4;
            this.chbPayments.Text = "Payments";
            this.chbPayments.UseVisualStyleBackColor = true;
            this.chbPayments.CheckedChanged += new System.EventHandler(this.IndividualCheckbox_CheckedChanged);
            // 
            // chbUsers
            // 
            this.chbUsers.AutoSize = true;
            this.chbUsers.Location = new System.Drawing.Point(19, 226);
            this.chbUsers.Name = "chbUsers";
            this.chbUsers.Size = new System.Drawing.Size(93, 33);
            this.chbUsers.TabIndex = 3;
            this.chbUsers.Text = "Users";
            this.chbUsers.UseVisualStyleBackColor = true;
            this.chbUsers.CheckedChanged += new System.EventHandler(this.IndividualCheckbox_CheckedChanged);
            // 
            // chbAppointments
            // 
            this.chbAppointments.AutoSize = true;
            this.chbAppointments.Location = new System.Drawing.Point(19, 171);
            this.chbAppointments.Name = "chbAppointments";
            this.chbAppointments.Size = new System.Drawing.Size(183, 33);
            this.chbAppointments.TabIndex = 2;
            this.chbAppointments.Text = "Appointments";
            this.chbAppointments.UseVisualStyleBackColor = true;
            this.chbAppointments.CheckedChanged += new System.EventHandler(this.IndividualCheckbox_CheckedChanged);
            // 
            // chbDoctors
            // 
            this.chbDoctors.AutoSize = true;
            this.chbDoctors.Location = new System.Drawing.Point(19, 116);
            this.chbDoctors.Name = "chbDoctors";
            this.chbDoctors.Size = new System.Drawing.Size(117, 33);
            this.chbDoctors.TabIndex = 1;
            this.chbDoctors.Text = "Doctors";
            this.chbDoctors.UseVisualStyleBackColor = true;
            this.chbDoctors.CheckedChanged += new System.EventHandler(this.IndividualCheckbox_CheckedChanged);
            // 
            // chbPatients
            // 
            this.chbPatients.AutoSize = true;
            this.chbPatients.Location = new System.Drawing.Point(19, 56);
            this.chbPatients.Name = "chbPatients";
            this.chbPatients.Size = new System.Drawing.Size(126, 33);
            this.chbPatients.TabIndex = 0;
            this.chbPatients.Text = "Patients";
            this.chbPatients.UseVisualStyleBackColor = true;
            this.chbPatients.CheckedChanged += new System.EventHandler(this.IndividualCheckbox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 26);
            this.label4.TabIndex = 69;
            this.label4.Text = "ID";
            // 
            // lbID
            // 
            this.lbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(382, 80);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 26);
            this.lbID.TabIndex = 70;
            this.lbID.Text = "-";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.Control;
            this.BtnClose.Image = global::ClinicSystemFormProject.Properties.Resources.icons8_close_window_50;
            this.BtnClose.Location = new System.Drawing.Point(87, 8);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(34, 34);
            this.BtnClose.TabIndex = 73;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.BackColor = System.Drawing.SystemColors.Control;
            this.BtnMinimize.Image = global::ClinicSystemFormProject.Properties.Resources.icons8_minus_48;
            this.BtnMinimize.Location = new System.Drawing.Point(13, 8);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(34, 34);
            this.BtnMinimize.TabIndex = 71;
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.BackColor = System.Drawing.SystemColors.Control;
            this.BtnMaximize.Enabled = false;
            this.BtnMaximize.Location = new System.Drawing.Point(50, 8);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(34, 34);
            this.BtnMaximize.TabIndex = 72;
            this.BtnMaximize.UseVisualStyleBackColor = false;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(222, 149);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(352, 43);
            this.txbName.TabIndex = 71;
            // 
            // txbUserName
            // 
            this.txbUserName.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.Location = new System.Drawing.Point(222, 255);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(352, 43);
            this.txbUserName.TabIndex = 72;
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(222, 372);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(352, 43);
            this.txbPassword.TabIndex = 73;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(287, 497);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 43);
            this.btnCancel.TabIndex = 86;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(525, 497);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(171, 43);
            this.btnSave.TabIndex = 85;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddUserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 591);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbPermissions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "AddUserFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddUserFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gbPermissions.ResumeLayout(false);
            this.gbPermissions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbPermissions;
        private System.Windows.Forms.CheckBox chbPayments;
        private System.Windows.Forms.CheckBox chbUsers;
        private System.Windows.Forms.CheckBox chbAppointments;
        private System.Windows.Forms.CheckBox chbDoctors;
        private System.Windows.Forms.CheckBox chbPatients;
        private System.Windows.Forms.CheckBox chbAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Button BtnMaximize;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}