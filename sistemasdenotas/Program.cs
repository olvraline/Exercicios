// Desenvolva um programa que pede as notas de um aluno e determina se ele passou em uma disciplina.
// O aluno é aprovado se sua nota for maior ou igual a 7.0 E ele não tiver faltado mais de 15% das aulas.

Console.WriteLine("Digite a quantidade total de aulas: ");
int totalAulas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de faltas do aluno: ");
int faltas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a nota do aluno: ");
double nota = Convert.ToDouble(Console.ReadLine());

double limiteFaltas = totalAulas * 0.15; // 15% das aulas
double percentualFaltas = (double)faltas / totalAulas * 100;

if (nota >= 7.0 && percentualFaltas <= 15.0)
{
    Console.WriteLine("Aluno aprovado!");
}
else
{
    Console.WriteLine("Aluno reprovado.");
}