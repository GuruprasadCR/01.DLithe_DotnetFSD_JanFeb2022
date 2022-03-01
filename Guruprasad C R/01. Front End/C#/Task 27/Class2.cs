using System;

namespace partialc
{
    public partial class partialclass
    {
        public void Hello()
        {
            Console.WriteLine("Calling partial class 1");
        }


    }

    public partial class partialclass
    {
        public void Hai()
        {
            Console.WriteLine("Calling partial class 2");
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            partialclass pc = new partialclass();
            pc.Hello();
            pc.Hai();
        }
    }
}
