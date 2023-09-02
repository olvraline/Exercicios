using System;

namespace CalculoMediaNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalNotas = 0;
            int quantidadeNotas = 0;

            Console.WriteLine("Insira as notas (insira -1 para encerrar):");

            double nota;
            do
            {
                Console.Write("Insira uma nota: ");
                nota = double.Parse(Console.ReadLine());

                if (nota >= 0)
                {
                    totalNotas += nota;
                    quantidadeNotas++;
                }

            } while (nota != -1);

            if (quantidadeNotas > 0)
            {
                double media = totalNotas / quantidadeNotas;
                Console.WriteLine($"Média das notas não negativas: {media:F2}");
            }
            else
            {
                Console.WriteLine("Nenhuma nota válida foi inserida.");
            }
        }
    }
}
