using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBasics
{
    public class Aviao : Veiculo
    {

        public int QtdTurbina;
        public string CompainhaAerea;
        public int Assentos;

        public void Decolar()
        {
            System.Console.WriteLine("Decolar vuuum-...");
        }
    }
}