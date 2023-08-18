
            Console.WriteLine("Conversor de Unidades");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Converter de metros para centímetros");
            Console.WriteLine("2 - Converter de centímetros para metros");

            char opcao = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (opcao)
            {
                case '1':
                    Console.Write("Digite a quantidade em metros: ");
                    double metros = Convert.ToDouble(Console.ReadLine());
                    double centimetros = metros * 100;
                    Console.WriteLine($"{metros} metros equivalem a {centimetros} centímetros.");
                    break;

                case '2':
                    Console.Write("Digite a quantidade em centímetros: ");
                    double centimetrosInput = Convert.ToDouble(Console.ReadLine());
                    double metrosConvertidos = centimetrosInput / 100;
                    Console.WriteLine($"{centimetrosInput} centímetros equivalem a {metrosConvertidos} metros.");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
