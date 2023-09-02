class Program
{
    static void Main(string[] args)
    {
        int numero;
        Console.Write("Digite um número: ");
        string input = Console.ReadLine();
        numero = int.Parse(input);
        Console.WriteLine("Contagem regressiva:");

        do
        {

            Console.WriteLine(numero);
            numero--;

        } while (numero >= 0);

        Console.WriteLine("Contagem regressiva concluída!");
    }
}
