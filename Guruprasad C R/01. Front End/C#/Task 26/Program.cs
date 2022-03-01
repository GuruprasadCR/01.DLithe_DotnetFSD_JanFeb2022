using System;

namespace single_d_array
{
    class array1dm
    {
        static void Main(string[] args)
        {
            string[] X = { "B", "A", "C", "D" };

            for (int i = 0; i < X.Length; i++)
            {
                Console.WriteLine(X[i]);
            }

            foreach (string i in X)
            {
                Console.WriteLine(i);
            }

            Array.Sort(X);
            foreach (string i in X)
            {
                Console.WriteLine(i);
            }

            int[] myNumbers = { 50, 10, 88, 19 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
        }
    }
}


