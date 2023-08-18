            Console.WriteLine("Digite o valor total da compra:");
            double valorTotal = Convert.ToDouble(Console.ReadLine());

            if (valorTotal >= 100)
            {
                double desconto = valorTotal * 0.1; // 10% de desconto
                double valorComDesconto = valorTotal - desconto;

                Console.WriteLine($"Desconto de 10% aplicado!");
                Console.WriteLine($"Valor com desconto: R${valorComDesconto:F2}");
            }
            else
            {
                Console.WriteLine("Valor total da compra abaixo de R$100. Sem desconto aplicado.");
            }