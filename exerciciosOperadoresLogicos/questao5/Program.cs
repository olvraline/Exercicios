
            Console.WriteLine("Digite sua identificação:");
            string identificacao = Console.ReadLine();

            Console.WriteLine("Digite a hora de entrada (formato 24h, por exemplo, 14 para 14:00):");
            int horaEntrada = int.Parse(Console.ReadLine());

            if (identificacao == "12345" && horaEntrada >= 9 && horaEntrada <= 18)
            {
                Console.WriteLine("Acesso autorizado.");
            }
            else
            {
                Console.WriteLine("Acesso negado.");
            }
