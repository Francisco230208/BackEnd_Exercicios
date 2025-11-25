using Encapsulamento;

// float Dinheiro = 200;

// ContaBancaria contaHugo = new ContaBancaria();
// ContaBancaria contaEdu = new ContaBancaria(Dinheiro);

// System.Console.WriteLine($"Saldo da conta: {contaHugo}");
// System.Console.WriteLine($"Saldo da conta: {contaEdu}");

// contaHugo.Depositar(Dinheiro);
// contaEdu.Depositar(Dinheiro);

// contaEdu.Sacar(50);
// System.Console.WriteLine($"Novo saldo da conta do Hugo: R${contaHugo.GetSaldo()}");
// System.Console.WriteLine($"Novo saldo da conta do Edu: R${contaEdu.GetSaldo()}");


Carro meuCarro = new Carro();

meuCarro.DefinirMarca("Toyota");
meuCarro.DefinirModelo("Corolla");

meuCarro.Acelerar(50);
meuCarro.Frear(30); // aqui deve zerar a velocidade

Console.WriteLine("Marca: " + meuCarro.ObterMarca());
Console.WriteLine("Modelo: " + meuCarro.ObterModelo());
Console.WriteLine("Velocidade Atual: " + meuCarro.ObterVelocidade() + " km/h");