using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGirlsProject
{
    internal class Circulo : Forma
    {
        public override void CalcularArea()
        {
            var piParaCirculo = 3.14;
            Console.WriteLine("Digite o raio do circulo: ");
            var raio = Convert.ToDouble(Console.ReadLine());
            var raioAoQuadrado = raio * raio;

            var calculoDoCirculo = piParaCirculo * raioAoQuadrado;
            Console.WriteLine($"A dimensão do circulo é: {calculoDoCirculo}");
        }
    }
}
