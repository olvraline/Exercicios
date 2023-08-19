Console.WriteLine("Escolha um genero de filme: Romance, Musical ou Terror)");
String generoEscolhido = Console.ReadLine();

switch (generoEscolhido.ToLower())
{
    case "romance":
        Console.WriteLine("Aqui estão alguns filmes de romance para você:\n");
        Console.WriteLine("Titanic");
        Console.WriteLine("Orgulho e Preconceito");
        Console.WriteLine("Diario de Uma Paixão");
        break;

    case "musical":
        Console.WriteLine("Aqui estão alguns filmes musicais para você:\n");
        Console.WriteLine("O Rei Leão");
        Console.WriteLine("La La Land");
        Console.WriteLine("Os Miseráveis");
        break;

    case "terror":
        Console.WriteLine("Aqui estão alguns filmes de terror para você:\n");
        Console.WriteLine("Invocação do Mal");
        Console.WriteLine("A Morte Do Demônio");
        Console.WriteLine("O Chamado");
        break;

    default:
        Console.WriteLine("Gênero não encontrado ou inválido");
        break;

}

