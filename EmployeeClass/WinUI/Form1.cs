using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeClassLibrary;

/**
* 03/17/2021
* CSC 153
* Kevin Griffin
* Add Employees info to an object in a list and access the list to display it back.
*/

namespace WinUI
{
    public partial class EmployeeClassForm : Form
    {
        public EmployeeClassForm()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            // Using methods to handle these actions and calling them on click. This keeps the code clutter down here and elsewhere is we decided to add another button that
            // could make use of this same methods, like maybe an edit button for each entry.
            AddEmployee();

            // Update employees graph
            UpdateEmployeeGraph();
        }

        public void UpdateEmployeeGraph()
        {
            // Put this method here as to not reference WinUI labels in the class library. Although I suppose adding another WinUI class would work too?
            displayNameTopLabel.Text = Employee.employees[Employee.employees.Count - 1].Name;
            displayIDTopLabel.Text = Employee.employees[Employee.employees.Count - 1].ID.ToString();
            displayDepartmentTopLabel.Text = Employee.employees[Employee.employees.Count - 1].Department;
            displayPositionTopLabel.Text = Employee.employees[Employee.employees.Count - 1].Position;

            // Only Update these items if there are atleast 2 and 3 object, respectably in the list or else you get out of bounds errors

            if (Employee.employees.Count >= 2)
            {
                displayNameMiddleLabel.Text = Employee.employees[Employee.employees.Count - 2].Name;
                displayIDMiddleLabel.Text = Employee.employees[Employee.employees.Count - 2].ID.ToString();
                displayDepartmentMiddleLabel.Text = Employee.employees[Employee.employees.Count - 2].Department;
                displayPositionMiddleLabel.Text = Employee.employees[Employee.employees.Count - 2].Position;
            }

            if (Employee.employees.Count >= 3)
            {
                displayNameBottomLabel.Text = Employee.employees[Employee.employees.Count - 3].Name;
                displayIDBottomLabel.Text = Employee.employees[Employee.employees.Count - 3].ID.ToString();
                displayDepartmentBottomLabel.Text = Employee.employees[Employee.employees.Count - 3].Department;
                displayPositionBottomLabel.Text = Employee.employees[Employee.employees.Count - 3].Position;
            }
        }
        public void AddEmployee()
        {
            // Literally always building with default this way then adding info, like elsewhere - there must be a better way to pass through the other constructors...
            // could use if statements but that seems like MORE code than just this.
            Employee newEmployee = new Employee();

            newEmployee.Name = nameInputTextBox.Text;

            if (iDNumberInputTextBox.Text == "")
            {
                newEmployee.ID = 0;
            }
            else
            {
                newEmployee.ID = int.Parse(iDNumberInputTextBox.Text);
            }
            newEmployee.Department = DepartmentInputTextBox.Text;
            newEmployee.Position = PositionInputTextBox.Text;

            // Add newly created employee to the list
            Employee.employees.Add(newEmployee);
        }
    }
}
