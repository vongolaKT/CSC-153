using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
* 1/28/2021
* CSC 153
* Kevin Griffin
* Displays sales amounts from a given list, then displays the final total of all values
*/

namespace TotalSales
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            

            // ARR size with const variable
            const int SIZE = 7;

            // Hardcoded these values but they can be input variables
            double[] salesArr = new double[SIZE] 
                
               {1245.67, 1189.55, 1098.72, 1456.88, 2109.34, 1987.55, 1872.36};

            ListBox listBox = new ListBox();

            // Set the size and location of the ListBox.
            listBox.Size = new System.Drawing.Size(200, 100);
            listBox.Location = new System.Drawing.Point(10, 10);
            listBox.CreateControl();

            listBox.BeginUpdate();

            // loop that displays the values in the array to a list box
            for (int index = 0; index < salesArr.Length; index++)
            {
                listBox.Items.Add(salesArr[index]);
            }

            listBox.EndUpdate();


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