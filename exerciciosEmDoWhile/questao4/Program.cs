using System;

namespace SomaDigitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número:");
            int numero = int.Parse(Console.ReadLine());

            int somaDigitos = 0;
            int numeroTemp = numero;

            do
            {
                int digito = numeroTemp % 10;
                somaDigitos += digito; 
                numeroTemp /= 10;
            } while (numeroTemp > 0);

            Console.WriteLine($"A soma dos dígitos de {numero} é {somaDigitos}");
        }
    }
}
