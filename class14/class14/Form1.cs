using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            string user = username.Text;
            string pass = password.Text;

            if (user == "Nisa" && pass == "12345")
            {
                MessageBox.Show("Welcome "+user, "Success");
                username.Text = "";
                password.Text = "";

            }
            else
            {
                MessageBox.Show("Invalid UserName or password", "Error");

            }


        }
    }
}
