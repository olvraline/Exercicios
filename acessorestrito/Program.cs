// See https://aka.ms/new-console-template for more information

String usuarioCorreto = "admin";
String senhaCorreta = "123";

Console.WriteLine("Digite o usuário");
String nomeUsuario = Console.ReadLine();

Console.WriteLine("Digite a senha");
String  senha= Console.ReadLine();

if (nomeUsuario == nomeUsuario && senha == senhaCorreta)
{
    Console.WriteLine("Bem vindo");
}
else
{
    Console.WriteLine("Usuário ou senha incorreta, acesso negado.");
}