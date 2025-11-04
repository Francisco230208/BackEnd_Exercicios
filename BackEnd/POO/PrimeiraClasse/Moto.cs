
namespace PrimeiraClasse
{
    public class Moto
    {
        //propriedades
        public int qtdRodas;
        public string marca = "";
        public string modelo = "";
        public string cor = "";


        
        //Métodos
        public void Acelerar()
        {
            System.Console.WriteLine($"Moto acelerando");
        }
        public void Frear()
        {
            System.Console.WriteLine($"Moto freando");
        }
        public void Ligar()
        {
            System.Console.WriteLine($"Moto Ligando");
        }
          public void Desligar()
        {
            System.Console.WriteLine($"Moto desligando");
        }
    }
    
}