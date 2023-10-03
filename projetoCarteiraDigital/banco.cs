using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace projetoCarteiraDigital
{

    public class Banco

    {
        public string Agencia { get; set; }

        public string Conta { get; set; }

        public Banco(string agencia, string conta)

        {

            Agencia = agencia;

            Conta = conta;

        }

        public void ExibirInformacoes()

        {

            Console.WriteLine($"Agência: {Agencia}");

            Console.WriteLine($"Conta: {Conta}");

        }

    }
}
