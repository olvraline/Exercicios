Console.WriteLine("Digite Um Número");
double numero = Convert.ToDouble(Console.ReadLine());

string verificarPariedade = (numero % 2 == 0) ? "Par" : "Impar";
Console.WriteLine($"O numero é: {verificarPariedade}");