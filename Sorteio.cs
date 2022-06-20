using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGirlsProject
{
    internal class Sorteio
    {
        private int _random = new Random().Next(0, 1000);

        public bool AdivinharNumero(int numero)
        {
            if (numero < _random)
            {
                Console.WriteLine("O numero é maior");
                return false;
            }
            else if (numero > _random)
            {
                Console.WriteLine("O numero é menor");
                return false;
            }
            else
            {
                Console.WriteLine("Acertou!!!");
                return true;
            }
        }
    }
}
