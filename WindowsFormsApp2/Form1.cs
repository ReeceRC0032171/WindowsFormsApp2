using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double resistor1 = Double.Parse(textBox1.Text);
                double resistor2 = Double.Parse(textBox2.Text);
                double resistor3 = Double.Parse(textBox8.Text);
                double resistor4 = Double.Parse(textBox10.Text);

                double totalresistance = 1.0/resistance1+
            }
            catch
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double resistor1 = double.Parse(textBox7.Text);
            double resistor2 = double.Parse(textBox3.Text);
            double resistor3 = double.Parse(textBox4.Text);
            double resistor4 = double.Parse(textBox5.Text);

            double totalresistance = resistor1 + resistor2 + resistor3 + resistor4;
            MessageBox.Show("total resistance =" + totalresistance.ToString("0.00") + "ohms");
        }

        private void Series_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
