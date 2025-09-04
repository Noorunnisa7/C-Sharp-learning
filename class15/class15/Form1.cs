using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double result;
        string option;
        double num1;
        double num2;


        private void clear_Click(object sender, EventArgs e)
        {
            ResultBox.Clear();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ResultBox.Text +=  btn1.Text;
            //num1 = ResultBox.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ResultBox.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ResultBox.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ResultBox.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ResultBox.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ResultBox.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ResultBox.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ResultBox.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ResultBox.Text += btn9.Text;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            ResultBox.Text += zero.Text;
        }

        private void add_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = Convert.ToDouble(ResultBox.Text);

            ResultBox.Text = "";
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = Convert.ToDouble(ResultBox.Text);

            ResultBox.Text = "";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = Convert.ToDouble(ResultBox.Text);

            ResultBox.Text = "";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = Convert.ToDouble(ResultBox.Text);

            ResultBox.Text = "";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(ResultBox.Text);

            if (option == "+")
            {
                result = num1 + num2;
            }

            ResultBox.Text = $"{result}";
        }
    }
}
