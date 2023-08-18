
Console.WriteLine("Digite o comprimento do primeiro lado:");
double lado1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o comprimento do segundo lado:");
double lado2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o comprimento do terceiro lado:");
double lado3 = Convert.ToDouble(Console.ReadLine());

if (lado1 + lado2 > lado3)
 {
 Console.WriteLine("Os comprimentos podem formar um triângulo.");
 }

else
 {
 Console.WriteLine("Os comprimentos NÃO podem formar um triângulo.");
 }
