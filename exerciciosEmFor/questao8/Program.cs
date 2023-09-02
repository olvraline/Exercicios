namespace questao8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número para calcular seu fatorial! :)");
            int fatorial = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; fatorial > 0; i++)
            {
                fatorial *= fatorial;
                Console.WriteLine(i + "fatorial " + fatorial);
            }
        }
    }
}