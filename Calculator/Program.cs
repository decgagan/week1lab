using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Calculator");

            bool keepGoing = true;
            while (keepGoing)
            {
                double first = ReadNumber("Enter the first number: ");
                string op = ReadOperator();
                double second = ReadNumber("Enter the second number: ");

                if (op == "/" && second == 0)
                {
                    Console.WriteLine("You can't divide by zero.");
                }
                else
                {
                    double result = 0;
                    switch (op)
                    {
                        case "+": result = first + second; break;
                        case "-": result = first - second; break;
                        case "*": result = first * second; break;
                        case "/": result = first / second; break;
                    }
                    Console.WriteLine(first + " " + op + " " + second + " = " + result);
                }

                Console.Write("Do another calculation? (y/n): ");
                string again = Console.ReadLine();
                keepGoing = again != null && again.Trim().ToLower() == "y";
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // Keep asking until the user types a valid number
        static double ReadNumber(string prompt)
        {
            double number;
            Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("That's not a number. " + prompt);
            }
            return number;
        }

        // Keep asking until the user types + - * or /
        static string ReadOperator()
        {
            Console.Write("Enter an operator (+, -, *, /): ");
            string op = (Console.ReadLine() ?? "").Trim();
            while (op != "+" && op != "-" && op != "*" && op != "/")
            {
                Console.Write("Please enter +, -, * or /: ");
                op = (Console.ReadLine() ?? "").Trim();
            }
            return op;
        }
    }
}
