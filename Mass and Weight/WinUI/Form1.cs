using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeightClassLibrary;

namespace WinUI
{
    public partial class MassAndWeightForm : Form
    {
        public MassAndWeightForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double mass, weight;
            try
            {
                mass = Double.Parse(massTextBox.Text);

                weight = CalculateWeight.WeightCalculation(ref mass);

                displayWeightLabel.Text = weight.ToString("n1");

                if (weight > 1000)
                {
                    MessageBox.Show("The object is too heavy");
                }

                if (weight < 10)
                {
                    MessageBox.Show("The object is too light");
                }
            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            massTextBox.Text = "";
            displayWeightLabel.Text = "";
            massTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
