using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class employee
    {

        // private variables declared
        // these can only be accessed by
        // public methods of class
        private String employeename;
        private int employeeage;

        // using accessors to get and 
        // set the value of studentName
        public String Name
        {

            get
            {
                return employeename;
            }

            set
            {
                employeename = value;
            }

        }

        // using accessors to get and 
        // set the value of studentAge
        public int Age
        {

            get
            {
                return employeeage;
            }

            set
            {
                employeeage = value;
            }
        }
    }

    // Driver Class
    class Encapsulated
    {

        // Main Method
        static public void Main()
        {

            // creating object
            employee emp1 = new employee();

            
            // standard field 'value'
            emp1.Name = "Rakshith";

            // standard field 'value'
            emp1.Age = 25;

            // Displaying values of the variables
            Console.WriteLine("Name: " + emp1.Name);
            Console.WriteLine("Age: " + emp1.Age);
        }
    }
}
