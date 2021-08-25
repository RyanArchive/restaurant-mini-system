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
    public partial class Login : Form
    {
        static Color greenTemp = Color.FromArgb(0x2EB82E);
        Color green = Color.FromArgb(greenTemp.R, greenTemp.G, greenTemp.B);

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnRegister.FlatAppearance.BorderColor = green;
            btnRegister.ForeColor = green;

            btnLogin.BackColor = green;
            btnLogin.FlatAppearance.BorderColor = green;
            btnLogin.ForeColor = Color.White;

            this.tblAccountTableAdapter.Fill(this.dbReserveDataSet.tblAccount);
            this.tblAccInfoTableAdapter.Fill(this.dbReserveDataSet.tblAccInfo);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register frmReg = new Register();
            frmReg.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Boolean match = false;

            if (!string.IsNullOrWhiteSpace(txtUser.Text) && !string.IsNullOrWhiteSpace(txtPass.Text))
            {
                for (int i = 0; i < this.dbReserveDataSet.tblAccount.Rows.Count; i++)
                {
                    int id = Int32.Parse(this.dbReserveDataSet.tblAccount.Rows[i]["ID"].ToString());
                    string username = this.dbReserveDataSet.tblAccount.Rows[i]["Username"].ToString();
                    string password = this.dbReserveDataSet.tblAccount.Rows[i]["Password"].ToString();

                    if (txtUser.Text == username && txtPass.Text == password)
                    {
                        match = true;
                        string name = this.dbReserveDataSet.tblAccInfo.Rows[i]["Firstname"].ToString() +
                            " " + this.dbReserveDataSet.tblAccInfo.Rows[i]["Surname"].ToString();
                        string usertype = this.dbReserveDataSet.tblAccount.Rows[i]["Usertype"].ToString();

                        MessageBox.Show("Welcome, " + name + "!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (usertype.Equals("User"))
                        {
                            Reservation frmRes = new Reservation(id);
                            frmRes.Show();
                            this.Hide();
                        }
                        else if (usertype.Equals("Admin"))
                        {
                            Admin frmAdmin = new Admin();
                            frmAdmin.Show();
                            this.Hide();
                        }

                        break;
                    }
                }

                if (match == false)
                {
                    MessageBox.Show("Invalid username and/or password.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    messageError();
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtUser.Text))
                {
                    txtUser.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtPass.Text))
                {
                    txtPass.Focus();
                }

                MessageBox.Show("Please fill out the missing fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void messageError()
        {
            txtUser.Clear();
            txtPass.Clear();
            txtUser.Focus();
        }
    }
}
