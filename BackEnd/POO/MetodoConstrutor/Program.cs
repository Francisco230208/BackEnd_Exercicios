using MetodoConstrutor;

//Fontes é uma variável do tipo Pessoa
// Pessoa fontes = new Pessoa("João", 17);

// //  fontes.Nome =  "Lorenzo";
// //  fontes.Idade = 20;

// System.Console.WriteLine(@$"O objeto pessoa que criei é o {fontes.Nome}
// com a idade {fontes.Idade}");

// //fontes.Nome = "Gustavo Oliveira";

// //System.Console.WriteLine($"{fontes.Nome}");

// fontes.ExibirDados();
// // System.Console.WriteLine($"{fontes.Nome}");

//Método construtor da class Pessoa3Sobrecargas
Pessoa3Sobrecarga PrimeiraPessoa = new Pessoa3Sobrecarga();

//Método construtor da class Pessoa3Sobrecargas
Pessoa3Sobrecarga SegundaPessoa = new Pessoa3Sobrecarga("Matheus Felix");

Pessoa3Sobrecarga TerceiraPessoa = new Pessoa3Sobrecarga("Felipe Silva", 16);
//Método construtor da class Pessoa3Sobrecargas

System.Console.WriteLine(@$"Primeira pessoa cadastrada: 
                            Nome:{PrimeiraPessoa.Nome}
                            Idade:{PrimeiraPessoa.Idade}
                            
");


System.Console.WriteLine(@$"Segundaa pessoa cadastrada: 
                            Nome:{SegundaPessoa.Nome}
                            Idade:{SegundaPessoa.Idade}

");


System.Console.WriteLine("Digite o nome da terceira pessoa");
TerceiraPessoa.Nome = Console.ReadLine();


System.Console.WriteLine("Digite a idade da terceira pessoa");
TerceiraPessoa.Idade = int.Parse(Console.ReadLine());

System.Console.WriteLine(@$"Terceira pessoa cadastrada: 
                            Nome:{TerceiraPessoa.Nome}
                            Idade:{TerceiraPessoa.Idade}
                            
");

