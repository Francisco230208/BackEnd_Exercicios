using Exemplos;

// Cachorro toto = new Cachorro();
// toto.Mover();
// toto.FazerSom();

// Gato xana = new Gato();
// xana.Mover();
// xana.FazerSom();


//2. Classe ContaBancaria
//Criei uma classe abstrata ContaBancaria com os métodos depositar (double valor) e sacar (doublr valor
//Criei duas classes: ContaCorrente e ContaPoupança, cada uma com sua prórpia forma, calcular o saldo
//Após saque (por exemplo, taxa diferente)

 ContaCorrente cc = new ContaCorrente();
            cc.Depositar(500);
            cc.Sacar(100);

            Console.WriteLine();

            ContaPoupanca cp = new ContaPoupanca();
            cp.Depositar(1000);
            cp.Sacar(200);
            cp.CalcularRendimento();

            Console.ReadLine();