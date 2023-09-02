class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número");
        int numero = int.Parse(Console.ReadLine());
        int primo = 1;

        for (int i = 1; i < numero; i++)
        {
            if (numero % i == 0)
            {
                primo++;
            }
        }

        if (primo > 2)
            Console.WriteLine("O numero é primo");
        else
            Console.WriteLine("O numero não é primo");
    }
}