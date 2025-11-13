using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Moto : Veiculo
    {
         public string TipoCapacete { get; set; }

        public override void MostrarInfo()
        {
            Console.WriteLine("=== Informações da Moto ===");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Tipo de Capacete: {TipoCapacete}");
            Console.WriteLine();
        }
    }
}