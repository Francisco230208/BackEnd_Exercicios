
namespace Exemplos
{
   public abstract class ContaBancaria
    {
        public string NumeroConta { get; set; }
        public double Saldo { get; protected set; }

        public virtual void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor} realizado. Novo saldo: R${Saldo}");
        }

             public abstract void Sacar(double valor);
    }
}