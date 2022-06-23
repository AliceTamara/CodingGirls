using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGirlsProject
{
    internal class Trapezio : Forma
    {
        public override void CalcularArea()
        {
            Console.WriteLine("Digite a medida da base maior: ");
            var baseMaior = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a medida da base menor: ");
            var baseMenor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a medida da altura: ");
            var altura = Convert.ToDouble(Console.ReadLine());

            var areaTrapezio = (baseMaior + baseMenor) * altura / 2;

            Console.WriteLine($"A dimensão do seu trapézio é: {areaTrapezio}");
        }
    }
}
