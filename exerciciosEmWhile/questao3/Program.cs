using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculating = true;

            while (continueCalculating)
            {
                Console.WriteLine("Calculadora Simples");
                Console.WriteLine("Digite o primeiro número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a operação (+, -, *, /) ou 'q' para sair: ");
                string operation = Console.ReadLine();

                double result = 0.0;

                switch (operation)
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
                            Console.WriteLine("Divisão por zero não é permitida.");
                        break;
                    case "q":
                        continueCalculating = false;
                        break;
                    default:
                        Console.WriteLine("Operação inválida.");
                        break;
                }

                if (continueCalculating)
                    Console.WriteLine($"Resultado: {result}\n");
            }

            Console.WriteLine("Calculadora encerrada. Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
