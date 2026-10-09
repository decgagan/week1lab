using System;

namespace HelloWeek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lab 1");

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            // Keep asking until the user types something
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Name can't be empty. Please enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello, " + name.Trim() + "! Nice to meet you.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
