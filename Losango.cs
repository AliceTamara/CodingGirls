using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGirlsProject
{
    internal class Losango : Forma
    {
        public override void CalcularArea()
        {
            Console.WriteLine("Digite a medida da diagonal maior: ");
            var medidaDiagonalMaior = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a medida da diagonal menor: ");
            var medidaDiagonalMenor = Convert.ToDouble(Console.ReadLine());

            var areaLosango = medidaDiagonalMaior * medidaDiagonalMenor / 2;

            Console.WriteLine($"A dimensão do seu losango é: {areaLosango}");
        }
    }
}
