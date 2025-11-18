using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Gato : Animal
    {
        public override void FazerSom()
        {
            System.Console.WriteLine("Miau, Miau");
        } 

        public override void Mover()
        {
            System.Console.WriteLine("plack, plack");
        } 

    }
}