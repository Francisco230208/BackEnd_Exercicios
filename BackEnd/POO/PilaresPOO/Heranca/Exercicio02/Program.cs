using Exercicio02;

Funcionario f1 = new Funcionario();
f1.Nome = "João";
f1.SalarioBase = 3000;

Gerente g1 = new Gerente();
    g1.Nome = "Fernanda";
    g1.SalarioBase = 5000;
   g1.Bonus = 2000;

  Console.WriteLine($"Funcionário: {f1.Nome}, Salário: R$ {f1.CalcularSalario()}");
            Console.WriteLine($"Gerente: {g1.Nome}, Salário com bônus: R$ {g1.CalcularSalario()}");