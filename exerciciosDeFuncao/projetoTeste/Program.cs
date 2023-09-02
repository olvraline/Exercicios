using System;

namespace GuessTheNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroAd = random.Next(1, 101);
            int acertos = 0;
            int palpite = 0;

            Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
            Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

            while (palpite != numeroAd)
            {
                Console.Write("Digite o seu palpite: ");
                if (!int.TryParse(Console.ReadLine(), out palpite) || palpite < 1 || palpite > 100)
                {
                    Console.WriteLine("Por favor, digite um número válido entre 1 e 100.");
                    continue;
                }

                acertos++;

                if (palpite < numeroAd)
                {
                    Console.WriteLine("O número é maior. Tente novamente.");
                }
                else if (palpite > numeroAd)
                {
                    Console.WriteLine("O número é menor. Tente novamente.");
                }
                else
                {
                    Console.WriteLine("Parabéns! Você acertou.");
                }
            }
        }
    }
}
