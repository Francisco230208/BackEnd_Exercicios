
namespace Exercicio2
{
    public class Contrato : IImprimivel
    {
        public Contrato(String contratante, string contratada, string txtClausulas)
        {
            Contratante = contratante;
            PrestadorServico = contratada;
            TextoClausulas = txtClausulas;
        }
        public string Contratante;
        public string PrestadorServico = "";
        public string TextoClausulas = "";
        public void Imprimir()
        {
           System.Console.WriteLine($@"
           Partes:
           Contratante: {Contratante}
           Contratada: {PrestadorServico}
           Clausulas do contrato:

           {TextoClausulas}");
        }
    }
}