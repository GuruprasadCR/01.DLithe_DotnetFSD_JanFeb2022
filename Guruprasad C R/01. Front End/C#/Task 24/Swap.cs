using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
        class Swap
        {
            static void Main(String[] args)
            {
                Console.WriteLine("Enter the first number A: ");
                string a = Console.ReadLine();
                int Num1 = Convert.ToInt32(a);  //100
                Console.WriteLine("Enter the first number B: ");
                string b = Console.ReadLine();
                int Num2 = Convert.ToInt32(b);  //50
                Console.WriteLine("Before Swap:");
                Console.WriteLine("A: " + Num1);
                Console.WriteLine("B: " + Num2);
                Num1 = Num1 + Num2;            //150
                Num2 = Num1 - Num2;           //50
                Num1 = Num1 - Num2;           //100
                Console.WriteLine("After Swap:");
                Console.WriteLine("A: " + Num1);
                Console.WriteLine("B: " + Num2);
            }


        }
}




