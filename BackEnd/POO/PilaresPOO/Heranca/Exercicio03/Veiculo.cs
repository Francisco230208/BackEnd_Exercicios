using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Veiculo
    {
          public string Marca { get; set; }
        public string Modelo { get; set; }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
        }
    }
}