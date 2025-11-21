using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== CALCULATOR ===");
            Console.WriteLine("Enter first number:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Chose an operator (+, -, *, /):");
            string op = Console.ReadLine();

            Console.WriteLine("Enter second number:");
            double b = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Error: division by zero!");
                        Console.ReadKey();
                        continue;
                    }
                    result = a / b;
                    break;
                default:
                    Console.WriteLine("Unknown operator!");
                    Console.ReadKey();
                    continue;
            }

            Console.WriteLine($"Result: {result}");
            Console.WriteLine("\nPress Enter to continue or Esc to exit...");

            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
                break;
        }
    }
}
