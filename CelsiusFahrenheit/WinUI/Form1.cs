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
* 4/4/2021
* CSC 153
* Kevin Griffin
* Displays a table that shows celsius to farenheight conversion from 0 to 20
*/

namespace WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // holds celsius and farenheight temps
            double celsius, farenheight;

            // Display header seperated by tab spacing
            temperatureListBox.Items.Add("Celsius\tFarenheight");

            for (celsius = 0; celsius <= 20; celsius++)
            {
                farenheight = (9.0 / 5.0) * celsius + 32;

                // I love string interpolation with $
                temperatureListBox.Items.Add($"{celsius}\t{farenheight}");
            }
        }
    }
}
