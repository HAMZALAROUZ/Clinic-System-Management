using ClinicAppointmentBusinessLayer;
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
using static ClinicSystemFormProject.ClinicMainForm;

namespace ClinicSystemFormProject
{
    public partial class ShowMedicalRecordsFrm : Form
    {
        public ShowMedicalRecordsFrm()
        {
            InitializeComponent();
        }
        DataTable Table = clsMedicalRecord.GetAllMedicalRecords();

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
        private void ResizeDGVWidth(DataGridView dgv)
        {

            int TotalWidth = 0;

            foreach (DataGridViewColumn Column in dgv.Columns)
            {
                TotalWidth += Column.Width;
            }
            dgv.Width = TotalWidth + dgv.RowHeadersWidth + 2;

        }
        bool LoadData()
        {
            Table = clsMedicalRecord.GetAllMedicalRecords();
            if (Table == null)
                return false;

            dgvMedicalRecords.DataSource = Table;
            return true;
        }
        

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

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

        private void txbMedicalSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbMedicalSearch.Text) && int.TryParse(txbMedicalSearch.Text, out int ID))
            {
                if (Table == null)
                    return;

                Table.DefaultView.RowFilter = "MedicalRecordID = " + ID;
                dgvMedicalRecords.DataSource = Table.DefaultView;
            }
            else if (string.IsNullOrWhiteSpace(txbMedicalSearch.Text))
            {
                Table.DefaultView.RowFilter = "";
                dgvMedicalRecords.DataSource = Table.DefaultView;
            }
        }
        void RefreshMRecordList()
        {
            if (LoadData())
            {
               
                   
                ResizeDGVWidth(dgvMedicalRecords);

                dgvMedicalRecords.Top = (pnMain.Height - dgvMedicalRecords.Height) / 2;
                dgvMedicalRecords.Left = (pnMain.Width - dgvMedicalRecords.Width) / 2;
            }
        }
        private void dgvMedicalRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int MedicalID = -1;

            if (dgvMedicalRecords.Columns[e.ColumnIndex].Name == "UP")
            {

                DataGridViewRow Row = dgvMedicalRecords.Rows[e.RowIndex];

                if (!(int.TryParse(Row.Cells["MedicalRecordID"].Value.ToString(), out MedicalID)))
                {
                    return;
                }

                clsMedicalRecord medicalRecord = clsMedicalRecord.FindMedicalRecord(MedicalID);

                if (medicalRecord == null)
                {
                    MessageBox.Show($"Medical Record ID [{MedicalID}] not found.", "M.Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Mode = enMode.enUpdate;
                    Form frm = new AddMedicalRecordsFrm(medicalRecord);
                    frm.ShowDialog();
                    RefreshMRecordList();
                }

            }
            if (dgvMedicalRecords.Columns[e.ColumnIndex].Name == "DE")
            {


                DataGridViewRow Row = dgvMedicalRecords.Rows[e.RowIndex];


                if (!(int.TryParse(Row.Cells["MedicalRecordID"].Value.ToString(), out MedicalID)))
                {
                    return;
                }

                if (MessageBox.Show("Are You Sure You Want To Delete M.Record ID \'" + Row.Cells["MedicalRecordID"].Value.ToString() + "\'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsMedicalRecord.IsMedicalRecordExists(MedicalID))
                    {
                        if (clsMedicalRecord.DeleteMedicalRecord(MedicalID))
                        {
                            MessageBox.Show("The record deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshMRecordList();
                        }
                        else
                        {

                            MessageBox.Show("The record could not be deleted.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }



                    }
                    else
                    {
                        MessageBox.Show("Sorry, the M.Record was not found.", "M.Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }


            }
        }

        

        private void ShowMedicalRecordsFrm_Load(object sender, EventArgs e)
        {
            if (Table == null)
                return;



            if (LoadData())
            {
                if (!dgvMedicalRecords.Columns.Contains("UP") && !dgvMedicalRecords.Columns.Contains("DE"))
                    AddImageColumn(dgvMedicalRecords);
                ResizeDGVWidth(dgvMedicalRecords);

                dgvMedicalRecords.Top = (pnMain.Height - dgvMedicalRecords.Height) / 2;
                dgvMedicalRecords.Left = (pnMain.Width - dgvMedicalRecords.Width) / 2;
            }
        }

        private void btnMedicalAdd_Click(object sender, EventArgs e)
        {
            Form frm = new AddMedicalRecordsFrm();
            Mode = enMode.enAdd;
            frm.ShowDialog();
            RefreshMRecordList();
        }
    }
}
