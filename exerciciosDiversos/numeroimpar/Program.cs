Console.WriteLine("Digite um número:");
int number = int.Parse(Console.ReadLine());

if (number > 0 && number % 2 != 0)
{
    Console.WriteLine("O número é positivo e ímpar.");
}
else
{
    Console.WriteLine("O número não é positivo e ímpar.");
}