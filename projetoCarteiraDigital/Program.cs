using projetoCarteiraDigital;
using System;
using System.Numerics;

using System;

class Program

{

    static void Main(string[] args)

    {
        Estado estado = new Estado("São Paulo");
        Cidade cidade = new Cidade("São Paulo", estado);
        Endereco endereco = new Endereco("Rua ABC", "12345-678", "Apto 101", 123);
        Banco banco = new Banco("001", "12345-6");
        Cliente pessoa = new Cliente("Fulana de Tal", 26, "123.456.789-00");
        Investimento investimento = new Investimento(10000, 5000, 2000);

        CarteiraDigital carteira = new CarteiraDigital(pessoa, banco, investimento, endereco, cidade);

        while (true)

        {
            Console.Clear();

            Console.WriteLine("Menu da Carteira Digital");
            Console.WriteLine("1. Visualizar informações pessoais");
            Console.WriteLine("2. Visualizar informações bancárias");
            Console.WriteLine("3. Visualizar informações de investimentos");
            Console.WriteLine("4. Visualizar informações de endereço");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            string escolha = Console.ReadLine();

            switch (escolha)

            {
                case "1":

                    Console.Clear();
                    carteira.Pessoa.ExibirInformacoes();
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
                    Console.ReadKey();

                    break;

                case "2":

                    Console.Clear();
                    carteira.Banco.ExibirInformacoes();
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
                    Console.ReadKey();

                    break;

                case "3":

                    Console.Clear();
                    carteira.Investimento.ExibirInformacoes();
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
                    Console.ReadKey();

                    break;

                case "4":

                    Console.Clear();

                    carteira.Endereco.ExibirInformacoes();
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
                    Console.ReadKey();

                    break;

                case "5":

                    Environment.Exit(0);

                    break;

                default:

                    Console.WriteLine("Opção inválida. Pressione qualquer tecla para continuar.");
                    Console.ReadKey();

                    break;

            }

        }

    }
}



