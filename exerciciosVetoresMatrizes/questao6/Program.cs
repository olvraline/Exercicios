using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] vetor = { 1, 2, 3, 4, 2, 5, 2 };
        int valorProcurado = 2;

        int contagem = vetor.Count(x => x == valorProcurado);

        Console.WriteLine($"O valor {valorProcurado} aparece {contagem} vezes no vetor.");

        Console.ReadLine();
    }
}
