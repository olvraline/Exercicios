using System;

namespace AdivinharNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);
            int palpite;

            Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

            do
            {
                Console.Write("Insira seu palpite: ");
                palpite = int.Parse(Console.ReadLine());

                if (palpite < numeroAleatorio)
                {
                    Console.WriteLine("Palpite muito baixo! Tente novamente.");
                }
                else if (palpite > numeroAleatorio)
                {
                    Console.WriteLine("Palpite muito alto! Tente novamente.");
                }
                else
                {
                    Console.WriteLine("Parabéns! Você acertou o número.");
                }
            } while (palpite != numeroAleatorio);
        }
    }
}
