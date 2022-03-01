using System;


namespace array2d
{
    class array2dm
    {
        static void Main(string[] args)
        {
            int[,] a = new int[,]

            {

               { 1, 8, 3 },
               { 5, 7, 4 },
               { 8, 4, 5 },
               { 3, 9, 6 },
               { 4, 8, 6 }
            };
            int i, j, k;

            Console.WriteLine("Tow dimensional array");

            for (i = 0; i < 5; i++)
            {

                for (j = 0; j < 3; j++)
                {
                    Console.Write("a[{0},{1}] = {2}", i, j, a[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}