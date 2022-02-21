using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    class LargestOf3
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Please enter three Numbers");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            int N1 = Convert.ToInt32(s1);
            int N2 = Convert.ToInt32(s2);
            int N3 = Convert.ToInt32(s3);
            if (N1 > N2)
            {
                if (N1 > N3)
                {
                    Console.WriteLine("Largest Number is: " + N1);
                }
                else
                {
                    Console.WriteLine("Largest Number is: " + N3);
                }
            }
            else
            {
                if (N2 > N3)
                {
                    Console.WriteLine("Largest Number is: " + N2);
                }
                else
                {
                    Console.WriteLine("Largest number is: " + N3);
                }
            }

        }
    }
}