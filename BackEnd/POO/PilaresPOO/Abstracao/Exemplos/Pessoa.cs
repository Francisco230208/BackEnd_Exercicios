
using System.Xml;

namespace Exemplos
{
    public class Pessoa : Animal
    {
        public override void FazerSom()
        {
           System.Console.WriteLine("Olá");
        }

        public override void Mover()
        {
            System.Console.WriteLine("Andando..");
        }
    }
}


