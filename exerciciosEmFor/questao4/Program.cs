namespace questao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int numeroPositivo = Convert.ToInt32 (Console.ReadLine());

            for (int i = 0; numeroPositivo > 0; numeroPositivo--)
            {
                Console.WriteLine(numeroPositivo);
            }
        }
    }
}