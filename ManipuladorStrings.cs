using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGirlsProject
{
    internal class ManipuladorStrings
    {
        public string InverterString(string valor)
        {
            return new string(valor.Reverse().ToArray());
        }
        public string GerarAbreviacaoDeNome(string nomeCompleto)
        {
            var nomes = nomeCompleto.Split(' ');
            var nomeAbreviado = string.Empty;
            foreach (var nome in nomes)
            {
                if (nome.Length <=2)
                {
                    nomeAbreviado += nome + " ";
                    continue;
                }
                nomeAbreviado += nome.FirstOrDefault().ToString() + " ";
            }

            return nomeAbreviado;
        }
        public void ContarVogaisEConsoantes(string valor)
        {
            var contadorConsoantes = 0;
            var contadorVogais = 0;
            var vogais = new char[] { 'a', 'e', 'i', 'o', 'u' };

            foreach (var charDeValor in valor)
            {
                var charDeValorMinusculo = charDeValor.ToString().ToLower().FirstOrDefault();
                if (charDeValorMinusculo == ' ')
                    continue;
                var isVogal = false;
                foreach (var vogal in vogais)
                {
                    if (charDeValorMinusculo == vogal)
                        isVogal = true;
                }
                if (isVogal)
                    contadorVogais++;
                else
                    contadorConsoantes++;
            }

            Console.WriteLine($"Contem {contadorConsoantes} consoantes e {contadorVogais} vogais.");
        }
    }
}
