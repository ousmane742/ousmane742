using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calclatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string calTotal;
         double num1;
        double num2;
        double resultat;
        string option;

        private void btn1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "0";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btntime_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnoval_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtTotal.Text);
            if (option.Equals("+"))
                resultat = num1 + num2;
            if (option.Equals("-"))
                resultat = num1 - num2;
            if (option.Equals("*"))
                resultat = num1 * num2;
            if (option.Equals("/"))
                resultat = num1 / num2;
            txtTotal.Text = resultat + "";
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            resultat = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
