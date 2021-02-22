using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
