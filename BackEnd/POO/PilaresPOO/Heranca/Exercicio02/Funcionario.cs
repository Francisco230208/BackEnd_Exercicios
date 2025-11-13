using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Funcionario
    {
            public string Nome { get; set; }
        public double SalarioBase { get; set; }

        // Método virtual que pode ser sobrescrito
        public virtual double CalcularSalario()
        {
            return SalarioBase;
        }   
    }
}