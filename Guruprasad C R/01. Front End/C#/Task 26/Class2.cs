using System;

namespace Jaggedarray
{

    class Jagged
    {
        static void Main()

        {

            int[][] JA = new int[3][];
            JA[0] = new int[] { 50, 20, 60, 90 };
            JA[1] = new int[] { 70, 20 };
            JA[2] = new int[] {50,90,100 };
           

            for (int i = 0; i < JA.Length; i++)
            {
                Console.Write("Row({0}): ", i);
                for (int j = 0; j < JA[i].Length; j++)
                {
                    Console.Write("{0} ", JA[i][j]);

                }
                Console.WriteLine();



            }



        }


    }
}