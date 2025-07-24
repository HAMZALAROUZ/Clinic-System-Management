namespace ClinicSystemFormProject
{
    partial class AddPrescriptionsFrm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.cmbMedicalID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtmEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtmStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbPrescriptionID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSpecialInstructions = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbFrequency = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDosage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMedicationName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnMaximize = new System.Windows.Forms.Button();
            this.pnTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.panel2);
            this.pnTop.Controls.Add(this.lbTitle);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1071, 60);
            this.pnTop.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Controls.Add(this.BtnMaximize);
            this.panel2.Controls.Add(this.BtnMinimize);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(936, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 60);
            this.panel2.TabIndex = 3;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(409, 15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(239, 29);
            this.lbTitle.TabIndex = 106;
            this.lbTitle.Text = "Add New Prescription";
            // 
            // cmbMedicalID
            // 
            this.cmbMedicalID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMedicalID.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedicalID.FormattingEnabled = true;
            this.cmbMedicalID.Location = new System.Drawing.Point(339, 247);
            this.cmbMedicalID.Name = "cmbMedicalID";
            this.cmbMedicalID.Size = new System.Drawing.Size(123, 34);
            this.cmbMedicalID.TabIndex = 105;
            this.cmbMedicalID.SelectedIndexChanged += new System.EventHandler(this.cmbMedicalID_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 26);
            this.label7.TabIndex = 104;
            this.label7.Text = "M.Record ID";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(592, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 26);
            this.label6.TabIndex = 103;
            this.label6.Text = "End Date";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(592, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 26);
            this.label5.TabIndex = 102;
            this.label5.Text = "Start Date";
            // 
            // dtmEndDate
            // 
            this.dtmEndDate.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmEndDate.Location = new System.Drawing.Point(785, 371);
            this.dtmEndDate.Name = "dtmEndDate";
            this.dtmEndDate.Size = new System.Drawing.Size(241, 37);
            this.dtmEndDate.TabIndex = 101;
            // 
            // dtmStartDate
            // 
            this.dtmStartDate.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmStartDate.Location = new System.Drawing.Point(785, 292);
            this.dtmStartDate.Name = "dtmStartDate";
            this.dtmStartDate.Size = new System.Drawing.Size(241, 37);
            this.dtmStartDate.TabIndex = 100;
            // 
            // lbPrescriptionID
            // 
            this.lbPrescriptionID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPrescriptionID.AutoSize = true;
            this.lbPrescriptionID.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrescriptionID.Location = new System.Drawing.Point(390, 137);
            this.lbPrescriptionID.Name = "lbPrescriptionID";
            this.lbPrescriptionID.Size = new System.Drawing.Size(21, 26);
            this.lbPrescriptionID.TabIndex = 99;
            this.lbPrescriptionID.Text = "-";
            this.lbPrescriptionID.Click += new System.EventHandler(this.lbPrescriptionID_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(75, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 26);
            this.label9.TabIndex = 98;
            this.label9.Text = "Prescription ID";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(592, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 52);
            this.label4.TabIndex = 97;
            this.label4.Text = "Special \r\nInstructions";
            // 
            // txbSpecialInstructions
            // 
            this.txbSpecialInstructions.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSpecialInstructions.Location = new System.Drawing.Point(785, 479);
            this.txbSpecialInstructions.Multiline = true;
            this.txbSpecialInstructions.Name = "txbSpecialInstructions";
            this.txbSpecialInstructions.Size = new System.Drawing.Size(241, 101);
            this.txbSpecialInstructions.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(592, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 26);
            this.label3.TabIndex = 95;
            this.label3.Text = "Frequency";
            // 
            // txbFrequency
            // 
            this.txbFrequency.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFrequency.Location = new System.Drawing.Point(785, 137);
            this.txbFrequency.Multiline = true;
            this.txbFrequency.Name = "txbFrequency";
            this.txbFrequency.Size = new System.Drawing.Size(241, 101);
            this.txbFrequency.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 93;
            this.label2.Text = "Dosage";
            // 
            // txbDosage
            // 
            this.txbDosage.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDosage.Location = new System.Drawing.Point(280, 479);
            this.txbDosage.Multiline = true;
            this.txbDosage.Name = "txbDosage";
            this.txbDosage.Size = new System.Drawing.Size(241, 101);
            this.txbDosage.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 52);
            this.label1.TabIndex = 91;
            this.label1.Text = "Medication \r\nName";
            // 
            // txbMedicationName
            // 
            this.txbMedicationName.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMedicationName.Location = new System.Drawing.Point(280, 357);
            this.txbMedicationName.Multiline = true;
            this.txbMedicationName.Name = "txbMedicationName";
            this.txbMedicationName.Size = new System.Drawing.Size(241, 101);
            this.txbMedicationName.TabIndex = 90;
            this.txbMedicationName.TextChanged += new System.EventHandler(this.txbMedicationName_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(331, 624);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 43);
            this.btnCancel.TabIndex = 108;
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
            this.btnSave.Location = new System.Drawing.Point(569, 624);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(171, 43);
            this.btnSave.TabIndex = 107;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.Control;
            this.BtnClose.Image = global::ClinicSystemFormProject.Properties.Resources.icons8_close_window_50;
            this.BtnClose.Location = new System.Drawing.Point(87, 13);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(34, 34);
            this.BtnClose.TabIndex = 111;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.BackColor = System.Drawing.SystemColors.Control;
            this.BtnMinimize.Image = global::ClinicSystemFormProject.Properties.Resources.icons8_minus_48;
            this.BtnMinimize.Location = new System.Drawing.Point(13, 13);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(34, 34);
            this.BtnMinimize.TabIndex = 109;
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.BackColor = System.Drawing.SystemColors.Control;
            this.BtnMaximize.Enabled = false;
            this.BtnMaximize.Location = new System.Drawing.Point(50, 13);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(34, 34);
            this.BtnMaximize.TabIndex = 110;
            this.BtnMaximize.UseVisualStyleBackColor = false;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // AddPrescriptionsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 719);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbMedicalID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtmEndDate);
            this.Controls.Add(this.dtmStartDate);
            this.Controls.Add(this.lbPrescriptionID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbSpecialInstructions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbFrequency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbDosage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMedicationName);
            this.Controls.Add(this.pnTop);
            this.Name = "AddPrescriptionsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddPrescriptionsFrm_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ComboBox cmbMedicalID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtmEndDate;
        private System.Windows.Forms.DateTimePicker dtmStartDate;
        private System.Windows.Forms.Label lbPrescriptionID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSpecialInstructions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbFrequency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDosage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMedicationName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMaximize;
        private System.Windows.Forms.Button BtnMinimize;
    }
}