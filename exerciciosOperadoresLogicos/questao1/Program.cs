
            Console.WriteLine("Digite um número:");
            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("O número digitado é positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O número digitado é negativo.");
            }
            else
            {
                Console.WriteLine("O número digitado é zero.");
            }