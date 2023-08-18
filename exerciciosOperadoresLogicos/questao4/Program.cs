
            Console.WriteLine("Digite o saldo da conta:");
            double saldoConta = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor que deseja sacar:");
            double valorSaque = double.Parse(Console.ReadLine());

            if (saldoConta >= valorSaque)
            {
                saldoConta -= valorSaque;
                Console.WriteLine("Saque autorizado. Novo saldo: " + saldoConta);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
