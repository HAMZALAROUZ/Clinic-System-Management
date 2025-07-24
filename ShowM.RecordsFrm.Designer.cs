namespace ClinicSystemFormProject
{
    partial class ShowMedicalRecordsFrm
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.txbMedicalSearch = new System.Windows.Forms.TextBox();
            this.btnMedicalAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMedicalRecords = new System.Windows.Forms.DataGridView();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnMaximize = new System.Windows.Forms.Button();
            this.LbTitle = new System.Windows.Forms.Label();
            this.pnTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalRecords)).BeginInit();
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
            this.pnTop.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Controls.Add(this.BtnMaximize);
            this.panel2.Controls.Add(this.BtnMinimize);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1114, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 60);
            this.panel2.TabIndex = 3;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.txbMedicalSearch);
            this.pnMain.Controls.Add(this.btnMedicalAdd);
            this.pnMain.Controls.Add(this.label4);
            this.pnMain.Controls.Add(this.dgvMedicalRecords);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 60);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1249, 659);
            this.pnMain.TabIndex = 2;
            this.pnMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMain_Paint);
            // 
            // txbMedicalSearch
            // 
            this.txbMedicalSearch.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMedicalSearch.Location = new System.Drawing.Point(39, 44);
            this.txbMedicalSearch.Name = "txbMedicalSearch";
            this.txbMedicalSearch.Size = new System.Drawing.Size(352, 43);
            this.txbMedicalSearch.TabIndex = 24;
            this.txbMedicalSearch.TextChanged += new System.EventHandler(this.txbMedicalSearch_TextChanged);
            // 
            // btnMedicalAdd
            // 
            this.btnMedicalAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnMedicalAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMedicalAdd.FlatAppearance.BorderSize = 2;
            this.btnMedicalAdd.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicalAdd.Location = new System.Drawing.Point(1042, 44);
            this.btnMedicalAdd.Name = "btnMedicalAdd";
            this.btnMedicalAdd.Size = new System.Drawing.Size(171, 43);
            this.btnMedicalAdd.TabIndex = 23;
            this.btnMedicalAdd.Text = "Add";
            this.btnMedicalAdd.UseVisualStyleBackColor = false;
            this.btnMedicalAdd.Click += new System.EventHandler(this.btnMedicalAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Search By : Medical ID";
            // 
            // dgvMedicalRecords
            // 
            this.dgvMedicalRecords.AllowUserToAddRows = false;
            this.dgvMedicalRecords.AllowUserToDeleteRows = false;
            this.dgvMedicalRecords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMedicalRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMedicalRecords.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMedicalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicalRecords.Location = new System.Drawing.Point(240, 200);
            this.dgvMedicalRecords.Name = "dgvMedicalRecords";
            this.dgvMedicalRecords.ReadOnly = true;
            this.dgvMedicalRecords.RowHeadersWidth = 62;
            this.dgvMedicalRecords.RowTemplate.Height = 28;
            this.dgvMedicalRecords.Size = new System.Drawing.Size(764, 362);
            this.dgvMedicalRecords.TabIndex = 21;
            this.dgvMedicalRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicalRecords_CellContentClick);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.Control;
            this.BtnClose.Image = global::ClinicSystemFormProject.Properties.Resources.icons8_close_window_50;
            this.BtnClose.Location = new System.Drawing.Point(87, 13);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(34, 34);
            this.BtnClose.TabIndex = 30;
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
            this.BtnMinimize.TabIndex = 28;
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
            this.BtnMaximize.TabIndex = 29;
            this.BtnMaximize.UseVisualStyleBackColor = false;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Reem Kufi", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.Location = new System.Drawing.Point(32, 13);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(179, 40);
            this.LbTitle.TabIndex = 25;
            this.LbTitle.Text = "Medical Records";
            // 
            // ShowMedicalRecordsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 719);
            this.ControlBox = false;
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnTop);
            this.Name = "ShowMedicalRecordsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ShowMedicalRecordsFrm_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.TextBox txbMedicalSearch;
        private System.Windows.Forms.Button btnMedicalAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvMedicalRecords;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Button BtnMaximize;
        private System.Windows.Forms.Label LbTitle;
    }
}