
namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float SaldoInicial)
        {
            if (SaldoInicial > 0)
            {
               Saldo = SaldoInicial;
            }
        }
        //Método que seta/configura/guarda o saldo
        public void Depositar(float valor)
        {
            if (valor >= 0)
            {
                            Saldo = valor;
                            return;

            }
            System.Console.WriteLine("Valor para depósito inválido");
        }

        //Método publico que retorna o saldo
        public float GetSaldo()
        {
            return Saldo;
        }


       public void Sacar(float valor)
        {
            if (valor <= Saldo)
            {
                System.Console.WriteLine("Saque realizado com sucesso");
            }

            else
            {
                System.Console.WriteLine("Saldo indisponível");
            }
            
            Saldo -= valor;
        }
    }
}