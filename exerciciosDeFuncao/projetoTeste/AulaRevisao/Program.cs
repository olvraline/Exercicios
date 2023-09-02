using System;

class Program
{
    static int Menu()
    {
            Console.WriteLine("Calculadora");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Media");
            Console.WriteLine("par ou impar");

        return Convert.ToInt32(Console.ReadLine());
        static int Somar (int n1, int n2)
        {
            return n1+ n2;
        }
        static int PerguntarNumero(string msg)
        {
            Console.WriteLine(msg);
            return Convert.ToInt32(Console.ReadLine());
        }
        static void ProcessarSoma()
        {
            int n1 = PerguntarNumero("Digite o primero número");
            int n2 = PerguntarNumero("Digite o segundo número");
            Console.WriteLine($"A soma é = {Somar(n1, n2)}");
        }
        
        static void Main(string[] args)
        {
           
            
                do
                {
                    switch (Menu())
                    {
                        case 1:
                            ProcessarSoma();
                            break;

                        case 2:
                            Console.WriteLine("Digite o numero de notas");
                            double qtdNotas = Convert.ToInt32(Console.ReadLine());
                            double somaNotas = 0;

                            for (int i = 1; i < qtdNotas; i++)
                            {
                                Console.WriteLine($"Digite a nota {i}");
                                int nota = Convert.ToInt32(Console.ReadLine());
                                somaNotas += Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine($"A media é: {somaNotas / qtdNotas}");
                            break;

                        case 3:
                            Console.WriteLine("Digite um numero");
                            int n = Convert.ToInt32(Console.ReadLine());
                            string parImpar = (n % 2 == 0) ? "Par" : "impar";
                            if (n % 2 == 0)
                            {
                                Console.WriteLine($"{n} é par");
                            }
                            else
                            {
                                Console.WriteLine("ímpar");
                            }
                            break;
                        case 0:
                            return;
                            break;
                        default:
                            Console.WriteLine("opção invalida");
                            break;
                    }
                    Console.ReadLine();
                      } while (true);
            
           }
    }
}