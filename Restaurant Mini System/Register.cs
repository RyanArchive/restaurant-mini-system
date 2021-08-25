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
    public partial class Register : Form
    {
        static Color greenTemp = Color.FromArgb(0x2EB82E);
        Color green = Color.FromArgb(greenTemp.R, greenTemp.G, greenTemp.B);

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            btnBack.FlatAppearance.BorderColor = green;
            btnBack.ForeColor = green;

            btnRegister.BackColor = green;
            btnRegister.FlatAppearance.BorderColor = green;
            btnRegister.ForeColor = Color.White;

            this.tblAccountTableAdapter.Fill(this.dbReserveDataSet.tblAccount);
            this.tblAccInfoTableAdapter.Fill(this.dbReserveDataSet.tblAccInfo);
            this.tblLastNumTableAdapter.Fill(this.dbReserveDataSet.tblLastNum);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            toLogin();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int newId, accId;
            string zeroes = "";

            if (!string.IsNullOrWhiteSpace(txtFirst.Text) && !string.IsNullOrWhiteSpace(txtSur.Text) &&
                !string.IsNullOrWhiteSpace(txtContact.Text) && !string.IsNullOrWhiteSpace(txtUser.Text) &&
                !string.IsNullOrWhiteSpace(txtPass.Text) && !string.IsNullOrWhiteSpace(txtRePass.Text))
            {
                if (txtPass.Text == txtRePass.Text)
                {
                    newId = Int32.Parse(this.dbReserveDataSet.tblLastNum.Rows[0]["User"].ToString()) + 1;

                    for (int i = newId.ToString().Length; i < 4; i++)
                    {
                        zeroes += "0";
                    }

                    accId = Int32.Parse("2" + zeroes + newId);
                    this.tblAccInfoTableAdapter.Insert(accId, txtFirst.Text, txtMiddle.Text, txtSur.Text, txtContact.Text);
                    this.tblAccountTableAdapter.Insert(accId, "User", txtUser.Text, txtPass.Text);

                    this.dbReserveDataSet.tblLastNum.Rows[0]["User"] = newId;
                    this.tblLastNumTableAdapter.Update(this.dbReserveDataSet.tblLastNum);
                    this.tblLastNumTableAdapter.Fill(this.dbReserveDataSet.tblLastNum);

                    MessageBox.Show("Account successfully created.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    toLogin();
                }
                else
                {
                    MessageBox.Show("Password does not match.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRePass.Clear();
                    txtRePass.Focus();
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtFirst.Text))
                {
                    txtFirst.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtSur.Text))
                {
                    txtSur.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtContact.Text))
                {
                    txtContact.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtUser.Text))
                {
                    txtUser.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtPass.Text))
                {
                    txtPass.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtRePass.Text))
                {
                    txtRePass.Focus();
                }

                MessageBox.Show("Please fill out the missing fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Methods

        public void toLogin()
        {
            Login frmLog = new Login();
            frmLog.Show();
            this.Hide();
        }

        // KeyPress
        
        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) & e.KeyChar != '-' & e.KeyChar != ' ' & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        // TextChanged

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
            if (txtFirst.Text.StartsWith("-") | txtFirst.Text.StartsWith(" "))
            {
                txtFirst.Text = txtFirst.Text.Substring(1);
            }
        }

        private void txtMiddle_TextChanged(object sender, EventArgs e)
        {
            if (txtMiddle.Text.StartsWith("-") | txtMiddle.Text.StartsWith(" "))
            {
                txtMiddle.Text = txtMiddle.Text.Substring(1);
            }
        }

        private void txtSur_TextChanged(object sender, EventArgs e)
        {
            if (txtSur.Text.StartsWith("-") | txtSur.Text.StartsWith(" "))
            {
                txtSur.Text = txtSur.Text.Substring(1);
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text.StartsWith(" "))
            {
                txtUser.Text = txtUser.Text.Substring(1);
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text.StartsWith(" "))
            {
                txtPass.Text = txtPass.Text.Substring(1);
            }
        }
    }
}
