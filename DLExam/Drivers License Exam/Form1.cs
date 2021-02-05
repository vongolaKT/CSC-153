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
 * 2/4/2021
 * CSC-153
 * Kevin Griffin
 * Program that takes answers for a 20 question test and compares them to the actual answers to determine if the student passed. Then Displays the amount of questions answered correctly, incorrectly, and a list of numbers
 * for the questions that were answered incorrectly
 */

namespace Drivers_License_Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create Hard Coded Array that store the correct answers in order

            // Get student answers and store in an arra (hard code or input?)

            // create accumulator variable (or is counter a better term?

            // create list for wrong answers

            // for loop that steps through the ammount of times as there are questions/answers
            
                // if statement (or switch and case statement) that compares each value in both arrays at subscript (index)         
                    // if ( arr1[index] == arr2[index] { accumulater++ }

                    // else statement (or second case) { need a list to display incorrect questions, something like: List.Add[index + 1] to show the qeustion number of the one that was wrong }

            // after the for loop (or foreach) another if/else or switch/case statement
                // if (accumulater >= 15) { print: "You Passed!" }
                
                //else { print: "You failed! "}

            // print: "You answered " + accumulater + " questions correctly!"

            // create wrongAnswer = 20 - accumulater

            // print: "You answered " + wrongAnswer + " questions incorrectly!"

            // print: "Here are the questions that you answered incorrectly:"
            // print: List
        }
    }
}
