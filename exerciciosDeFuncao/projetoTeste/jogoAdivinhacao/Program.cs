using System;

namespace AdivinharNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 200);
            int palpite = 0;


            Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
            Console.WriteLine("Tente adivinhar o número entre 1 e 200.");

            while (palpite != numeroAleatorio)
            {
                Console.Write("Digite o seu palpite: ");
                if (!int.TryParse(Console.ReadLine(), out palpite) || palpite < 1 || palpite > 200)
                {
                    Console.WriteLine("Por favor, digite um número válido entre 1 e 200.");
                    continue;
                }

                if (palpite < numeroAleatorio)
                {
                    Console.WriteLine("Palpite está baixo, tente novamente");
                }
                else if (palpite > numeroAleatorio)
                {
                    Console.WriteLine("Palpite está muito alto, tente novamente");
                }
                else
                {
                    Console.WriteLine("Você acertou!!");
                }
            }


        }
    }
}