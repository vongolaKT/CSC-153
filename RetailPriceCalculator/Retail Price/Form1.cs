using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail_Price
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double CalculateRetail(double wholesalePrice, double markupPercent)
        {
            // make new variable specifically for the math
            double actualPercentage = markupPercent / 100;

            // The Math
            return wholesalePrice * (1 + actualPercentage);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // if this button is clicked the program closes
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // make variables to hold all needed numbers
            double wholesalePrice, markupPercent, finalPrice;

            // retrieve input and parse string to a double and set to wholesalePrice
            wholesalePrice = double.Parse(textBox1.Text);

            // same as the previous, retreiving value..
            markupPercent = double.Parse(textBox2.Text);

            // get final marked up price
            finalPrice = CalculateRetail(wholesalePrice, markupPercent);

            // Display the final price in string form
            textBox3.Text = finalPrice.ToString();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
