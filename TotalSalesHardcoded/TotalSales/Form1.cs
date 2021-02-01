using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
* 1/28/2021
* CSC 153
* Kevin Griffin
* Takes values from an array and displays them and also shows the total of all array values.
*/

namespace TotalSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ARR size with const variable
        const int SIZE = 7;

        // Hardcoded these values but they can be input variables
        double[] salesArr = new double[SIZE]

           {1245.67, 1189.55, 1098.72, 1456.88, 2109.34, 1987.55, 1872.36};

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // loop that displays the values in the array to a list box
            for (int index = 0; index < salesArr.Length; index++)
            {
                listBox1.Items.Add(salesArr[index].ToString());
            }

            // create accumulator variable
            double totalSales = 0;

            // adds each value in the array to accumulator variable in each loop
            for (int index = 0; index < salesArr.Length; index++)
            {
                totalSales += salesArr[index];
            }

            // Display the total of all values or totalSales
            MessageBox.Show("The total amount of sales are $" + totalSales.ToString());
        }
    }
}
