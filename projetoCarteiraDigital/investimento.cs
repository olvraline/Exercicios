using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCarteiraDigital
{


    public class Investimento
    {
        public decimal BolsaDeValores { get; set; }
        public decimal TesouroDireto { get; set; }
        public decimal CDB { get; set; }

        public Investimento(decimal bolsaDeValores, decimal tesouroDireto, decimal cdb)
        {
            BolsaDeValores = bolsaDeValores;
            TesouroDireto = tesouroDireto;
            CDB = cdb;
        }
        public decimal CalcularValorTotal()
        {
            return BolsaDeValores + TesouroDireto + CDB;
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Investimento em Bolsa de Valores: R${BolsaDeValores}");
            Console.WriteLine($"Investimento em Tesouro Direto: R${TesouroDireto}");
            Console.WriteLine($"Investimento em CDB: R${CDB}");
            Console.WriteLine($"Valor Total do Investimento: R${CalcularValorTotal()}");
        }
    }
}
