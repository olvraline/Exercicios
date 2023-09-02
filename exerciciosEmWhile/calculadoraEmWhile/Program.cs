using System;

namespace SimpleCalculatorWithFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");

            while (true)
            {
                Console.Write("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the operator (+, -, *, /) or 'exit' to quit: ");
                string op = Console.ReadLine();

                if (op == "exit")
                    break;

                Console.Write("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = 0;

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            Console.WriteLine("Division by zero is not allowed.");
                        break;
                    default:
                        Console.WriteLine("Invalid operator.");
                        break;
                }

                Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
            }
        }
    }
}
