namespace ClinicSystemFormProject
{
    partial class AddAppointmentFrm
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnMaximize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPatientID = new System.Windows.Forms.ComboBox();
            this.cmbDoctorID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpAppointmentDateTime = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMedicalRecord = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbAppointmentID = new System.Windows.Forms.Label();
            this.btnShowMedRecords = new System.Windows.Forms.Button();
            this.btnShowPrescriptions = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPhonePatient = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbGenderPatient = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbNamePatient = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbSpecDoctor = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.lbPhoneDoctor = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbGenderDoctor = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lbNameDoctor = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbDatePayment = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lbAmountPayment = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lbMethodPayment = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.rtbDiagnosis = new System.Windows.Forms.RichTextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1455, 51);
            this.panel1.TabIndex = 27;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(601, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(253, 29);
            this.lbTitle.TabIndex = 65;
            this.lbTitle.Text = "Add New Appointment";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Controls.Add(this.BtnMinimize);
            this.panel2.Controls.Add(this.BtnMaximize);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1320, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 51);
            this.panel2.TabIndex = 4;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.Control;
            this.BtnClose.Image = global::ClinicSystemFormProject.Properties.Resources.icons8_close_window_50;
            this.BtnClose.Location = new System.Drawing.Point(91, 9);
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
            this.BtnMinimize.Location = new System.Drawing.Point(17, 9);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(34, 34);
            this.BtnMinimize.TabIndex = 71;
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.BackColor = System.Drawing.SystemColors.Control;
            this.BtnMaximize.Location = new System.Drawing.Point(54, 9);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(34, 34);
            this.BtnMaximize.TabIndex = 72;
            this.BtnMaximize.UseVisualStyleBackColor = false;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "Patient ID";
            // 
            // cmbPatientID
            // 
            this.cmbPatientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPatientID.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPatientID.FormattingEnabled = true;
            this.cmbPatientID.Location = new System.Drawing.Point(286, 167);
            this.cmbPatientID.Name = "cmbPatientID";
            this.cmbPatientID.Size = new System.Drawing.Size(123, 34);
            this.cmbPatientID.TabIndex = 33;
            this.cmbPatientID.SelectedIndexChanged += new System.EventHandler(this.cmbPatientID_SelectedIndexChanged);
            // 
            // cmbDoctorID
            // 
            this.cmbDoctorID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDoctorID.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoctorID.FormattingEnabled = true;
            this.cmbDoctorID.Location = new System.Drawing.Point(286, 243);
            this.cmbDoctorID.Name = "cmbDoctorID";
            this.cmbDoctorID.Size = new System.Drawing.Size(123, 34);
            this.cmbDoctorID.TabIndex = 35;
            this.cmbDoctorID.SelectedIndexChanged += new System.EventHandler(this.cmbDoctorID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 26);
            this.label2.TabIndex = 34;
            this.label2.Text = "Doctor ID";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 26);
            this.label3.TabIndex = 47;
            this.label3.Text = "Date";
            // 
            // dtpAppointmentDateTime
            // 
            this.dtpAppointmentDateTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpAppointmentDateTime.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpAppointmentDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointmentDateTime.Location = new System.Drawing.Point(250, 342);
            this.dtpAppointmentDateTime.Name = "dtpAppointmentDateTime";
            this.dtpAppointmentDateTime.ShowUpDown = true;
            this.dtpAppointmentDateTime.Size = new System.Drawing.Size(200, 26);
            this.dtpAppointmentDateTime.TabIndex = 49;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbStatus.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pending",
            "Confirme",
            "Complete",
            "Canceled",
            "Reschedule",
            "No Show"});
            this.cmbStatus.Location = new System.Drawing.Point(286, 418);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(123, 34);
            this.cmbStatus.TabIndex = 50;
            this.cmbStatus.Text = "Select";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 26);
            this.label4.TabIndex = 51;
            this.label4.Text = "Status";
            // 
            // cmbPayment
            // 
            this.cmbPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPayment.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Location = new System.Drawing.Point(286, 568);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(123, 34);
            this.cmbPayment.TabIndex = 55;
            this.cmbPayment.SelectedIndexChanged += new System.EventHandler(this.cmbPayment_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 572);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 26);
            this.label5.TabIndex = 54;
            this.label5.Text = "Payment ID";
            // 
            // cmbMedicalRecord
            // 
            this.cmbMedicalRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMedicalRecord.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedicalRecord.FormattingEnabled = true;
            this.cmbMedicalRecord.Location = new System.Drawing.Point(286, 492);
            this.cmbMedicalRecord.Name = "cmbMedicalRecord";
            this.cmbMedicalRecord.Size = new System.Drawing.Size(123, 34);
            this.cmbMedicalRecord.TabIndex = 53;
            this.cmbMedicalRecord.SelectedIndexChanged += new System.EventHandler(this.cmbMedicalRecord_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 26);
            this.label6.TabIndex = 52;
            this.label6.Text = "Medical Record ID";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(95, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 26);
            this.label9.TabIndex = 67;
            this.label9.Text = "Appointment ID";
            // 
            // lbAppointmentID
            // 
            this.lbAppointmentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAppointmentID.AutoSize = true;
            this.lbAppointmentID.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppointmentID.Location = new System.Drawing.Point(336, 114);
            this.lbAppointmentID.Name = "lbAppointmentID";
            this.lbAppointmentID.Size = new System.Drawing.Size(21, 26);
            this.lbAppointmentID.TabIndex = 68;
            this.lbAppointmentID.Text = "-";
            // 
            // btnShowMedRecords
            // 
            this.btnShowMedRecords.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShowMedRecords.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShowMedRecords.FlatAppearance.BorderSize = 2;
            this.btnShowMedRecords.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMedRecords.ForeColor = System.Drawing.SystemColors.Control;
            this.btnShowMedRecords.Location = new System.Drawing.Point(12, 808);
            this.btnShowMedRecords.Name = "btnShowMedRecords";
            this.btnShowMedRecords.Size = new System.Drawing.Size(297, 58);
            this.btnShowMedRecords.TabIndex = 69;
            this.btnShowMedRecords.Text = "Show Medical Records";
            this.btnShowMedRecords.UseVisualStyleBackColor = false;
            this.btnShowMedRecords.Click += new System.EventHandler(this.btnShowMedRecords_Click);
            // 
            // btnShowPrescriptions
            // 
            this.btnShowPrescriptions.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShowPrescriptions.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShowPrescriptions.FlatAppearance.BorderSize = 2;
            this.btnShowPrescriptions.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPrescriptions.ForeColor = System.Drawing.SystemColors.Control;
            this.btnShowPrescriptions.Location = new System.Drawing.Point(12, 872);
            this.btnShowPrescriptions.Name = "btnShowPrescriptions";
            this.btnShowPrescriptions.Size = new System.Drawing.Size(297, 58);
            this.btnShowPrescriptions.TabIndex = 70;
            this.btnShowPrescriptions.Text = "Show Prescriptions";
            this.btnShowPrescriptions.UseVisualStyleBackColor = false;
            this.btnShowPrescriptions.Click += new System.EventHandler(this.btnShowPrescriptions_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(499, 872);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 43);
            this.btnCancel.TabIndex = 84;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(737, 872);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(171, 43);
            this.btnSave.TabIndex = 83;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Controls.Add(this.lbPhonePatient);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbGenderPatient);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbNamePatient);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(499, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 220);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient";
            // 
            // lbPhonePatient
            // 
            this.lbPhonePatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPhonePatient.AutoSize = true;
            this.lbPhonePatient.BackColor = System.Drawing.Color.CadetBlue;
            this.lbPhonePatient.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhonePatient.Location = new System.Drawing.Point(234, 136);
            this.lbPhonePatient.Name = "lbPhonePatient";
            this.lbPhonePatient.Size = new System.Drawing.Size(45, 26);
            this.lbPhonePatient.TabIndex = 69;
            this.lbPhonePatient.Text = "Set";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.CadetBlue;
            this.label12.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(55, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 26);
            this.label12.TabIndex = 68;
            this.label12.Text = "Phone";
            // 
            // lbGenderPatient
            // 
            this.lbGenderPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbGenderPatient.AutoSize = true;
            this.lbGenderPatient.BackColor = System.Drawing.Color.CadetBlue;
            this.lbGenderPatient.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenderPatient.Location = new System.Drawing.Point(234, 96);
            this.lbGenderPatient.Name = "lbGenderPatient";
            this.lbGenderPatient.Size = new System.Drawing.Size(45, 26);
            this.lbGenderPatient.TabIndex = 67;
            this.lbGenderPatient.Text = "Set";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.CadetBlue;
            this.label10.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(55, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 26);
            this.label10.TabIndex = 66;
            this.label10.Text = "Gender";
            // 
            // lbNamePatient
            // 
            this.lbNamePatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNamePatient.AutoSize = true;
            this.lbNamePatient.BackColor = System.Drawing.Color.CadetBlue;
            this.lbNamePatient.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamePatient.Location = new System.Drawing.Point(234, 56);
            this.lbNamePatient.Name = "lbNamePatient";
            this.lbNamePatient.Size = new System.Drawing.Size(45, 26);
            this.lbNamePatient.TabIndex = 65;
            this.lbNamePatient.Text = "Set";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.CadetBlue;
            this.label8.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 26);
            this.label8.TabIndex = 64;
            this.label8.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox2.Controls.Add(this.lbSpecDoctor);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Controls.Add(this.lbPhoneDoctor);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.lbGenderDoctor);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.lbNameDoctor);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(989, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 220);
            this.groupBox2.TabIndex = 86;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doctor";
            // 
            // lbSpecDoctor
            // 
            this.lbSpecDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSpecDoctor.AutoSize = true;
            this.lbSpecDoctor.BackColor = System.Drawing.Color.CadetBlue;
            this.lbSpecDoctor.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpecDoctor.Location = new System.Drawing.Point(229, 159);
            this.lbSpecDoctor.Name = "lbSpecDoctor";
            this.lbSpecDoctor.Size = new System.Drawing.Size(45, 26);
            this.lbSpecDoctor.TabIndex = 73;
            this.lbSpecDoctor.Text = "Set";
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.CadetBlue;
            this.label36.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(57, 159);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(54, 26);
            this.label36.TabIndex = 72;
            this.label36.Text = "Spec";
            // 
            // lbPhoneDoctor
            // 
            this.lbPhoneDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPhoneDoctor.AutoSize = true;
            this.lbPhoneDoctor.BackColor = System.Drawing.Color.CadetBlue;
            this.lbPhoneDoctor.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneDoctor.Location = new System.Drawing.Point(229, 122);
            this.lbPhoneDoctor.Name = "lbPhoneDoctor";
            this.lbPhoneDoctor.Size = new System.Drawing.Size(45, 26);
            this.lbPhoneDoctor.TabIndex = 71;
            this.lbPhoneDoctor.Text = "Set";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.CadetBlue;
            this.label22.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(57, 122);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 26);
            this.label22.TabIndex = 70;
            this.label22.Text = "Phone";
            // 
            // lbGenderDoctor
            // 
            this.lbGenderDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbGenderDoctor.AutoSize = true;
            this.lbGenderDoctor.BackColor = System.Drawing.Color.CadetBlue;
            this.lbGenderDoctor.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenderDoctor.Location = new System.Drawing.Point(229, 85);
            this.lbGenderDoctor.Name = "lbGenderDoctor";
            this.lbGenderDoctor.Size = new System.Drawing.Size(45, 26);
            this.lbGenderDoctor.TabIndex = 69;
            this.lbGenderDoctor.Text = "Set";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.CadetBlue;
            this.label24.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(57, 85);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 26);
            this.label24.TabIndex = 68;
            this.label24.Text = "Gender";
            // 
            // lbNameDoctor
            // 
            this.lbNameDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNameDoctor.AutoSize = true;
            this.lbNameDoctor.BackColor = System.Drawing.Color.CadetBlue;
            this.lbNameDoctor.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameDoctor.Location = new System.Drawing.Point(229, 48);
            this.lbNameDoctor.Name = "lbNameDoctor";
            this.lbNameDoctor.Size = new System.Drawing.Size(45, 26);
            this.lbNameDoctor.TabIndex = 67;
            this.lbNameDoctor.Text = "Set";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.CadetBlue;
            this.label26.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(57, 48);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 26);
            this.label26.TabIndex = 66;
            this.label26.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox3.Controls.Add(this.lbDatePayment);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.lbAmountPayment);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.lbMethodPayment);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(991, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 220);
            this.groupBox3.TabIndex = 87;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment";
            // 
            // lbDatePayment
            // 
            this.lbDatePayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDatePayment.AutoSize = true;
            this.lbDatePayment.BackColor = System.Drawing.Color.CadetBlue;
            this.lbDatePayment.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatePayment.Location = new System.Drawing.Point(225, 145);
            this.lbDatePayment.Name = "lbDatePayment";
            this.lbDatePayment.Size = new System.Drawing.Size(45, 26);
            this.lbDatePayment.TabIndex = 69;
            this.lbDatePayment.Text = "Set";
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.CadetBlue;
            this.label29.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(54, 145);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(57, 26);
            this.label29.TabIndex = 68;
            this.label29.Text = "Date";
            // 
            // lbAmountPayment
            // 
            this.lbAmountPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAmountPayment.AutoSize = true;
            this.lbAmountPayment.BackColor = System.Drawing.Color.CadetBlue;
            this.lbAmountPayment.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmountPayment.Location = new System.Drawing.Point(225, 105);
            this.lbAmountPayment.Name = "lbAmountPayment";
            this.lbAmountPayment.Size = new System.Drawing.Size(45, 26);
            this.lbAmountPayment.TabIndex = 67;
            this.lbAmountPayment.Text = "Set";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.CadetBlue;
            this.label31.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(54, 105);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(87, 26);
            this.label31.TabIndex = 66;
            this.label31.Text = "Amount";
            // 
            // lbMethodPayment
            // 
            this.lbMethodPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMethodPayment.AutoSize = true;
            this.lbMethodPayment.BackColor = System.Drawing.Color.CadetBlue;
            this.lbMethodPayment.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMethodPayment.Location = new System.Drawing.Point(225, 65);
            this.lbMethodPayment.Name = "lbMethodPayment";
            this.lbMethodPayment.Size = new System.Drawing.Size(45, 26);
            this.lbMethodPayment.TabIndex = 65;
            this.lbMethodPayment.Text = "Set";
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.CadetBlue;
            this.label33.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(54, 65);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(85, 26);
            this.label33.TabIndex = 64;
            this.label33.Text = "Method";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox4.Controls.Add(this.rtbNotes);
            this.groupBox4.Controls.Add(this.rtbDiagnosis);
            this.groupBox4.Controls.Add(this.rtbDescription);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(499, 342);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(459, 395);
            this.groupBox4.TabIndex = 88;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Medical Record";
            // 
            // rtbNotes
            // 
            this.rtbNotes.BackColor = System.Drawing.Color.CadetBlue;
            this.rtbNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbNotes.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNotes.Location = new System.Drawing.Point(185, 264);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(226, 79);
            this.rtbNotes.TabIndex = 72;
            this.rtbNotes.Text = "\n";
            // 
            // rtbDiagnosis
            // 
            this.rtbDiagnosis.BackColor = System.Drawing.Color.CadetBlue;
            this.rtbDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbDiagnosis.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDiagnosis.Location = new System.Drawing.Point(185, 174);
            this.rtbDiagnosis.Name = "rtbDiagnosis";
            this.rtbDiagnosis.Size = new System.Drawing.Size(226, 79);
            this.rtbDiagnosis.TabIndex = 71;
            this.rtbDiagnosis.Text = "\n";
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.Color.CadetBlue;
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbDescription.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.Location = new System.Drawing.Point(185, 84);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(226, 79);
            this.rtbDescription.TabIndex = 70;
            this.rtbDescription.Text = "\n";
            this.rtbDescription.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.CadetBlue;
            this.label15.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(39, 287);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 26);
            this.label15.TabIndex = 69;
            this.label15.Text = "Notes";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.CadetBlue;
            this.label17.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(32, 199);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 26);
            this.label17.TabIndex = 68;
            this.label17.Text = "Diagnosis";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.CadetBlue;
            this.label19.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(32, 110);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 26);
            this.label19.TabIndex = 67;
            this.label19.Text = "Description";
            // 
            // AddAppointmentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1455, 940);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShowPrescriptions);
            this.Controls.Add(this.btnShowMedRecords);
            this.Controls.Add(this.lbAppointmentID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMedicalRecord);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dtpAppointmentDateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDoctorID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPatientID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "AddAppointmentFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddAppointmentFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPatientID;
        private System.Windows.Forms.ComboBox cmbDoctorID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDateTime;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMedicalRecord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbAppointmentID;
        private System.Windows.Forms.Button btnShowMedRecords;
        private System.Windows.Forms.Button btnShowPrescriptions;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Button BtnMaximize;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbPhonePatient;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbGenderPatient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbNamePatient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbSpecDoctor;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label lbPhoneDoctor;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbGenderDoctor;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbNameDoctor;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbDatePayment;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lbAmountPayment;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lbMethodPayment;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.RichTextBox rtbDiagnosis;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
    }
}