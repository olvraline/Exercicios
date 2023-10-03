using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCarteiraDigital
{
    public class CarteiraDigital
    {
        public Cliente Pessoa { get; set; }
        public Banco Banco { get; set; }
        public Investimento Investimento { get; set; }
        public Endereco Endereco { get; set; }
        public Cidade Cidade { get; set; }
        public Pagamento Pagamento { get; set; }

        public CarteiraDigital(
            Cliente pessoa,
            Banco banco,
            Investimento investimento,
            Endereco endereco,
            Cidade cidade)
        {
            Pessoa = pessoa;
            Banco = banco;
            Investimento = investimento;
            Endereco = endereco;
            Cidade = cidade;
            Pagamento = new Pagamento();
        }
    }
}
