using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCarteiraDigital
{
    public class Pagamento
    {
        public void PagarComPix(decimal valor)
        {
            Console.WriteLine($"Pagamento via Pix no valor de R${valor} realizado com sucesso.");
        }

        public void PagarComTransferencia(decimal valor)
        {
            Console.WriteLine($"Pagamento via transferência bancária no valor de R${valor} realizado com sucesso.");
        }

        public void PagarComBoleto(decimal valor)
        {
            Console.WriteLine($"Pagamento via boleto no valor de R${valor} realizado com sucesso.");
        }
    }
}