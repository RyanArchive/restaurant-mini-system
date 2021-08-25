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
    public partial class Admin : Form
    {

        static Color grayTemp = Color.FromArgb(0xA2A2A3);
        static Color greenTemp = Color.FromArgb(0x2EB82E);

        Color gray = Color.FromArgb(grayTemp.R, grayTemp.G, grayTemp.B);
        Color green = Color.FromArgb(greenTemp.R, greenTemp.G, greenTemp.B);

        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            btnReservation.BackColor = green;
            btnReservation.FlatAppearance.BorderColor = green;
            btnReservation.ForeColor = Color.White;

            btnAccount.BackColor = green;
            btnAccount.FlatAppearance.BorderColor = green;
            btnAccount.ForeColor = Color.White;

            btnLogout.FlatAppearance.BorderColor = Color.Gray;
            btnLogout.ForeColor = Color.Gray;
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            logoutExit();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            Admin_Reservation frmReserve = new Admin_Reservation()
            {
                Dock = DockStyle.Fill,
                TopLevel = false 
            };

            pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(frmReserve);
            frmReserve.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            Admin_Account frmAccount = new Admin_Account()
            {
                Dock = DockStyle.Fill,
                TopLevel = false
            };

            pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(frmAccount);
            frmAccount.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logoutExit();
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
