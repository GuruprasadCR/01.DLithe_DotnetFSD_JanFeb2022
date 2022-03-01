using System;
using System.IO;  // include the System.IO namespace

namespace Files
{
    class FilesRead
    {
        static void Main(string[] args)

        {
            //file read
            string path = @"C:\Users\Guruprasad\Desktop\Guruprasad C R\03.C#\Task 32\Hello.txt";
            string lines;

            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
            Console.ReadKey();

        }
    }
}