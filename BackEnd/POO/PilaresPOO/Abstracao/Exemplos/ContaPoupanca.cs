using Exemplos;

public class ContaPoupanca : ContaBancaria
    {
        private double TAXA_SAQUE = 1.00;
        private double RENDIMENTO = 0.02; 

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
                Console.WriteLine("Saldo insuficiente para saque na conta poupança.");
            }
        }

        public void CalcularRendimento()
        {
            double ganho = Saldo * RENDIMENTO;
            Saldo += ganho;
            Console.WriteLine($"Rendimento de 2% aplicado. Saldo atual: R${Saldo}");
        }
         
    }