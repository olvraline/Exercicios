
            Console.WriteLine("Calculadora Simples");
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escolha um operador (+, -, *, /): ");
            char operador = Console.ReadKey().KeyChar;
            Console.WriteLine();

            double resultado = 0.0;

            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Operador inválido.");
                    return;
            }

            Console.WriteLine($"Resultado: {resultado}");

