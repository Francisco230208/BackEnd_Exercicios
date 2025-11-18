using Exemplos;

public class ContaCorrente : ContaBancaria
    {
        private const double TAXA_SAQUE = 2.50; 

        public override void Sacar(double valor)
        {
            double total = valor + TAXA_SAQUE;

            if (Saldo >= total)
            {
                Saldo -= total;
                Console.WriteLine($"Saque de R${valor} realizado com taxa de R${TAXA_SAQUE}. Saldo atual: R${Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque na conta corrente.");
            }
        }
    }