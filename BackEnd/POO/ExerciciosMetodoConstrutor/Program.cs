using ExerciciosMetodoConstrutor;
using MetodoConstrutor;
//========================================================
// Carro c1 = new Carro();
// Carro c2 = new Carro("Toyota");
// Carro c3 = new Carro("Fiat", "Uno");
// Carro c4 = new Carro("Chevrolet", "Onix", 2022);

// Console.WriteLine("=== Dados dos carros ===");
// c1.ExibirDados();
// c2.ExibirDados();
// c3.ExibirDados();
// c4.ExibirDados();
//========================================================


//=========================================================
// System.Console.WriteLine("Digite seu nome");
// string nome = Console.ReadLine();

// System.Console.WriteLine("Digite sua nota");
// int nota = int.Parse(Console.ReadLine());

// ClasseAluno c1 = new ClasseAluno();
// ClasseAluno c2 = new ClasseAluno(nome, nota);
// ClasseAluno c3 = new ClasseAluno("Ana", 8);
// ClasseAluno c4 = new ClasseAluno("Carlos", 10);

// Console.WriteLine();
// Console.WriteLine("=== Dados dos alunos ===");
// c1.ExibirDados();
// c2.ExibirDados();
// c3.ExibirDados();
// c4.ExibirDados();
//=========================================================
//=========================================================
// Produto p1 = new Produto("ARato loko", 150, 120);
// p1.ExibirDados();
// System.Console.WriteLine();
//=========================================================

MediaAluno a1 = new MediaAluno(6, 7, 2);

a1.nome = "Lucas";
a1.media();

MediaAluno a2 = new MediaAluno();
a2.nome = "Samuel";
a2.media();