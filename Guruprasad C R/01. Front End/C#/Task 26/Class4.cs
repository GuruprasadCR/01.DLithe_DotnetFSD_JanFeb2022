using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraymethod
{
    class ArrayMethods
    {
        static void Display(int[] G)
        {
            foreach (Object K in G)
            {
                Console.WriteLine(K + " ");
            }
        }
        static void Main()
        {
            int[] A = { 100, 350, 215, 45, 10 };
            Console.WriteLine("Base Array");
            foreach (int i in A)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Sorted Array");
            Array.Sort(A);
            Display(A);
            Console.WriteLine("Reverse Array");
            Array.Reverse(A);
            Display(A);
        }
    }
}