using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetClassLibrary;

/**
* 3/5/2021
* CSC 153
* Kevin Griffin
* Create Objects from user input and display back object information
*/

namespace WinUI
{
    // The instructions for the problem are fairly loose here... should I have used a messageForm instead of messageBox? Also should I have sanitized/validated input and have a search for other pets
    // Instead of what I have now which is just displaying the last pet created that was stored in the pets list?
    public partial class PetForm : Form
    {
        public PetForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // Catch exceptions if input is not correct type and cannot be parsed so we dont crash here. I prefer this so I can keep the Extra message box and clear input if it is correct

            try
            {
                Pet.pets.Add(new Pet(nameTextBox.Text.ToString(), typeTextBox.Text.ToString(), int.Parse(ageTextBox.Text)));

                MessageBox.Show("Pet Added!");

                nameTextBox.Text = "";
                ageTextBox.Text = "";
                typeTextBox.Text = "";

            }
            catch
            {
                MessageBox.Show("Check input Please!");
            }
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show($"Name : {Pet.pets[Pet.pets.Count - 1].Name} \n" +
                $"Type : {Pet.pets[Pet.pets.Count - 1].Type} \n" +
                $"Age : {Pet.pets[Pet.pets.Count - 1].Age}");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            ageTextBox.Text = "";
            typeTextBox.Text = "";

        }
    }
}
