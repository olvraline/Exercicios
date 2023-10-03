using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCarteiraDigital
{


    public class Estado
    {
        public string Nome { get; set; }

        public Estado(string nome)
        {
            Nome = nome;
        }
    }

    public class Cidade
    {
        public string Nome { get; set; }
        public Estado Estado { get; set; }

        public Cidade(string nome, Estado estado)
        {
            Nome = nome;
            Estado = estado;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Cidade: {Nome}, Estado: {Estado.Nome}");
        }
    }
}