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

/**
* 4/20/21
* CSC 153
* Kevin Griffin
* Reads numbers from a text file to an array then displays the array, then displays the total amount of the array, average, largest number, and smallest number
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
            const int SIZE = 7;
            int index = 0;
            decimal total = 0m;

            decimal[] sales = new decimal[SIZE];

            StreamReader inputfile = File.OpenText("Sales.txt");

            while (!inputfile.EndOfStream && index < sales.Length)
            {
                sales[index] = decimal.Parse(inputfile.ReadLine());
                index++;
            }

            foreach (decimal sale in sales)
            {
                salesListBox.Items.Add(sale.ToString("c"));
            }

            foreach (decimal sale in sales)
            {
                total += sale;
            }


            decimal average = total / sales.Length;

            decimal largeNum = LargestNum(sales);

            totalLabel.Text = total.ToString("c");

            averageLabel.Text = average.ToString("c");

            largestLabel.Text = largeNum.ToString("c");

            smallestLabel.Text = SmallestNum(sales, largeNum).ToString("c");

        }

        private decimal SmallestNum(decimal[] sales, decimal largeNum)
        {
            decimal lowNum = largeNum;

            foreach (decimal sale in sales)
            {
                if (sale < lowNum)
                {
                    lowNum = sale;
                }
            }

            return lowNum;
        }

        private decimal LargestNum(decimal[] sales)
        {
            decimal highNum = 0m;

            foreach (decimal sale in sales)
            {
                if (sale > highNum)
                {
                    highNum = sale;
                }
            }

            return highNum;
        }
    }
}
