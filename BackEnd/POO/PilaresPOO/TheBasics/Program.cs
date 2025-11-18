using TheBasics;

Console.Clear();

// using TheBasics;
// //array/Lista de pessoas
// List<Pessoa> peoples = new List<Pessoa>();

// //HUGO==================================
// //endereco
// Endereco enderecoHugo = new Endereco();
// enderecoHugo.Logradouro = "Rua Niterói";

// //Pessoa com endereco
// Pessoa hugo = new Pessoa(enderecoHugo);
// hugo.Nome = "Francisco Hugo";
// hugo.Idade = 17;
// //HUGO=====================================

// // Pessoa hugo = new Pessoa();
// // Pessoa alexia = new Pessoa();
// // Pessoa henrique = new Pessoa();
// // Pessoa laura = new Pessoa();

// hugo.falar();
// //=============ALEXIA====================================
// Endereco endAlexia = new Endereco();
// endAlexia.Logradouro = "Rua aleatória";
// //endereco
// Pessoa alexia = new Pessoa(endAlexia);
// alexia.Nome = "Alexia Mariano";
// alexia.Idade = 23;

// alexia.falar();
// //=============ALEXIA====================================

// //guardando os dados na lista

// peoples.Add(hugo);
// peoples.Add(alexia);


// foreach (var p in peoples)
// {
//     System.Console.WriteLine($"Nome: {p.Nome}");
// }

// Endereco endEnzo = new Endereco();
// endEnzo.Logradouro = "Spínola Teixeira";
// Aluno pedroEnzo = new Aluno(endEnzo);
// pedroEnzo.curso = "Desenvolvimento de Sistema";
// pedroEnzo.RA = "1234-XPTO";
// pedroEnzo.NotaFinal = 9.75f;

// Endereco endProfAlex = new Endereco();
// endProfAlex.Logradouro = "Rua lalala";
// endEnzo.Numero = 987;

// Professor profAlexia = new Professor(endProfAlex);
// profAlexia.Nome = "Alexia Vitória";

// System.Console.WriteLine($"{pedroEnzo} estuda na turma {pedroEnzo.curso} da {profAlexia.Nome}");


Carro c1 = new Carro();
c1.Marca = "Ferrari";
c1.Modelo = "911";

System.Console.WriteLine("Espcificações do carro");
System.Console.WriteLine("========================");
System.Console.WriteLine($"Marca: {c1.Marca}");
System.Console.WriteLine($"Modelo: {c1.Modelo}");
//=========================================================
System.Console.WriteLine("Espcificações da moto");
System.Console.WriteLine("========================");
Moto m2 = new Moto();
m2.Marca = "Honda";
m2.Modelo = "160";

System.Console.WriteLine($"Marca: {m2.Marca}");
System.Console.WriteLine($"Modelo: {m2.Modelo}");
//=========================================================
System.Console.WriteLine("Espcificações do avião");
System.Console.WriteLine("========================");
Aviao a1 = new Aviao();
a1.QtdTurbina = 2;
a1.CompainhaAerea = "GOL";
a1.Assentos = 300;

System.Console.WriteLine($"Quantidade de assentos: {a1.Assentos}");
System.Console.WriteLine($"Compainha: {a1.CompainhaAerea}");
System.Console.WriteLine($"Quantidade de turbina: {a1.QtdTurbina}");
//=========================================================


c1.AbrirPortaMala();
c1.ligar();
m2.ligar();
c1.Desligar();
m2.Desligar();
m2.Empinar();
a1.Decolar();