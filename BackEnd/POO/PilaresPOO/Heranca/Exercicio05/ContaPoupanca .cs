using SistemaBancario;

public class ContaPoupanca : Conta
    {
        public void CalcularRendimento()
        {
            double rendimento = Saldo * 0.02; // 2% de rendimento
            Saldo += rendimento;
            Console.WriteLine($"Rendimento de 2% aplicado: +R$ {rendimento:F2}");
        }
    }