namespace ClinicSystemFormProject
{
    partial class ClinicMainForm
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.LbTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnMaximize = new System.Windows.Forms.Button();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnUsers = new System.Windows.Forms.Button();
            this.BtnAppointments = new System.Windows.Forms.Button();
            this.BtnPayments = new System.Windows.Forms.Button();
            this.BtnDoctors = new System.Windows.Forms.Button();
            this.BtnPatients = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnAppointments = new System.Windows.Forms.Panel();
            this.txbAppointmentSearch = new System.Windows.Forms.TextBox();
            this.btnAppointmentAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.pnUsers = new System.Windows.Forms.Panel();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.txbUserSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.pnPayments = new System.Windows.Forms.Panel();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.txbPaymentSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.pnDoctors = new System.Windows.Forms.Panel();
            this.btnDoctorAdd = new System.Windows.Forms.Button();
            this.txbDoctorSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.pnPatients = new System.Windows.Forms.Panel();
            this.btnPatientAdd = new System.Windows.Forms.Button();
            this.txbPatientSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.pnDashboard = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnMain.SuspendLayout();
            this.pnAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.pnUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.pnDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.pnPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.pnDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.LbTitle);
            this.pnTop.Controls.Add(this.panel2);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1511, 60);
            this.pnTop.TabIndex = 0;
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Reem Kufi", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.Location = new System.Drawing.Point(28, 12);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(127, 40);
            this.LbTitle.TabIndex = 6;
            this.LbTitle.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Controls.Add(this.BtnMinimize);
            this.panel2.Controls.Add(this.BtnMaximize);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1376, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 60);
            this.panel2.TabIndex = 3;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.Control;
            this.BtnClose.Image = global::ClinicSystemFormProject.Properties.Resources.icons8_close_window_50;
            this.BtnClose.Location = new System.Drawing.Point(89, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(34, 34);
            this.BtnClose.TabIndex = 27;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.BackColor = System.Drawing.SystemColors.Control;
            this.BtnMinimize.Image = global::ClinicSystemFormProject.Properties.Resources.icons8_minus_48;
            this.BtnMinimize.Location = new System.Drawing.Point(15, 12);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(34, 34);
            this.BtnMinimize.TabIndex = 25;
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.BackColor = System.Drawing.SystemColors.Control;
            this.BtnMaximize.Enabled = false;
            this.BtnMaximize.Location = new System.Drawing.Point(52, 12);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(34, 34);
            this.BtnMaximize.TabIndex = 26;
            this.BtnMaximize.UseVisualStyleBackColor = false;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // pnLeft
            // 
            this.pnLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLeft.Controls.Add(this.BtnLogout);
            this.pnLeft.Controls.Add(this.pictureBox2);
            this.pnLeft.Controls.Add(this.BtnUsers);
            this.pnLeft.Controls.Add(this.BtnAppointments);
            this.pnLeft.Controls.Add(this.BtnPayments);
            this.pnLeft.Controls.Add(this.BtnDoctors);
            this.pnLeft.Controls.Add(this.BtnPatients);
            this.pnLeft.Controls.Add(this.BtnDashboard);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 60);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(252, 788);
            this.pnLeft.TabIndex = 1;
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.BtnLogout.Font = new System.Drawing.Font("Reem Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.Image = global::ClinicSystemFormProject.Properties.Resources.icons8_logout_50;
            this.BtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogout.Location = new System.Drawing.Point(0, 716);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(252, 59);
            this.BtnLogout.TabIndex = 31;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ClinicSystemFormProject.Properties.Resources.people_walking_sitting_hospital_building_city_clinic_glass_exterior_flat_vector_illustration_medical_help_emergency_architecture_healthcare_concept;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 154);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // BtnUsers
            // 
            this.BtnUsers.BackColor = System.Drawing.SystemColors.Control;
            this.BtnUsers.Font = new System.Drawing.Font("Reem Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsers.Image = global::ClinicSystemFormProject.Properties.Resources.icons8_user_50;
            this.BtnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsers.Location = new System.Drawing.Point(-2, 513);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(252, 59);
            this.BtnUsers.TabIndex = 26;
            this.BtnUsers.Text = "Users";
            this.BtnUsers.UseVisualStyleBackColor = false;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // BtnAppointments
            // 
            this.BtnAppointments.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAppointments.Font = new System.Drawing.Font("Reem Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAppointments.Image = global::ClinicSystemFormProject.Properties.Resources.icons8_tear_off_calendar_50;
            this.BtnAppointments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAppointments.Location = new System.Drawing.Point(-2, 378);
            this.BtnAppointments.Name = "BtnAppointments";
            this.BtnAppointments.Size = new System.Drawing.Size(252, 59);
            this.BtnAppointments.TabIndex = 27;
            this.BtnAppointments.Text = "Appointments";
            this.BtnAppointments.UseVisualStyleBackColor = false;
            this.BtnAppointments.Click += new System.EventHandler(this.BtnAppointments_Click);
            // 
            // BtnPayments
            // 
            this.BtnPayments.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPayments.Font = new System.Drawing.Font("Reem Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPayments.Image = global::ClinicSystemFormProject.Properties.Resources.icons8_bank_cards_50;
            this.BtnPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPayments.Location = new System.Drawing.Point(-2, 443);
            this.BtnPayments.Name = "BtnPayments";
            this.BtnPayments.Size = new System.Drawing.Size(252, 59);
            this.BtnPayments.TabIndex = 25;
            this.BtnPayments.Text = "Payments";
            this.BtnPayments.UseVisualStyleBackColor = false;
            this.BtnPayments.Click += new System.EventHandler(this.BtnPayments_Click);
            // 
            // BtnDoctors
            // 
            this.BtnDoctors.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDoctors.Font = new System.Drawing.Font("Reem Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoctors.Image = global::ClinicSystemFormProject.Properties.Resources.icons8_doctor_50;
            this.BtnDoctors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDoctors.Location = new System.Drawing.Point(-2, 313);
            this.BtnDoctors.Name = "BtnDoctors";
            this.BtnDoctors.Size = new System.Drawing.Size(252, 59);
            this.BtnDoctors.TabIndex = 28;
            this.BtnDoctors.Text = "Doctors";
            this.BtnDoctors.UseVisualStyleBackColor = false;
            this.BtnDoctors.Click += new System.EventHandler(this.BtnDoctors_Click);
            // 
            // BtnPatients
            // 
            this.BtnPatients.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPatients.Font = new System.Drawing.Font("Reem Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPatients.Image = global::ClinicSystemFormProject.Properties.Resources.icons8_sick_50;
            this.BtnPatients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPatients.Location = new System.Drawing.Point(-2, 248);
            this.BtnPatients.Name = "BtnPatients";
            this.BtnPatients.Size = new System.Drawing.Size(252, 59);
            this.BtnPatients.TabIndex = 29;
            this.BtnPatients.Text = "Patients";
            this.BtnPatients.UseVisualStyleBackColor = false;
            this.BtnPatients.Click += new System.EventHandler(this.BtnPatients_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDashboard.Font = new System.Drawing.Font("Reem Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.Image = global::ClinicSystemFormProject.Properties.Resources.icons8_dashboard_48;
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.Location = new System.Drawing.Point(-2, 183);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(252, 59);
            this.BtnDashboard.TabIndex = 30;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.UseVisualStyleBackColor = false;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // pnMain
            // 
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMain.Controls.Add(this.pnAppointments);
            this.pnMain.Controls.Add(this.pnUsers);
            this.pnMain.Controls.Add(this.pnPatients);
            this.pnMain.Controls.Add(this.pnPayments);
            this.pnMain.Controls.Add(this.pnDoctors);
            this.pnMain.Controls.Add(this.pnDashboard);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(252, 60);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1259, 788);
            this.pnMain.TabIndex = 2;
            // 
            // pnAppointments
            // 
            this.pnAppointments.Controls.Add(this.txbAppointmentSearch);
            this.pnAppointments.Controls.Add(this.btnAppointmentAdd);
            this.pnAppointments.Controls.Add(this.label4);
            this.pnAppointments.Controls.Add(this.dgvAppointments);
            this.pnAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAppointments.Location = new System.Drawing.Point(0, 0);
            this.pnAppointments.Name = "pnAppointments";
            this.pnAppointments.Size = new System.Drawing.Size(1257, 786);
            this.pnAppointments.TabIndex = 2;
            this.pnAppointments.Visible = false;
            // 
            // txbAppointmentSearch
            // 
            this.txbAppointmentSearch.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAppointmentSearch.Location = new System.Drawing.Point(69, 64);
            this.txbAppointmentSearch.Name = "txbAppointmentSearch";
            this.txbAppointmentSearch.Size = new System.Drawing.Size(352, 43);
            this.txbAppointmentSearch.TabIndex = 16;
            this.txbAppointmentSearch.TextChanged += new System.EventHandler(this.txbAppointmentSearch_TextChanged);
            // 
            // btnAppointmentAdd
            // 
            this.btnAppointmentAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAppointmentAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAppointmentAdd.FlatAppearance.BorderSize = 2;
            this.btnAppointmentAdd.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointmentAdd.Location = new System.Drawing.Point(977, 64);
            this.btnAppointmentAdd.Name = "btnAppointmentAdd";
            this.btnAppointmentAdd.Size = new System.Drawing.Size(159, 43);
            this.btnAppointmentAdd.TabIndex = 15;
            this.btnAppointmentAdd.Text = "Add";
            this.btnAppointmentAdd.UseVisualStyleBackColor = false;
            this.btnAppointmentAdd.Click += new System.EventHandler(this.btnAppointmentAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Search By : Appointment ID";
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAppointments.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Location = new System.Drawing.Point(197, 213);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersWidth = 62;
            this.dgvAppointments.RowTemplate.Height = 28;
            this.dgvAppointments.Size = new System.Drawing.Size(805, 362);
            this.dgvAppointments.TabIndex = 2;
            this.dgvAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellContentClick);
            // 
            // pnUsers
            // 
            this.pnUsers.Controls.Add(this.btnUserAdd);
            this.pnUsers.Controls.Add(this.txbUserSearch);
            this.pnUsers.Controls.Add(this.label3);
            this.pnUsers.Controls.Add(this.dgvUsers);
            this.pnUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnUsers.Location = new System.Drawing.Point(0, 0);
            this.pnUsers.Name = "pnUsers";
            this.pnUsers.Size = new System.Drawing.Size(1257, 786);
            this.pnUsers.TabIndex = 1;
            this.pnUsers.Visible = false;
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnUserAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUserAdd.FlatAppearance.BorderSize = 2;
            this.btnUserAdd.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAdd.Location = new System.Drawing.Point(992, 60);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(152, 43);
            this.btnUserAdd.TabIndex = 22;
            this.btnUserAdd.Text = "Add";
            this.btnUserAdd.UseVisualStyleBackColor = false;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // txbUserSearch
            // 
            this.txbUserSearch.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserSearch.Location = new System.Drawing.Point(95, 60);
            this.txbUserSearch.Name = "txbUserSearch";
            this.txbUserSearch.Size = new System.Drawing.Size(352, 43);
            this.txbUserSearch.TabIndex = 21;
            this.txbUserSearch.TextChanged += new System.EventHandler(this.txbUserSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search By : User ID / Username";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(227, 213);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 28;
            this.dgvUsers.Size = new System.Drawing.Size(805, 362);
            this.dgvUsers.TabIndex = 3;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // pnPayments
            // 
            this.pnPayments.Controls.Add(this.btnAddPayment);
            this.pnPayments.Controls.Add(this.txbPaymentSearch);
            this.pnPayments.Controls.Add(this.label2);
            this.pnPayments.Controls.Add(this.dgvPayments);
            this.pnPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPayments.Location = new System.Drawing.Point(0, 0);
            this.pnPayments.Name = "pnPayments";
            this.pnPayments.Size = new System.Drawing.Size(1257, 786);
            this.pnPayments.TabIndex = 0;
            this.pnPayments.Visible = false;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddPayment.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddPayment.FlatAppearance.BorderSize = 2;
            this.btnAddPayment.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPayment.Location = new System.Drawing.Point(977, 84);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(152, 43);
            this.btnAddPayment.TabIndex = 24;
            this.btnAddPayment.Text = "Add";
            this.btnAddPayment.UseVisualStyleBackColor = false;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // txbPaymentSearch
            // 
            this.txbPaymentSearch.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPaymentSearch.Location = new System.Drawing.Point(95, 84);
            this.txbPaymentSearch.Name = "txbPaymentSearch";
            this.txbPaymentSearch.Size = new System.Drawing.Size(352, 43);
            this.txbPaymentSearch.TabIndex = 23;
            this.txbPaymentSearch.TextChanged += new System.EventHandler(this.txbPaymentSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search By : Payment ID";
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPayments.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(226, 212);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersWidth = 62;
            this.dgvPayments.RowTemplate.Height = 28;
            this.dgvPayments.Size = new System.Drawing.Size(805, 362);
            this.dgvPayments.TabIndex = 4;
            this.dgvPayments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayments_CellContentClick);
            // 
            // pnDoctors
            // 
            this.pnDoctors.Controls.Add(this.btnDoctorAdd);
            this.pnDoctors.Controls.Add(this.txbDoctorSearch);
            this.pnDoctors.Controls.Add(this.label5);
            this.pnDoctors.Controls.Add(this.dgvDoctors);
            this.pnDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDoctors.Location = new System.Drawing.Point(0, 0);
            this.pnDoctors.Name = "pnDoctors";
            this.pnDoctors.Size = new System.Drawing.Size(1257, 786);
            this.pnDoctors.TabIndex = 2;
            this.pnDoctors.Visible = false;
            // 
            // btnDoctorAdd
            // 
            this.btnDoctorAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnDoctorAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDoctorAdd.FlatAppearance.BorderSize = 2;
            this.btnDoctorAdd.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorAdd.Location = new System.Drawing.Point(992, 60);
            this.btnDoctorAdd.Name = "btnDoctorAdd";
            this.btnDoctorAdd.Size = new System.Drawing.Size(152, 43);
            this.btnDoctorAdd.TabIndex = 20;
            this.btnDoctorAdd.Text = "Add";
            this.btnDoctorAdd.UseVisualStyleBackColor = false;
            this.btnDoctorAdd.Click += new System.EventHandler(this.btnDoctorAdd_Click);
            // 
            // txbDoctorSearch
            // 
            this.txbDoctorSearch.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDoctorSearch.Location = new System.Drawing.Point(95, 60);
            this.txbDoctorSearch.Name = "txbDoctorSearch";
            this.txbDoctorSearch.Size = new System.Drawing.Size(352, 43);
            this.txbDoctorSearch.TabIndex = 19;
            this.txbDoctorSearch.TextChanged += new System.EventHandler(this.txbDoctorSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Search By : Doctor ID / Name";
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.AllowUserToAddRows = false;
            this.dgvDoctors.AllowUserToDeleteRows = false;
            this.dgvDoctors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDoctors.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.Location = new System.Drawing.Point(168, 213);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.ReadOnly = true;
            this.dgvDoctors.RowHeadersWidth = 62;
            this.dgvDoctors.RowTemplate.Height = 28;
            this.dgvDoctors.Size = new System.Drawing.Size(805, 362);
            this.dgvDoctors.TabIndex = 1;
            this.dgvDoctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctors_CellContentClick);
            // 
            // pnPatients
            // 
            this.pnPatients.Controls.Add(this.btnPatientAdd);
            this.pnPatients.Controls.Add(this.txbPatientSearch);
            this.pnPatients.Controls.Add(this.label6);
            this.pnPatients.Controls.Add(this.dgvPatients);
            this.pnPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPatients.Location = new System.Drawing.Point(0, 0);
            this.pnPatients.Name = "pnPatients";
            this.pnPatients.Size = new System.Drawing.Size(1257, 786);
            this.pnPatients.TabIndex = 2;
            this.pnPatients.Visible = false;
            // 
            // btnPatientAdd
            // 
            this.btnPatientAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnPatientAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPatientAdd.FlatAppearance.BorderSize = 2;
            this.btnPatientAdd.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientAdd.Location = new System.Drawing.Point(973, 62);
            this.btnPatientAdd.Name = "btnPatientAdd";
            this.btnPatientAdd.Size = new System.Drawing.Size(152, 43);
            this.btnPatientAdd.TabIndex = 18;
            this.btnPatientAdd.Text = "Add";
            this.btnPatientAdd.UseVisualStyleBackColor = false;
            this.btnPatientAdd.Click += new System.EventHandler(this.btnPatientAdd_Click);
            // 
            // txbPatientSearch
            // 
            this.txbPatientSearch.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPatientSearch.Location = new System.Drawing.Point(97, 60);
            this.txbPatientSearch.Name = "txbPatientSearch";
            this.txbPatientSearch.Size = new System.Drawing.Size(352, 43);
            this.txbPatientSearch.TabIndex = 17;
            this.txbPatientSearch.TextChanged += new System.EventHandler(this.txbPatientSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Search By : Patient ID / Name";
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPatients.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Location = new System.Drawing.Point(197, 208);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RowHeadersWidth = 62;
            this.dgvPatients.RowTemplate.Height = 28;
            this.dgvPatients.Size = new System.Drawing.Size(805, 362);
            this.dgvPatients.TabIndex = 0;
            this.dgvPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellContentClick);
            // 
            // pnDashboard
            // 
            this.pnDashboard.Controls.Add(this.pictureBox1);
            this.pnDashboard.Controls.Add(this.label1);
            this.pnDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Size = new System.Drawing.Size(1257, 786);
            this.pnDashboard.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClinicSystemFormProject.Properties.Resources.people_walking_sitting_hospital_building_city_clinic_glass_exterior_flat_vector_illustration_medical_help_emergency_architecture_healthcare_concept;
            this.pictureBox1.Location = new System.Drawing.Point(267, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(608, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 691);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clinic System Management";
            // 
            // ClinicMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 848);
            this.ControlBox = false;
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnTop);
            this.Name = "ClinicMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnAppointments.ResumeLayout(false);
            this.pnAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.pnUsers.ResumeLayout(false);
            this.pnUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnPayments.ResumeLayout(false);
            this.pnPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.pnDoctors.ResumeLayout(false);
            this.pnDoctors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.pnPatients.ResumeLayout(false);
            this.pnPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.pnDashboard.ResumeLayout(false);
            this.pnDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnPatients;
        private System.Windows.Forms.Panel pnDoctors;
        private System.Windows.Forms.Panel pnAppointments;
        private System.Windows.Forms.Panel pnUsers;
        private System.Windows.Forms.Panel pnPayments;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAppointmentAdd;
        private System.Windows.Forms.TextBox txbAppointmentSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbPatientSearch;
        private System.Windows.Forms.Button btnPatientAdd;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.TextBox txbUserSearch;
        private System.Windows.Forms.Button btnDoctorAdd;
        private System.Windows.Forms.TextBox txbDoctorSearch;
        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.TextBox txbPaymentSearch;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMaximize;
        private System.Windows.Forms.Button BtnPayments;
        private System.Windows.Forms.Button BtnAppointments;
        private System.Windows.Forms.Button BtnUsers;
        private System.Windows.Forms.Button BtnPatients;
        private System.Windows.Forms.Button BtnDoctors;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnLogout;
    }
}

