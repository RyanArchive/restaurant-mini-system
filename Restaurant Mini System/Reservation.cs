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
    public partial class Reservation : Form
    {
        static Color blueTemp = Color.FromArgb(0x00A0C6);
        static Color orangeTemp = Color.FromArgb(0xFF8000);

        Color blue = Color.FromArgb(blueTemp.R, blueTemp.G, blueTemp.B);
        Color orange = Color.FromArgb(orangeTemp.R, orangeTemp.G, orangeTemp.B);

        private int accId, rowIndex1;
        private string resDateTime, toDbDate, toDbTime;

        public Reservation(int i)
        {
            InitializeComponent();
            accId = i;
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            string first = "", middle = "", sur = "", contact = "";

            btnLogout.FlatAppearance.BorderColor = Color.Gray;
            btnLogout.ForeColor = Color.Gray;

            btnEdit.FlatAppearance.BorderColor = blue;
            btnEdit.ForeColor = blue;

            btnSave.BackColor = blue;
            btnSave.FlatAppearance.BorderColor = blue;
            btnSave.ForeColor = Color.White;

            btnContinue.FlatAppearance.BorderColor = orange;
            btnContinue.ForeColor = orange;

            btnReserve.BackColor = orange;
            btnReserve.FlatAppearance.BorderColor = orange;
            btnReserve.ForeColor = Color.White;

            this.tblAccInfoTableAdapter.Fill(this.dbReserveDataSet.tblAccInfo);
            this.tblReservationTableAdapter.Fill(this.dbReserveDataSet.tblReservation);

            for (int i = 0; i < this.dbReserveDataSet.tblAccInfo.Rows.Count; i++)
            {
                int id = Int32.Parse(this.dbReserveDataSet.tblAccInfo.Rows[i]["Account ID"].ToString());

                if (accId == id)
                {
                    rowIndex1 = i;
                    first = this.dbReserveDataSet.tblAccInfo.Rows[i]["Firstname"].ToString();
                    middle = this.dbReserveDataSet.tblAccInfo.Rows[i]["Middlename"].ToString();
                    sur = this.dbReserveDataSet.tblAccInfo.Rows[i]["Surname"].ToString();
                    contact = this.dbReserveDataSet.tblAccInfo.Rows[i]["Contact Number"].ToString();

                    break;
                }
            }

            txtFirst.Text = first;
            txtMiddle.Text = middle;
            txtSur.Text = sur;
            txtContact.Text = contact;

            for (int i = 1; i <= 12; i++)
            {
                cmbHours.Items.Add(i);
            }

            for(int i = 0; i < 60; i++)
            {
                String zero = "";

                if (i.ToString().Length == 1)
                {
                    zero = "0";
                }

                cmbMinutes.Items.Add(zero + i);
            }
        }

        private void Reservation_FormClosing(object sender, FormClosingEventArgs e)
        {
            logoutExit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logoutExit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtFirst.Enabled = true;
            txtMiddle.Enabled = true;
            txtSur.Enabled = true;
            txtContact.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult saveEdit = MessageBox.Show("Save edit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (saveEdit == DialogResult.Yes)
            {
                this.dbReserveDataSet.tblAccInfo.Rows[rowIndex1]["Firstname"] = txtFirst.Text;
                this.dbReserveDataSet.tblAccInfo.Rows[rowIndex1]["Middlename"] = txtMiddle.Text;
                this.dbReserveDataSet.tblAccInfo.Rows[rowIndex1]["Surname"] = txtSur.Text;
                this.dbReserveDataSet.tblAccInfo.Rows[rowIndex1]["Contact Number"] = txtContact.Text;
                this.tblAccInfoTableAdapter.Update(this.dbReserveDataSet.tblAccInfo);
                this.tblAccInfoTableAdapter.Fill(this.dbReserveDataSet.tblAccInfo);

                txtFirst.Enabled = false;
                txtMiddle.Enabled = false;
                txtSur.Enabled = false;
                txtContact.Enabled = false;
                btnSave.Enabled = false;
            }            
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPax.Text) && cmbHours.SelectedItem != null &&
                cmbMinutes.SelectedItem != null && cmbMidday.SelectedItem != null)
            {
                DateTime now = DateTime.Now.Date;
                DateTime date = monCal.SelectionRange.Start.Date;

                if (DateTime.Compare(now, date) < 0)
                {
                    int midDay = 0;

                    if (cmbHours.SelectedItem.ToString() != "12" && cmbMidday.SelectedItem.ToString() == "pm")
                    {
                        midDay = 12;                     
                    }
                    else if (cmbHours.SelectedItem.ToString() == "12" && cmbMidday.SelectedItem.ToString() == "am")
                    {
                        midDay = -12;
                    }

                    TimeSpan selectedTime = new TimeSpan(Int32.Parse(cmbHours.SelectedItem.ToString()) + midDay, Int32.Parse(cmbMinutes.SelectedItem.ToString()), 0);
                    TimeSpan start = new TimeSpan(10, 0, 0);
                    TimeSpan end = new TimeSpan(21, 0, 0);
                    
                    if (start <= selectedTime && selectedTime <= end)
                    {
                        TimeSpan waitTime = TimeSpan.FromMinutes(15);
                        waitTime = selectedTime.Add(waitTime);
                        
                        int hours = waitTime.Hours;
                        string amPm = "am";

                        if (hours == 0)
                        {
                            hours = 12;
                        }
                        else if (hours == 12)
                        {
                            amPm = "pm";
                        }
                        else if (hours > 12)
                        {
                            hours -= 12;
                            amPm = "pm";
                        }

                        toDbDate = monCal.SelectionRange.Start.ToShortDateString();
                        toDbTime = cmbHours.SelectedItem.ToString() + ":" +
                            cmbMinutes.SelectedItem.ToString() + " " + cmbMidday.SelectedItem.ToString();
                        txtSummary.Text = toDbDate + " " + toDbTime;
                        btnReserve.Enabled = true;
                        resDateTime = txtSummary.Text + " - " + hours + ":" + waitTime.Minutes + " " + amPm;
                    }
                    else
                    {
                        MessageBox.Show("Invalid time. Please select within 10:00 AM to 9:00 PM.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid date. Please select later than today.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtPax.Text))
                {
                    txtPax.Focus();
                }

                MessageBox.Show("Please fill out the missing fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnReserve_Click_1(object sender, EventArgs e)
        {
            Random rand = new Random();
            int code = rand.Next(1, 9999);
            String fourDigit = "";

            for (int ii = code.ToString().Length; ii < 4; ii++)
            {
                fourDigit += "0";
            }

            string resCode = accId.ToString().Substring(0, 1) + "-" + accId.ToString().Substring(1, 4) + "-" + fourDigit + code;
            Reservation_Code frmCode = new Reservation_Code(resCode, resDateTime);

            frmCode.ShowDialog(this);
            this.tblReservationTableAdapter.Insert(accId, Int32.Parse(txtPax.Text), DateTime.Parse(toDbDate), toDbTime, resCode, "Reserved");

            txtPax.Clear();
            cmbHours.SelectedIndex = -1;
            cmbMinutes.SelectedIndex = -1;
            cmbMidday.SelectedIndex = -1;
            txtSummary.Clear();
            btnReserve.Enabled = false;
        }

        // Methods

        public void logoutExit()
        {
            DialogResult logout = MessageBox.Show("You are logging out. Do you want to continue?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (logout == DialogResult.Yes)
            {
                Login frmLog = new Login();
                frmLog.Show();
                this.Hide();
            }
        }
    }
}
