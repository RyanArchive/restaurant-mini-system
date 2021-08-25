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
    public partial class Admin_Reservation : Form
    {
        static Color grayTemp = Color.FromArgb(0xA2A2A3);
        static Color orangeTemp = Color.FromArgb(0xFF8000);
        static Color purpleTemp = Color.FromArgb(0xF0047F);

        Color gray = Color.FromArgb(grayTemp.R, grayTemp.G, grayTemp.B);
        Color orange = Color.FromArgb(orangeTemp.R, orangeTemp.G, orangeTemp.B);
        Color purple = Color.FromArgb(purpleTemp.R, purpleTemp.G, purpleTemp.B);

        public Admin_Reservation()
        {
            InitializeComponent();
        }

        private void Admin_Reservation_Load(object sender, EventArgs e)
        {
            tblReservationDataGridView.BackgroundColor = gray;
            tblReservationDataGridView.GridColor = gray;
            tblReservationDataGridView.ColumnHeadersDefaultCellStyle.Padding = new Padding(4, 4, 4, 4);
            tblReservationDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            tblReservationDataGridView.DefaultCellStyle.Padding = new Padding(4, 0, 4, 0);
            tblReservationDataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

            btnRemove.BackColor = orange;
            btnRemove.FlatAppearance.BorderColor = orange;
            btnRemove.ForeColor = Color.White;

            btnOnSite.FlatAppearance.BorderColor = purple;
            btnOnSite.ForeColor = purple;

            this.tblReservationTableAdapter.Fill(this.dbReserveDataSet.tblReservation);
        }

        private void btnOnSite_Click(object sender, EventArgs e)
        {
            int selectedRow = tblReservationDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            DialogResult onSite = MessageBox.Show("Change status?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (onSite == DialogResult.Yes)
            {                
                this.dbReserveDataSet.tblReservation.Rows[selectedRow]["Status"] = "Arrived";
                this.tblReservationTableAdapter.Update(this.dbReserveDataSet.tblReservation);
                this.tblReservationTableAdapter.Fill(this.dbReserveDataSet.tblReservation);

                MessageBox.Show("A customer has arrived.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedRow = tblReservationDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);            
            DialogResult removeRes = MessageBox.Show("Remove reservation?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (removeRes == DialogResult.Yes)
            {
                this.tblReservationDataGridView.Rows.RemoveAt(selectedRow);
                this.tblReservationTableAdapter.Update(this.dbReserveDataSet.tblReservation);
                this.tblReservationTableAdapter.Fill(this.dbReserveDataSet.tblReservation);

                MessageBox.Show("A reservation has been removed.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
