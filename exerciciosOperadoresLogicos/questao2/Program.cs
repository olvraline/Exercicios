
            Console.WriteLine("Deseja um café? (sim/não):");
            string respostaCafe = Console.ReadLine().ToLower();

            if (respostaCafe == "sim")
            {
                Console.WriteLine("Deseja açúcar? (sim/não):");
                string respostaAcucar = Console.ReadLine().ToLower();

                if (respostaAcucar == "sim")
                {
                    Console.WriteLine("Aqui está o seu café com açúcar.");
                }
                else
                {
                    Console.WriteLine("Aqui está o seu café preto.");
                }
            }
            else
            {
                Console.WriteLine("Ok, sem problemas. Tenha um bom dia!");
            }
