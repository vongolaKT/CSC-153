using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentValueClassLibrary;

namespace WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // TODO all calc
            DepositLabel.Text = Calculate.CalcPresentValue(TryParse.ParseToDouble(YearsTextBox.Text),
                TryParse.ParseToDecimal(FinalAmountTextBox.Text)).ToString("c");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // TODO clear
            YearsTextBox.Text = "";
            FinalAmountTextBox.Text = "";
            DepositLabel.Text = "";
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
