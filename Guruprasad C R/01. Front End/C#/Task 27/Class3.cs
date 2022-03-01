using System;

namespace PartialM
{
    partial class PartialClass
    {
        // Declaration of the partial method.
        partial void PartialMethod();
        // A public method calling the partial method
        public void PublicMethod()
        {
            Console.WriteLine("Public Method Invoked");
            PartialMethod();
        }
    }

    partial class PartialClass
    {
        // Partial method implemented
        partial void PartialMethod()
        {
            Console.WriteLine("Partial PartialMethod  Invoked");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PartialClass SC = new PartialClass();
            SC.PublicMethod();

       
            Console.ReadKey();
        }
    }
}