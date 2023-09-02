namespace questao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um Número");
            int num =Convert.ToInt32(Console.ReadLine());

            int aux = 1;
            for (int i = 0; i < num; i++)
            {
                aux *= 2;
                Console.WriteLine($"2^{i}={aux}");
            }
        }
    }
}