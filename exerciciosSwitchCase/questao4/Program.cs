
            Console.WriteLine("Digite um número de 1 a 12 para representar um mês:");
            int numeroMes = Convert.ToInt32(Console.ReadLine());

            switch (numeroMes)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;

                case 2:
                    Console.WriteLine("Fevereiro");
                    break;

                case 3:
                    Console.WriteLine("Março");
                    break;

                case 4:
                    Console.WriteLine("Abril");
                    break;

                case 5:
                    Console.WriteLine("Maio");
                    break;

                case 6:
                    Console.WriteLine("Junho");
                    break;

                case 7:
                    Console.WriteLine("Julho");
                    break;

                case 8:
                    Console.WriteLine("Agosto");
                    break;

                case 9:
                    Console.WriteLine("Setembro");
                    break;

                case 10:
                    Console.WriteLine("Outubro");
                    break;

                case 11:
                    Console.WriteLine("Novembro");
                    break;

                case 12:
                    Console.WriteLine("Dezembro");
                    break;

                default:
                    Console.WriteLine("Número inválido. Digite um número de 1 a 12.");
                    break;
            }
