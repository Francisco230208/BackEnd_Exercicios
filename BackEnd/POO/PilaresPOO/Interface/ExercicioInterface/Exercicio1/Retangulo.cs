
namespace Exercicio1
{
   public class Retangulo : Iforma
{
 
    public void CalcularArea()
    {
       System.Console.WriteLine($"A area do retangulo é {Altura * Largura}");
    }
        
        public double Largura;
        public double Altura;
    }
}