using System;

namespace SumPositiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma série de números ");

            double sum = 0.0;
            bool continueInput = true;

            while (continueInput)
            {
                Console.Write("Digite um número: ");
                double number = Convert.ToDouble(Console.ReadLine());

                if (number < 0)
                {
                    continueInput = false;
                }
                else
                {
                    sum += number;
                }
            }

            Console.WriteLine($"A soma dos números positivos inseridos é: {sum}");

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
