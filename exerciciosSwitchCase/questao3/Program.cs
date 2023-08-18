
            Console.WriteLine("Escolha um idioma:");
            Console.WriteLine("1 - Inglês");
            Console.WriteLine("2 - Espanhol");
            Console.WriteLine("3 - Francês");

            char escolha = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (escolha)
            {
                case '1':
                    Console.WriteLine("Welcome!");
                    break;

                case '2':
                    Console.WriteLine("¡Bienvenido!");
                    break;

                case '3':
                    Console.WriteLine("Bienvenue !");
                    break;

                default:
                    Console.WriteLine("Idioma inválido.");
                    break;
            }
