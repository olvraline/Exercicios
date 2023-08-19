Console.WriteLine("Choose a movie genre: Romance, Musical, or Horror");
string chosenGenre = Console.ReadLine();

switch (chosenGenre.ToLower())
{
    case "romance":
        Console.WriteLine("Here are some romance movies for you:\n");
        Console.WriteLine("Titanic");
        Console.WriteLine("Pride and Prejudice");
        Console.WriteLine("The Notebook");
        break;

    case "musical":
        Console.WriteLine("Here are some musical movies for you:\n");
        Console.WriteLine("The Lion King");
        Console.WriteLine("La La Land");
        Console.WriteLine("Les Misérables");
        break;

    case "horror":
        Console.WriteLine("Here are some horror movies for you:\n");
        Console.WriteLine("The Conjuring");
        Console.WriteLine("Evil Dead");
        Console.WriteLine("The Ring");
        break;

    default:
        Console.WriteLine("Genre not found or invalid");
        break;
}
