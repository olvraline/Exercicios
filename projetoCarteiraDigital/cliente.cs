using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace projetoCarteiraDigital
{
    using System;

    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }

        public Cliente(string nome, int idade, string cpf)
        {
            Nome = nome;
            Idade = idade;
            CPF = cpf;
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"CPF: {CPF}");
        }
    }
}

