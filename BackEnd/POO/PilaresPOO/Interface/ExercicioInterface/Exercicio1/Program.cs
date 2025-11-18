using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using Exercicio1;
/*Na aula passada aprendemos sobre Interfaces. Agora vamos praticar alguns exercícios:

Crie um novo projeto chamado ExerciciosInterface

Exercício 1
Crie uma interface chamada IForma com o método CalcularArea.
Crie duas classes que implementem essa interface: Retangulo e Circulo.
No programa, peça os valores necessários e exiba a área calculada para cada forma.
No Retângulo utilizar o cálculo = Largura * Altura;
No Círculo utilizar o cálculo = PI * Raio * Raio;
Extra: Pesquisar sobre a classe Mth do C# e utilizar a constante PI - Math.PI*/

//retangulo
System.Console.WriteLine("===Bem vindo ao progama Calculos de geometria :=====");
System.Console.WriteLine();

 System.Console.WriteLine($"Vamos calcular  retângulo");

 System.Console.WriteLine("Digite a Largura do retângulo");
 float l = float.Parse(Console.ReadLine());


 System.Console.WriteLine("Digite a Altura do retângulo");
 float a = float.Parse(Console.ReadLine());

 Retangulo retangulo = new Retangulo();
 retangulo.Altura = a;
 retangulo.Largura = l;
 retangulo.CalcularArea();


//circulo
System.Console.WriteLine();
  System.Console.WriteLine($"Agora vamos calcular a área do circulo");
  System.Console.WriteLine("Informe o raio do círculo");
  float r = float.Parse(Console.ReadLine());

  Circulo circulo =  new Circulo();
  circulo.Raio = r;
  circulo.CalcularArea();

  System.Console.WriteLine();
  System.Console.WriteLine("Fim do progama");
  System.Console.WriteLine();

