using System;

class Program
{
    static void Main()
    {
        int[] vetor = { 1, 2, 3, 4, 5 };

        Array.Reverse(vetor);

        Console.WriteLine("Vetor Invertido:");
        foreach (int elemento in vetor)
        {
            Console.Write(elemento + " ");
        }

        Console.ReadLine();
    }
}
