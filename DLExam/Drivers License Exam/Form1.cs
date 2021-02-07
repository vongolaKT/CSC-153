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
            string[] correctAns = new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };

            // Get student answers and store in an arra (hard code or input?)                   // Make sure they are all uppercase, or use a for loop to use .ToUpper on all array items, this is hardcoded though so no worries
            // Made 2 questions wrong at the end 19 and 20
            string[] studentAns = new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "B", "C" };

            // create accumulator variable (or is counter a better term?
            int numCorrectAns = 0;

            // accumulator for number of wrongAnswers
            int wrongAnswer = 0;

            // create list for wrong answers
            List<int> wrongQuestions = new List<int>();

            // for loop that steps through the ammount of times as there are questions/answers   can use foreach if arrays are the same size, which these are
            for (int index = 0; index < 20; index++)
            {                              
                // if statement (or switch and case statement) that compares each value in both arrays at subscript (index)
                
                if (correctAns[index] == studentAns[index])
                {
                    // if ( arr1[index] == arr2[index] { accumulater++ }
                    numCorrectAns++;
                }                
                // else statement (or second case) { need a list to display incorrect questions, something like: List.Add[index + 1] to show the qeustion number of the one that was wrong }
                else
                {
                    wrongQuestions.Add(index + 1);
                    wrongAnswer++;
                }
            }



            // after the for loop (or foreach) another if/else or switch/case statement
            // if (accumulater >= 15) { print: "You Passed!" }
            if (numCorrectAns >= 15)
            {
                MessageBox.Show("You Passed!");
            }
            //else { print: "You failed! "}
            else
            {
                MessageBox.Show("You Failed!");
            }

            // print: "You answered " + accumulater + " questions correctly!"
            MessageBox.Show("You answered " + numCorrectAns + " questions correctly!");

            // print: "You answered " + wrongAnswer + " questions incorrectly!"
            MessageBox.Show("You answered " + wrongAnswer + " questions incorrectly!");

            // print: "Here are the questions that you answered incorrectly:"
            MessageBox.Show("Here are the questions with incorrect answers: ");

            // convert to string to print out easier
            string wrongQuestionsString = String.Join(" , ",wrongQuestions);
            
            // print: List
            MessageBox.Show(wrongQuestionsString);


            // Close the program after it runs so user doesnt have to.
            this.Close();
        }
    }
}
