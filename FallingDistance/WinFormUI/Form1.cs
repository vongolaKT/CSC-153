using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
* 02/21/2021
* CSC 153
* Kevin Griffin
* Program that takes a given amount of time and ehen executed displays how far an object would have travelled (at terminal velocity) in meters.
* From page 382 in textbook
*/

namespace WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double FallingDistance(double time)
        {

            double gravity = 9.8;

            double distance = Math.Pow(0.5 * gravity * time, 2.0);

            return distance;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            double time = Double.Parse(textBox1.Text);

            double answer = FallingDistance(time);

            textBox2.Text = answer.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
