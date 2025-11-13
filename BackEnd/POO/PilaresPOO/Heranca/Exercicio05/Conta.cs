namespace SistemaBancario
{
    // Classe base
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor} realizado com sucesso!");
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque!");
            }
        }
    }
}