using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Animal 
    {
    
        // Método virtual pode ser sobrescrito nas classes filhas
        public virtual void FazerSom()
        {
            Console.WriteLine("O animal faz um som...");
        }
    
    }
}