
class Program
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int[] pares = new int[numeros.Length];
        int[] impares = new int[numeros.Length];

        int contadorPares = 0;
        int contadorImpares = 0;

        foreach (int numero in numeros)
        {
            if (numero % 2 == 0) // Verifica se o número é par
            {
                pares[contadorPares] = numero;
                contadorPares++;
            }
            else
            {
                impares[contadorImpares] = numero;
                contadorImpares++;
            }
        }

        Console.WriteLine("Números Pares:");
        for (int i = 0; i < contadorPares; i++)
        {
            Console.Write($"{pares[i]} ");
        }

        Console.WriteLine("\nNúmeros Ímpares:");
        for (int i = 0; i < contadorImpares; i++)
        {
            Console.Write($"{impares[i]} ");
        }

        
        Console.ReadLine();
    }
}