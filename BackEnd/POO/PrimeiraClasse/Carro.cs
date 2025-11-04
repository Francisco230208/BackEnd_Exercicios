using System.Reflection.PortableExecutable;

namespace PrimeiraClasse
{
    public class Carro
    {
        //propriedades
        public int qtdRodas;
        public int qtdPortas;
        public string marca = "";
        public string modelo = "";
        public string cor = "";

        //Métodos
        public void Acelerar()
        {
            System.Console.WriteLine($"Carro acelerando");
        }
        public void Frear()
        {
            System.Console.WriteLine($"Carro freando");
        }
        public void Ligar()
        {
            System.Console.WriteLine($"Carro Ligando");
        }
          public void Desligar()
        {
            System.Console.WriteLine($"Carro desligando");
        }
    }
    
}