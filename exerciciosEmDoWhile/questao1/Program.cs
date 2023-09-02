
namespace TabelaDeMultiplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabela de multiplicação do número {numero}:");

            int contador = 1;
            do
            {
                int produto = numero * contador;
                Console.WriteLine($"{numero} x {contador} = {produto}");
                contador++;
            } while (contador <= 10);
        }
    }
}
