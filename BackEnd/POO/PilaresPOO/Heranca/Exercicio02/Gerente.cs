using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Gerente : Funcionario
    {
                public double Bonus { get; set; }

        // Sobrescreve o método CalcularSalario
        public override double CalcularSalario()
        {
            return SalarioBase + Bonus;
        }

    }
}