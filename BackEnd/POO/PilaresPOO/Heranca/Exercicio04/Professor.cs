using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio04
{
    public class Professor : Pessoa
    {
           public string Disciplina { get; set; }

        public override void MostrarInfo()
        {
            Console.WriteLine("=== Informações do Professor ===");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Disciplina: {Disciplina}");
            Console.WriteLine();
        }
    }
}