using System;
using System.IO;  // include the System.IO namespace

namespace Files
{
    class Fileswrite
    {
        static void Main(string[] args)
        {
            string writeText = "Hai. How are you?";  // Create a text string
            File.WriteAllText("Hello2.txt", writeText);  // Create a file and write the contents of writeText to it

            string readText = File.ReadAllText("Hello2.txt"); // Read the contents of the file
            Console.WriteLine(readText); // Output the content
        }
    }
}