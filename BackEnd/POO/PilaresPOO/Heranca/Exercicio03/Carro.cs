using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Carro : Veiculo
    {
        
        public int NumeroPortas { get; set; }

        public override void MostrarInfo()
        {
            Console.WriteLine("=== Informações do Carro ===");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Número de Portas: {NumeroPortas}");
            Console.WriteLine();
        }
    }
}