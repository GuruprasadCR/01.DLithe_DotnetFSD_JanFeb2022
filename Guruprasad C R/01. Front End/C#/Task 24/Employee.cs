using System;

namespace P1
{
    class Employee
    {
        static void Main(string[] args)
        {
            //Number of employees
            Console.WriteLine("Please enter the number of employees");
            string val = Console.ReadLine();
            int n = Convert.ToInt32(val);

            //Employee id
            String[] emp_id = new String[n];

            //Employee Name
            String[] emp_name = new String[n];

            //To read employee details
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter the employee " + (i+1) + " ID");
                emp_id[i] = Console.ReadLine();
                Console.WriteLine("Please enter the employee name");
                emp_name[i] = Console.ReadLine();
            }

            //To dispaly the employee deatils
            Console.WriteLine("Below are the employee details");
            Console.WriteLine("-----------------------");
            Console.WriteLine("ID\t Name");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(emp_id[i] + "\t" + emp_name[i]);
            }
        }
    }
}
