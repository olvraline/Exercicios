using System;

class Program
{
    static bool ProcuraValorNoVetor(int[] vetor, int valor)
    {
        // Percorre o vetor para verificar se o valor está presente
        foreach (int elemento in vetor)
        {
            if (elemento == valor)
            {
                return true; // Valor encontrado no vetor
            }
        }

        // Se chegou aqui, o valor não foi encontrado
        return false;
    }

    static void Main()
    {
        int[] meuVetor = { 1, 2, 3, 4, 5 };
        int valorProcurado = 4;

        bool encontrado = ProcuraValorNoVetor(meuVetor, valorProcurado);

        if (encontrado)
        {
            Console.WriteLine($"O valor {valorProcurado} está presente no vetor.");
        }
        else
        {
            Console.WriteLine($"O valor {valorProcurado} não está presente no vetor.");
        }
    }
}
