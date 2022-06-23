using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGirlsProject
{
    internal class Triangulo : Forma
    {
        public override void CalcularArea()
        {
            Console.WriteLine("Digite a medida da base: ");
            var baseTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a medida da altura: ");
            var alturaTriangulo = Convert.ToDouble(Console.ReadLine());
            var calculoTriangulo = baseTriangulo * alturaTriangulo / 2;

            Console.WriteLine("A dimensão do seu triangulo é: ");
            Console.WriteLine(calculoTriangulo);
        }
    }
}
