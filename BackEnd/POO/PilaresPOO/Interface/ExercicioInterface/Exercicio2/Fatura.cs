
namespace Exercicio2
{
    public class Fatura : IImprimivel
    {
        public string Devedor = "";
        public string Credor = "";

        public float valor = 0;

        public int DiasDeAtraso = 0;

        private float Juros = 0.10f;


        public Fatura (string dev, string cred, float valfat, int qtdAtraso)
        {
            Devedor = dev;
            Credor  = cred;
            DiasDeAtraso = qtdAtraso;
            valor = valfat;
        }
        public void Imprimir()
        {
            //Calcular juros antes 

            System.Console.WriteLine($@"
Credor:{Credor}
Devedo:{Devedor}
Dias de atraso: {DiasDeAtraso} dia(s)
valor:{valor:F2}
juros: {(Juros * DiasDeAtraso):F2}
Total com juros: R${valor:F2}

            ");
           
        }

        public void CalcularDivida()
        {
            if (DiasDeAtraso > 0)
            {
                valor = valor + DiasDeAtraso * Juros;
            }

            if (DiasDeAtraso >= 5)
            {
                System.Console.WriteLine("Divida encaminhada para o SERASA");
            }
        }
    }
}