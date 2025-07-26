using ClinicPatientBusinessLayer;
using ClinicPrescriptionBusinessLayer;
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
    public partial class ShowPrescriptionsFrm : Form
    {
        public ShowPrescriptionsFrm()
        {
            InitializeComponent();
        }
        public ShowPrescriptionsFrm(clsPrescription _Prescription)
        {
            InitializeComponent();
            Prescription = _Prescription;
        }
        clsPrescription Prescription = new clsPrescription();
        DataTable table = new DataTable();
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
        private void RefreshPrescriptionsList()
        {
            if (LoadData())
            {
                
                ResizeDGVWidth(dgvPrescriptionRecords);

                dgvPrescriptionRecords.Top = (pnMain.Height - dgvPrescriptionRecords.Height) / 2;
                dgvPrescriptionRecords.Left = (pnMain.Width - dgvPrescriptionRecords.Width) / 2;
            }
        }
        private void btnPrescriptionAdd_Click(object sender, EventArgs e)
        {
            Form frm = new AddPrescriptionsFrm();
            ClinicMainForm.Mode = ClinicMainForm.enMode.enAdd;
            frm.ShowDialog();
            RefreshPrescriptionsList();
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
            table = clsPrescription.GelAllPrescriptions();

            if (table == null)
            {
                return false;
            }
            dgvPrescriptionRecords.DataSource = table;
            return true;
        }
        private void ShowPrescriptionsFrm_Load(object sender, EventArgs e)
        {

            if (LoadData())
            {
                if (!dgvPrescriptionRecords.Columns.Contains("UP") && !dgvPrescriptionRecords.Columns.Contains("DE"))
                    AddImageColumn(dgvPrescriptionRecords);
                
                    ResizeDGVWidth(dgvPrescriptionRecords);

                dgvPrescriptionRecords.Top = (pnMain.Height - dgvPrescriptionRecords.Height) / 2;
                dgvPrescriptionRecords.Left = (pnMain.Width - dgvPrescriptionRecords.Width) / 2;
            }


        }

        private void dgvPrescriptionRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int PrescriptionID = -1;
            clsPrescription prescription = new clsPrescription();

            if (dgvPrescriptionRecords.Columns[e.ColumnIndex].Name == "UP")
            {

                DataGridViewRow Row = dgvPrescriptionRecords.Rows[e.RowIndex];

                if (!(int.TryParse(Row.Cells["PrescriptionID"].Value.ToString(), out PrescriptionID)))
                {
                    return;
                }




                prescription = clsPrescription.FindPrescription(PrescriptionID);


                if (prescription == null)
                {
                    MessageBox.Show($"We couldn't find Prescription.", "Prescription Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    ClinicMainForm.Mode = enMode.enUpdate;
                    Form frm = new AddPrescriptionsFrm(prescription);
                    frm.ShowDialog();
                    RefreshPrescriptionsList();
                }
            }




                if (dgvPrescriptionRecords.Columns[e.ColumnIndex].Name == "DE")
                {
                    
                    DataGridViewRow Row = dgvPrescriptionRecords.Rows[e.RowIndex];

                    if (!(int.TryParse(Row.Cells["PrescriptionID"].Value.ToString(), out PrescriptionID)))
                    {
                        return;
                    }
                    
                    if (MessageBox.Show("Are You Sure You Want To Delete \'" + Row.Cells["PrescriptionID"].Value.ToString() + "\'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (clsPrescription.DeletePrescription(PrescriptionID))
                        {
                            MessageBox.Show("The record was deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshPrescriptionsList();
                        }
                        else
                        {
                            MessageBox.Show("The record could not be deleted.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }            
        
        }
        private void CenterDataGridView(DataGridView dgv)
        {
            dgv.Left = (pnMain.Width - dgv.Width) / 2;
        }
        private void txbPrescriptionSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbPrescriptionSearch.Text) && int.TryParse(txbPrescriptionSearch.Text, out int ID))
            {
                if (table == null)
                    return;

                table.DefaultView.RowFilter = "PrescriptionID = " + ID;
                dgvPrescriptionRecords.DataSource = table.DefaultView;

                ResizeDGVWidth(dgvPrescriptionRecords);
                CenterDataGridView(dgvPrescriptionRecords);
            }
            
            else if (string.IsNullOrWhiteSpace(txbPrescriptionSearch.Text))
            {
                table.DefaultView.RowFilter = "";
                dgvPrescriptionRecords.DataSource = table.DefaultView;
            }
        }
    }
}
