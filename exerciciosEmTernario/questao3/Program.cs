
Console.WriteLine("Digite A Nota Do Aluno");

int nota = Convert.ToInt32(Console.ReadLine());
string aprovadoOuReprovado = (nota >= 6) ? "Aprovado" : "Reprovado";

Console.WriteLine($"O Aluno Foi: {aprovadoOuReprovado}");