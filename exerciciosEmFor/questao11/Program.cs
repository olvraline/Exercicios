using System;

namespace questao11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a Altura do Triangulo");
            int altura = int.Parse(Console.ReadLine());
            int asterisco = 1;
            
            for (int a = 1; a < altura; a++)
            {
                int espaco = altura - a;
                for (int e = 0; e < espaco; e++)
                {
                    Console.Write(" ");
                } 
                for (int star = 0; star < asterisco; star++)
                {
                    Console.Write("*");
                }
            }
            asterisco *= 2;
            Console.WriteLine();
            {
               
            }
        }
    }
}