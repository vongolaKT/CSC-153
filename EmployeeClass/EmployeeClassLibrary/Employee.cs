using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassLibrary
{
    public class Employee
    {
        public static List<Employee> employees = new List<Employee>();

        private int _id;
        private string _name;
        private string _position;
        private string _department;

        // Remember constructor name must match class name
        // Default Constructor
        public Employee()
        {

        }

        // Contructor with arguments to build object with all arguments overloaded
        public Employee( string name, int id, string position, string department)
        {
            Name = name;
            Position = position;
            ID = id;
            Department = department;
        }

        // Second constructor that only requires name and ID
        public Employee(string name, int id)
        {

        }

        // Long way with backing fields (private local variables)
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }


    }
}
