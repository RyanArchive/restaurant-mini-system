using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Mini_System
{
    public partial class Admin_Account : Form
    {
        static Color grayTemp = Color.FromArgb(0xA2A2A3);
        static Color greenTemp = Color.FromArgb(0x2EB82E);
        static Color blueTemp = Color.FromArgb(0x00A0C6);
        static Color orangeTemp = Color.FromArgb(0xFF8000);

        Color gray = Color.FromArgb(grayTemp.R, grayTemp.G, grayTemp.B);
        Color green = Color.FromArgb(greenTemp.R, greenTemp.G, greenTemp.B);
        Color blue = Color.FromArgb(blueTemp.R, blueTemp.G, blueTemp.B);
        Color orange = Color.FromArgb(orangeTemp.R, orangeTemp.G, orangeTemp.B);

        public Admin_Account()
        {
            InitializeComponent();
        }

        private void tblAccountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblAccountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbReserveDataSet);

        }

        private void Admin_Account_Load(object sender, EventArgs e)
        {
            tblAccountDataGridView.BackgroundColor = gray;
            tblAccountDataGridView.GridColor = gray;
            tblAccountDataGridView.ColumnHeadersDefaultCellStyle.Padding = new Padding(4, 4, 4, 4);
            tblAccountDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            tblAccountDataGridView.DefaultCellStyle.Padding = new Padding(4, 0, 4, 0);
            tblAccountDataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

            //btnAdd.BackColor = green;
            //btnAdd.FlatAppearance.BorderColor = green;
            //btnAdd.ForeColor = Color.White;

            //btnUpdate.BackColor = blue;
            //btnUpdate.FlatAppearance.BorderColor = blue;
            //btnUpdate.ForeColor = Color.White;

            btnDelete.FlatAppearance.BorderColor = orange;
            btnDelete.ForeColor = orange;

            this.tblAccountTableAdapter.Fill(this.dbReserveDataSet.tblAccount);
            this.tblAccInfoTableAdapter.Fill(this.dbReserveDataSet.tblAccInfo);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedRow = tblAccountDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            DialogResult deleteAcc = MessageBox.Show("Delete account?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (deleteAcc == DialogResult.Yes)
            {
                this.tblAccountDataGridView.Rows.RemoveAt(selectedRow);
                this.tblAccountTableAdapter.Update(this.dbReserveDataSet.tblAccount);
                this.tblAccountTableAdapter.Fill(this.dbReserveDataSet.tblAccount);

                this.tblAccInfoDataGridView.Rows.RemoveAt(selectedRow);
                this.tblAccInfoTableAdapter.Update(this.dbReserveDataSet.tblAccInfo);
                this.tblAccInfoTableAdapter.Fill(this.dbReserveDataSet.tblAccInfo);

                MessageBox.Show("Account has been deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
