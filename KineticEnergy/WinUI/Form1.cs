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
* 5/2/2021
* CSC 153
* Kevin Griffin
* Program description
*/

namespace WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double mass, velocity, energy;

            if (double.TryParse(massTextBox.Text, out mass))
            {
                if (double.TryParse(velocityTextBox.Text, out velocity))
                {
                    energy = KineticEnergy(mass, velocity);

                    kineticEnergyLabel.Text = energy.ToString("n1");
                }
                else 
                {
                    MessageBox.Show("Velocity is invalid.");
                }
            }
            else
            {
                MessageBox.Show("Mass is invalid.");
            }
        }

        private double KineticEnergy(double mass, double velocity)
        {
            return 0.5 * mass * Math.Pow(velocity, 2.0);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
