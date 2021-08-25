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
    public partial class Reservation_Code : Form
    {
        static Color greenTemp = Color.FromArgb(0x2EB82E);
        Color green = Color.FromArgb(greenTemp.R, greenTemp.G, greenTemp.B);

        string resDateTime, resCode;

        public Reservation_Code(string s1, string s2)
        {
            InitializeComponent();
            resCode = s1;
            resDateTime = s2;
        }

        private void Reservation_Code_Load(object sender, EventArgs e)
        {
            btnOK.BackColor = green;
            btnOK.FlatAppearance.BorderColor = green;
            btnOK.ForeColor = Color.White;

            lblCode.Text = resCode;
            lblDateTime.Text = resDateTime;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
