using System;

class Program
{
    static void Main()
    {
        int tamanhoMaximo = 100; // Defina o tamanho máximo do vetor
        int[] numeros = new int[tamanhoMaximo];
        int contador = 0;

        Console.WriteLine("Digite números inteiros (digite 0 para parar):");

        int numero;
        do
        {
            Console.Write("Número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero != 0)
            {
                numeros[contador] = numero;
                contador++;
            }
        } while (numero != 0);

        if (contador == 0)
        {
            Console.WriteLine("Nenhum número foi digitado.");
        }
        else
        {
            int maior = numeros[0];
            int menor = numeros[0];

            for (int i = 1; i < contador; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            Console.WriteLine($"O maior número digitado é: {maior}");
            Console.WriteLine($"O menor número digitado é: {menor}");
        }

        // Aguarda o usuário pressionar uma tecla para sair.
        Console.ReadKey();
    }
}