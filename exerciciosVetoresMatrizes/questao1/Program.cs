using System;


class Program

{

    static void Main()

    {

        int[] numeros = new int[5];
        int soma = 0;


        Console.WriteLine("Digite 5 números inteiros:");


        for (int i = 0; i < 5; i++)

        { 
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
            soma += numeros[i];
        }

        double media = (double)soma / 5;
        Console.WriteLine($"A soma dos números é: {soma}");
        Console.WriteLine($"A média dos números é: {media}");

        // Aguarda o usuário pressionar uma tecla para sair.

        Console.ReadKey();

    }

}