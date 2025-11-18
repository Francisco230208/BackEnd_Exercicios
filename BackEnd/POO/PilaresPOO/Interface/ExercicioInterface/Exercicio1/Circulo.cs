
namespace Exercicio1
{    
  public class Circulo : Iforma
{
   public float Raio;

   private float PI = 3.14f;
    public void CalcularArea()
    {
     
        System.Console.WriteLine($"A area do ciruclo é {PI * Raio * Raio}");
    }

    }
} 