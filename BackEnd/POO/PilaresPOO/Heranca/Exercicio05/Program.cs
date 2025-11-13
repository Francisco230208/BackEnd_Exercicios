ContaPoupanca conta1 = new ContaPoupanca();

conta1.Numero = 1234;

            Console.WriteLine($"Número da conta: {conta1.Numero}");
            Console.WriteLine($"Saldo inicial: R$ {conta1.Saldo:F2}");

            conta1.Depositar(1000);
            Console.WriteLine($"Saldo após depósito: R$ {conta1.Saldo:F2}");

            conta1.CalcularRendimento();
            Console.WriteLine($"Saldo após rendimento: R$ {conta1.Saldo:F2}");
