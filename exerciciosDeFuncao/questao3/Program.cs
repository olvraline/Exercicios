using System;

namespace ContadorDeDigitos
{
    class Program
    {
        static int ContarDigitos(int numero)
        {
            if (numero == 0)
                return 1; // O número 0 tem um dígito

            int contador = 0;
            while (numero != 0)
            {
                numero /= 10; // Remove o último dígito
                contador++;
            }

            return contador;
        }

        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int numeroDeDigitos = ContarDigitos(numero);

            Console.WriteLine($"O número {numero} tem {numeroDeDigitos} dígito(s).");
        }
    }
}
