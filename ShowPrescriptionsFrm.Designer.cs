namespace ClinicSystemFormProject
{
    partial class ShowPrescriptionsFrm
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
            this.txbPrescriptionSearch = new System.Windows.Forms.TextBox();
            this.btnPrescriptionAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPrescriptionRecords = new System.Windows.Forms.DataGridView();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptionRecords)).BeginInit();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.LbTitle);
            this.pnTop.Controls.Add(this.panel2);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1249, 60);
            this.pnTop.TabIndex = 2;
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Reem Kufi", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.Location = new System.Drawing.Point(23, 9);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(225, 40);
            this.LbTitle.TabIndex = 26;
            this.LbTitle.Text = "Prescriptions Records";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Controls.Add(this.BtnMinimize);
            this.panel2.Controls.Add(this.BtnMaximize);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1114, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 60);
            this.panel2.TabIndex = 3;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.Control;
            this.BtnClose.Image = global::ClinicSystemFormProject.Properties.Resources.icons8_close_window_50;
            this.BtnClose.Location = new System.Drawing.Point(87, 13);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(34, 34);
            this.BtnClose.TabIndex = 84;
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
            this.BtnMinimize.TabIndex = 82;
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
            this.BtnMaximize.TabIndex = 83;
            this.BtnMaximize.UseVisualStyleBackColor = false;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // txbPrescriptionSearch
            // 
            this.txbPrescriptionSearch.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrescriptionSearch.Location = new System.Drawing.Point(30, 60);
            this.txbPrescriptionSearch.Name = "txbPrescriptionSearch";
            this.txbPrescriptionSearch.Size = new System.Drawing.Size(352, 43);
            this.txbPrescriptionSearch.TabIndex = 28;
            this.txbPrescriptionSearch.TextChanged += new System.EventHandler(this.txbPrescriptionSearch_TextChanged);
            // 
            // btnPrescriptionAdd
            // 
            this.btnPrescriptionAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrescriptionAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrescriptionAdd.FlatAppearance.BorderSize = 2;
            this.btnPrescriptionAdd.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrescriptionAdd.Location = new System.Drawing.Point(1056, 60);
            this.btnPrescriptionAdd.Name = "btnPrescriptionAdd";
            this.btnPrescriptionAdd.Size = new System.Drawing.Size(171, 43);
            this.btnPrescriptionAdd.TabIndex = 27;
            this.btnPrescriptionAdd.Text = "Add";
            this.btnPrescriptionAdd.UseVisualStyleBackColor = false;
            this.btnPrescriptionAdd.Click += new System.EventHandler(this.btnPrescriptionAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Search By : Prescription ID";
            // 
            // dgvPrescriptionRecords
            // 
            this.dgvPrescriptionRecords.AllowUserToAddRows = false;
            this.dgvPrescriptionRecords.AllowUserToDeleteRows = false;
            this.dgvPrescriptionRecords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPrescriptionRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPrescriptionRecords.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPrescriptionRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescriptionRecords.Location = new System.Drawing.Point(242, 148);
            this.dgvPrescriptionRecords.Name = "dgvPrescriptionRecords";
            this.dgvPrescriptionRecords.ReadOnly = true;
            this.dgvPrescriptionRecords.RowHeadersWidth = 62;
            this.dgvPrescriptionRecords.RowTemplate.Height = 28;
            this.dgvPrescriptionRecords.Size = new System.Drawing.Size(764, 362);
            this.dgvPrescriptionRecords.TabIndex = 25;
            this.dgvPrescriptionRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrescriptionRecords_CellContentClick);
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.dgvPrescriptionRecords);
            this.pnMain.Controls.Add(this.label4);
            this.pnMain.Controls.Add(this.btnPrescriptionAdd);
            this.pnMain.Controls.Add(this.txbPrescriptionSearch);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 60);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1249, 659);
            this.pnMain.TabIndex = 29;
            // 
            // ShowPrescriptionsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 719);
            this.ControlBox = false;
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnTop);
            this.Name = "ShowPrescriptionsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ShowPrescriptionsFrm_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptionRecords)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbPrescriptionSearch;
        private System.Windows.Forms.Button btnPrescriptionAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPrescriptionRecords;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Button BtnMaximize;
        private System.Windows.Forms.Label LbTitle;
    }
}