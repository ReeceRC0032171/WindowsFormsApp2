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
                double resistor1 = double.Parse(textBox1.Text);
                // reads values from textbox 1 and inputs to resistor 1
                double resistor2 = double.Parse(textBox2.Text);
                double resistor3 = 0.0;
                if (textBox8.Text == "0")
                    resistor3 = double.PositiveInfinity;
                else
                    resistor3 = double.Parse(textBox8.Text);
                // tests textbox 3 for a zero, and returns infinity if it is
                double resistor4 = 0.0;
                if (textBox8.Text == "0")
                    resistor1 = double.PositiveInfinity;
                else
                    resistor3 = double.Parse(textBox10.Text);
                

                double totalresistance = 1.0 / (resistor1 + 1.0 / resistor2 + 1.0 / resistor3 + 1.0 / resistor4 + 1.0);
                // calculates the total resistance of the parallel circuit by division
                MessageBox.Show("total resistance =" + totalresistance.ToString("0.00") + "ohms");
                // shows message of the total resistance in ohms
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
            // reads values from textbox 1 and inputs to resistor 1
            double resistor2 = double.Parse(textBox3.Text);
            double resistor3 = double.Parse(textBox4.Text);
            // reads values from textbox 3 and inputs to resistor 3
            double resistor4 = double.Parse(textBox5.Text);

            double totalresistance = resistor1 + resistor2 + resistor3 + resistor4;
            // calculates the total resistance of the series circuit
            MessageBox.Show("total resistance =" + totalresistance.ToString("0.00") + "ohms");
            // display the total resistance of the series circuit with the unit ohms


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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
