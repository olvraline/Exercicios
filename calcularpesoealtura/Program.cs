// See https://aka.ms/new-console-template for more information
using System.Reflection.PortableExecutable;

Console.WriteLine("informe seu peso");
double peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe sua altura");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = peso / (altura * altura);

if (imc < 18.5)
{
    Console.WriteLine("Voce está abaixo do peso");
}
else if (imc == 18.6)
{
    Console.WriteLine("Seu peso está normal");
}
else
{
    Console.WriteLine("Voce está com sobrepeso");
}
