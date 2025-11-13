using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio04
{
    public class Pessoa
    {
                public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
        }

    }
}