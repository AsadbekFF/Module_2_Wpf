using System;

namespace Module_2_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
            Console.ReadKey();
        }
    }
}
