using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class16
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        public string Name;
        public string Email;

        public string name
        {
            get { return Name; }
            set { Name = value;  }
        }

        public string email
        {
            get { return Email; }
            set { Email = value; }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            display.Text = $"Welcome {this.Name}";
            displayEmail.Text = this.Email;
        }
    }
}
