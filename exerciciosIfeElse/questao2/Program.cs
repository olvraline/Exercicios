
            Console.Write("Digite um ano: ");
            int ano = int.Parse(Console.ReadLine());

            if (EhBissexto(ano))
            {
                Console.WriteLine($"{ano} é um ano bissexto.");
            }
            else
            {
                Console.WriteLine($"{ano} não é um ano bissexto.");
            }


        static bool EhBissexto(int ano)
{
    if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
    {
        return true;
    }
    return false;
}
