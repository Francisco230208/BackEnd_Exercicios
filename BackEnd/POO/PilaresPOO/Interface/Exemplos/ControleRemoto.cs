
namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        public int NivelVolume = 99;
        public int VolumeMaximo = 100;
         
      
        public void AumentarVolume()
        {
            if (NivelVolume < VolumeMaximo)
            {
            NivelVolume++;
            System.Console.WriteLine($"Nível atual do volume: {NivelVolume}");        
            }
            else
            { 
            System.Console.WriteLine($"O volume ja atingiu o v[ivel m[aximo]] {NivelVolume}");        
            }
        }

        public void Desligar()
        {
            System.Console.WriteLine($"Desligando a tv....");
        }

        public void DiminuirVolume()
        {
            if (NivelVolume == 0)
            {
                System.Console.WriteLine($"O volume já está no mínimo {NivelVolume}");
            }
            else
            {
                NivelVolume--;
                System.Console.WriteLine($"Volume atual: {NivelVolume}");
            }
        }

        public void Ligar()
        {
            System.Console.WriteLine($"Ligando a TV...");
        }
    }
}