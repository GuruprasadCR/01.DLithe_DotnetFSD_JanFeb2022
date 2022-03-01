using System;

namespace inheritence
{
    class company
    {
        protected int id;
        protected string name;

        public void Employeeinfo(int id, string name)
        {
            this.id = id;
            this.name = name;
            Console.WriteLine("Base Employee Id: " + id);
            Console.WriteLine("Base Employee Name: " + name);
        }
    }

    class employee : company 
    {
        
        public void employeeetails()//parameters can also be possible here
        {
            Console.WriteLine("Employee Details are");
            id = 100;
            name = "Ram";
            company C = new company();
            C.Employeeinfo(id, name);
            Console.WriteLine("Derived Employee Id: " + id);
            Console.WriteLine("Derived Employee Name: " + name);
        }
    }

    class Main_Class
    {
        static void Main(String[] args)
        {
            employee emp1 = new employee();
            emp1.employeeetails();
        }
    }
}
