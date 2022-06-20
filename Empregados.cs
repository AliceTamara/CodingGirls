using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGirlsProject
{
    internal class Empregados
    {
        public string Nome { get; set; }

        public Empregados(string nome)
        {
            Nome = nome;
            Console.WriteLine(nome);
        }

        public string Cargo { get; set; }

        public double SalarioMensal { get; set; }

        public double AumentarSalario(double salarioComAumento)
        {
            if (SalarioMensal <= 0)
                salarioComAumento = 0.0;
            else if (SalarioMensal <= 400.00)
                salarioComAumento = SalarioMensal * 1.5 + SalarioMensal;
            else if (SalarioMensal <= 800.00)
                salarioComAumento = SalarioMensal * 1.2 + SalarioMensal;
            else if (SalarioMensal <= 1200.00)
                salarioComAumento = SalarioMensal * 1.0 + SalarioMensal;
            else if (SalarioMensal <= 2000.00)
                salarioComAumento = SalarioMensal * 0.07 + SalarioMensal;
            else
                salarioComAumento = SalarioMensal * 0.04 + SalarioMensal;
            return salarioComAumento;
        }
    }
    
}
