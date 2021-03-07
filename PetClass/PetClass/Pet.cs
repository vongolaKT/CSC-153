using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetClassLibrary
{
    public class Pet
    {
        public static List<Pet> pets = new List<Pet>();

        private int _age;
        private string _name;
        private string _type;

        // Remember constructor name must match class name
        // Default Constructor
        public Pet()
        { 
        
        }

        // Contructor with arguments to build object
        public Pet(string name, string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }

        // Long way with backing fields (private local variables)
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        // Short way example with auto properties
        // could pass this as an argument into the constructor if I want.
        public static string Nickname { get; set; }
    }
}
