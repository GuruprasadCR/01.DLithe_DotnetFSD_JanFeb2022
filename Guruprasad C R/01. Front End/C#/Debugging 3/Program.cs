using System;

namespace InterfaceDemo
{
    interface interface1
       {
        void Test();
        void Show();
        }

    interface interface2
      {
        void Test();
        void Show();
      }

    class ImplementInterafce : interface1, interface2
    {
        public void Test()
        {

            Console.WriteLine("Test method is implemented");
        }

        public void Show()
        {
            Console.WriteLine("Show method is implemented");
        }

    }

      class Program
      {
         static void Main(string[] args)
        {
        ImplementInterafce obj = new ImplementInterafce();
        obj.Test();
        obj.Show();
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
          }
      }
}

