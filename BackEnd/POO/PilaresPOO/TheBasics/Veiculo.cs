
namespace TheBasics
{
    public class Veiculo
    {
        public string Modelo;
        public string Marca;

        public void ligar()
        {
            System.Console.WriteLine($"Ligando veículo");
        }

        public void Desligar()
        {
            System.Console.WriteLine($"Veículo desligado");
        }
        
        public void Decolar()
        {
             System.Console.WriteLine("Decolar vuuum-...");
        }
    }
}