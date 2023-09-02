namespace JAMFlix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao JAM.Flix()\n");

            string nomeUsuario = "Aline";
            int senhaUsuario = 12345;

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua senha: ");
            int senha = Convert.ToInt32(Console.ReadLine());

            if (!nomeUsuario.Equals(nome) && senhaUsuario != senha)
            {
                Console.WriteLine("Usuário/Senha inválido(a).");
                return;
            }

            Console.Clear();
            Console.WriteLine($"Bem-vindo ao JAM.Flix()\nBoa-noite, {nomeUsuario}.\n");

            Console.WriteLine("Selecione a categoria de filmes que deseja visualizar:\n");
            Console.WriteLine("1. Ação");
            Console.WriteLine("2. Aventura");
            Console.WriteLine("3. Fantasia");
            Console.WriteLine("4. Ficção Científica");
            Console.WriteLine("5. Drama");
            Console.WriteLine("6. Investigação");
            Console.WriteLine("7. Romance");
            Console.WriteLine("8. Musical");
            Console.WriteLine("9. Terror\n");

            int opcaoSelecionada = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            switch (opcaoSelecionada)
            {
                case 1:
                    Console.WriteLine("Aqui está a lista de filmes de ação:\n");
                    Console.WriteLine("Duro de Matar");
                    Console.WriteLine("Mad Max: Estrada da Furia");
                    Console.WriteLine("John Wick");
                    break;

                case 2:
                    Console.WriteLine("Aqui está sua lista de filmes de aventura:\n");
                    Console.WriteLine("Jumanji");
                    Console.WriteLine("Jurassic Park");
                    Console.WriteLine("Indiana Jones E Os Caçadores da Arca Perdida");
                    break;

                case 3:
                    Console.WriteLine("Aqui está sua lista de filmes de fantasia:\n");
                    Console.WriteLine("O senhor dos Anéis: A Sociedade Do Anel");
                    Console.WriteLine("Caverna do Dragão");
                    Console.WriteLine("Harry Potter E A Pedra Filosofal");
                    break;

                case 4:
                    Console.WriteLine("Aqui está sua lista de filmes de ficção científica:\n");
                    Console.WriteLine("Interstellar");
                    Console.WriteLine("Ex Machina");
                    Console.WriteLine("Blade Runner 2049");
                    break;

                case 5:
                    Console.WriteLine("Aqui está sua lista de filmes de drama:\n");
                    Console.WriteLine("O Curioso Caso De Benjamin Button");
                    Console.WriteLine("Náufrago");
                    Console.WriteLine("Forrest Gump: O Contador De Histórias");
                    break;

                case 6:
                    Console.WriteLine("Aqui está sua lista de filmes de investigação:\n");
                    Console.WriteLine("Seven: Os 7 Pecados Capitais");
                    Console.WriteLine("Gone Girl");
                    Console.WriteLine("O Silêncio Dos Inocentes");
                    break;

                case 7:
                    Console.WriteLine("Aqui está sua lista de filmes de romance:\n");
                    Console.WriteLine("Titanic");
                    Console.WriteLine("Orgulho e Preconceito");
                    Console.WriteLine("Diario de Uma Paixão");
                    break;

                case 8:
                    Console.WriteLine("Aqui está sua lista de filmes musicais:\n");
                    Console.WriteLine("O Rei Leão");
                    Console.WriteLine("La La Land");
                    Console.WriteLine("Os Miseráveis");
                    break;

                case 9:
                    Console.WriteLine("Aqui está sua lista de filmes de terror:\n");
                    Console.WriteLine("Invocação do Mal");
                    Console.WriteLine("A Morte Do Demônio");
                    Console.WriteLine("O Chamado");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
