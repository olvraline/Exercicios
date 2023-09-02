using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] vetor1 = { 1, 3, 5, 7, 9 };
        int[] vetor2 = { 2, 4, 6, 8, 10 };

        int[] vetorMesclado = vetor1.Concat(vetor2).OrderBy(x => x).ToArray();

        Console.WriteLine("Vetor Mesclado em Ordem Crescente:");
        foreach (int elemento in vetorMesclado)
        {
            Console.Write(elemento + " ");
        }

        Console.ReadLine();
    }
}
