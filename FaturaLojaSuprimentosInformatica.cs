using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGirlsProject
{
    internal class FaturaLojaSuprimentosInformatica
    {
        public int Numero { get; set; }
        public string DescricaoProdutos { get; set; }
        public int QuantidadeComprada { get; set; }
        public double Preco { get; set; }

        public FaturaLojaSuprimentosInformatica(int numero, string descricaoProdutos, int quantidadeComprada, double preco)
        {
            Numero = numero;
            DescricaoProdutos = descricaoProdutos;
            QuantidadeComprada = quantidadeComprada;
            Preco = preco;
        }
        public double CalcularTotalDaFatura()
        {
            return QuantidadeComprada * Preco;
        }
    }
}
