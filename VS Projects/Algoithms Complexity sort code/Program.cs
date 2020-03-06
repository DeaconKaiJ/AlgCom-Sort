using System;
using System.IO;


namespace Algoithms_Complexity_sort_code
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read text file content

            string text = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "Net_1_256\\Net_1_256.txt"));
            Console.WriteLine(text);
        }
    }
}
