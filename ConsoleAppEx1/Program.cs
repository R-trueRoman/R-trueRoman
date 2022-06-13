using System;

namespace ConsoleAppEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != "" || (line = Console.ReadLine()) != null)
            {
                line = "x: " + line;
                line = line.Replace(",", " y:");
                
                Console.WriteLine(line);
            }
        }
    }
}
