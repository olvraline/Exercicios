using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace projetoCarteiraDigital
{

public class Endereco

{


    public string Rua { get; set; }

    public string CEP { get; set; }

    public string Complemento { get; set; }

    public int Numero { get; set; }


    public Endereco(string rua, string cep, string complemento, int numero)

    {

        Rua = rua;

        CEP = cep;

        Complemento = complemento;

        Numero = numero;

    }

    public void ExibirInformacoes()

    {

        Console.WriteLine($"Rua: {Rua}");

        Console.WriteLine($"CEP: {CEP}");

        Console.WriteLine($"Complemento: {Complemento}");

        Console.WriteLine($"Número: {Numero}");

    }

}
}
