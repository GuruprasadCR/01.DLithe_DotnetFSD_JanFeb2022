using System;

namespace String1
{
    class String
    {
        static void Main()
        {
            // Strings 
            string A = "Hello";
            Console.WriteLine(A);

            // string length
            string B = "world";
            Console.WriteLine("String Length: " + B.Length);

            // string concatenation
            Console.WriteLine(A + B);

            // string interpolation
            string C = "String1";
            string D = "String2";
            string F = $"{C} and {D}";
            Console.WriteLine(F);
            Console.WriteLine();

            // Access string
            string G = "Hello world";
            Console.WriteLine("String Access: " + G[3]);

            // IndexOf()
            string H = "Hello world";
            Console.WriteLine("First Index: " + H.IndexOf("w"));

            // LastIndexOf
            string K = "india";
            Console.WriteLine("Last Index: " + K.LastIndexOf("i"));

        }
    }
}