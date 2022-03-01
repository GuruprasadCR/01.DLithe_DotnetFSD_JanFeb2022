using System;

namespace NullableP
{
    class NULL
    {
        static void Main()
        {
            // Nullable
            Nullable<int> A = null;
            Console.WriteLine(A);

            // HasValue
            if (A.HasValue)
            {
                Console.WriteLine("HasValue: " + A.Value);
            }
            else
            {
                Console.WriteLine("HasValue: NULL");
            }

            // GetValueOrDefault
            Console.WriteLine();
            Console.WriteLine("GetValueOrDefault: " +A.GetValueOrDefault());

            // Shorthand
            int? B = null;
            double? C = null;
            Console.WriteLine(B);
            Console.WriteLine(C);

        }
    }
}
