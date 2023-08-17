// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite seu nome");
string nome = Console.ReadLine();

Console.WriteLine("Digite sua idade");
int idade = int.Parse(Console.ReadLine());

if (idade <=12)
{
    Console.WriteLine($"Bem vindo, {nome}");
}
else if (idade >=13  && idade <= 19)
{
    Console.WriteLine($"Olá,{nome}");
}
else
{
    Console.WriteLine($"Olá Sr./Sra. {nome}");
}
