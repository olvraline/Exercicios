Console.WriteLine("Digite sua idade");
double idade = Convert.ToDouble(Console.ReadLine());

string classificarIdade = (idade <= 12) ? "Criança" : (idade >= 13 && idade <= 19) ? "Adolescente" : "Adulto";
Console.WriteLine($"Você é: {classificarIdade}");