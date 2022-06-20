using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGirlsProject
{
    public class Empregados
    {
        public string Nome { get; private set; }
        public string Cargo { get; private set; }
        public double SalarioMensal { get; private set; }

        public Empregados(string nome, string cargo, double salarioMensal)
        {
            Nome = nome;
            Cargo = cargo;
            SalarioMensal = salarioMensal;
        }

        public void ZerarSalarioQuandoNegativo()
        {
            if (SalarioMensal < 0)
            {
                SalarioMensal = 0;
            }
        }
        public void AumentarSalario()
        {
            if (SalarioMensal <= 400.00 && SalarioMensal > 0)
                SalarioMensal = SalarioMensal * 1.15;
            else if (SalarioMensal <= 800.00)
                SalarioMensal = SalarioMensal * 1.12;
            else if (SalarioMensal <= 1200.00)
                SalarioMensal = SalarioMensal * 1.1;
            else if (SalarioMensal <= 2000.00)
                SalarioMensal = SalarioMensal * 0.07;
            else
                SalarioMensal = SalarioMensal * 0.04;
        }
    }
}