//criar um menu onde aparece todas as questões da lista de exercicio.

//1. Crie uma função que recebe dois números inteiros como parâmetros e retorna a sua soma.
//2. Escreva uma função que calcule o fatorial de um número inteiro passado como argumento.
//4. Implemente uma função que receba uma lista de inteiros e retorne o maior valor presente na lista.
//5. Crie uma função que inverta uma string passada como parâmetro (sem usar funções de inversão embutidas).
//7. Desenvolva uma função que verifique se uma string é um palíndromo (ela lê o mesmo de trás para frente) ou não.
//8. Implemente uma função que receba um valor em graus Celsius e retorne o equivalente em Fahrenheit.
//9. Crie uma função que receba um array de strings e retorne a quantidade de strings que possuem mais de 5 caracteres.
//10. Escreva uma função que calcule o máximo divisor comum (MDC) entre dois números inteiros.
//11. Desenvolva uma função que receba uma lista de inteiros e retorne uma nova lista com os números pares.
//12. Implemente uma função que conte quantas vezes um determinado elemento aparece em uma lista.
//13. Crie uma função que receba uma string e retorne outra string com todas as letras maiúsculas convertidas para minúsculas e vice-versa.

using System.ComponentModel.Design;

namespace ConsoleApp1
{
    static int Menu ()
    {
        Console.WriteLine("1. Crie uma função que recebe dois números inteiros como parâmetros e retorna a sua soma.");
        Console.WriteLine("2. Escreva uma função que calcule o fatorial de um número inteiro passado como argumento.");
        Console.WriteLine("3. Implemente uma função que receba uma lista de inteiros e retorne o maior valor presente na lista.");
        Console.WriteLine("4. Crie uma função que inverta uma string passada como parâmetro (sem usar funções de inversão embutidas).");
        Console.WriteLine("5. Desenvolva uma função que verifique se uma string é um palíndromo (ela lê o mesmo de trás para frente) ou não.");
        Console.WriteLine("6. Implemente uma função que receba um valor em graus Celsius e retorne o equivalente em Fahrenheit.");
        Console.WriteLine("7. Escreva uma função que calcule o máximo divisor comum (MDC) entre dois números inteiros.");
        Console.WriteLine("8 Desenvolva uma função que receba uma lista de inteiros e retorne uma nova lista com os números pares.");
        Console.WriteLine("9. Implemente uma função que conte quantas vezes um determinado elemento aparece em uma lista.");
        Console.WriteLine("10. Crie uma função que receba uma string e retorne outra string com todas as letras maiúsculas convertidas para minúsculas e vice-versa.");
        Console.WriteLine("11. Desenvolva uma função que determine se um número é positivo, negativo ou zero.");

        return Convert.ToInt32(Console.ReadLine());
        static int somarDoisNumeros(int n1, int n2)
        {
            Console.WriteLine("Digite o primeiro Número");
            Console.WriteLine("Digite o segundo Número");
            return n1 + n2;
        }
        static double calcularFatorial(double n1)
        {
            double resultado = 1;
            while (n1 != 1)
            {
                resultado = resultado * n1;
                n1 = n1 - 1;
            }
            return resultado;
        }
        static int EncontrarMaiorValor(List<int> lista)
        {
            if (lista.Count == 0)
            {
                throw new ArgumentException("A lista não pode estar vazia.");
            }

            int maiorValor = lista[0];
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i] > maiorValor)
                {
                    maiorValor = lista[i];
                }
            }
            return maiorValor;
        }
        static string inverterPalavra()
            {

        }

        static void Main(string[] args)
        
        {
            switch (Menu())

            {
                case 1:
                    somarDoisNumeros();
                    break;
                case 2:
                    calcularFatorial;
                    break;
                case 3:
                    EncontrarMaiorValor;
                    break;






            }





        }
        
        Console.ReadLine();
    }
}