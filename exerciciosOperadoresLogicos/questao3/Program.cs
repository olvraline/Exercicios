            Console.WriteLine("Digite o primeiro número:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            int numero3 = int.Parse(Console.ReadLine());

            if (numero1 == numero2 || numero1 == numero3 || numero2 == numero3)
            {
                Console.WriteLine("Pelo menos dois números são iguais.");
            }
            else
            {
                Console.WriteLine("Nenhum dos números é igual aos outros.");
            }