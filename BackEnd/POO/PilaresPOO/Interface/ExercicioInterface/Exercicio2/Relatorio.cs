
namespace Exercicio2
{
    public class Relatorio : IImprimivel
    {
        public string Nome;
        public string textoAleatorio = "";

        public Relatorio(string responsavel, string txtRelatorio)
        {
            Nome = responsavel;
            textoAleatorio = txtRelatorio;
        }

        public void Imprimir()
        {
            System.Console.WriteLine($"Responsável: {Nome}"); ;
            System.Console.WriteLine($"{textoAleatorio}");
        }
    }
}