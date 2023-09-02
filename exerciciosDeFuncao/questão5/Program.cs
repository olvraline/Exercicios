using System;

namespace CalculadoraDeMedia
{
    class Program
    {
        static double CalcularMedia(double num1, double num2, double num3)
        {
            return (num1 + num2 + num3) / 3;
        }

        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            double media = CalcularMedia(num1, num2, num3);

            Console.WriteLine($"A média dos números é: {media}");
        }
    }
}
