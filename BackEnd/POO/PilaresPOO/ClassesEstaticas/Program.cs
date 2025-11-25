// See https://aka.ms/new-console-template for more information
using ClassesEstaticas;

// Console.WriteLine("Bem vindo ao progama");
// System.Console.WriteLine();

// System.Console.WriteLine("Digite um número");
// float a = float.Parse(Console.ReadLine());

// System.Console.WriteLine("Digite outro número");
// float b = float.Parse(Console.ReadLine());

// //uso da classe estática de forma auxiliar
// float r = CalculosMatematicos.Somar(a, b);
// System.Console.WriteLine($"Soma: {r}");

//  r = CalculosMatematicos.Subtrair(a, b);
// System.Console.WriteLine($"Subtração: {r}");

//  r = CalculosMatematicos.Multiplicar(a, b);
// System.Console.WriteLine($"Multiplicação: {r}");

// r = CalculosMatematicos.Dividir(a, b);
// System.Console.WriteLine($"Divisão: {r}");



//Solicitar ao usuario 2 numeros e informar qual é o maior e  qual é o menor dos numeros. 
// Para isso voce deve utilizar a classe Math
System.Console.WriteLine("Digite o primeiro número");
float a = float.Parse(Console.ReadLine());

System.Console.WriteLine("Digite o segundo número");
float b = float.Parse(Console.ReadLine());


    System.Console.WriteLine("Os dois numeros são iguais");


float maior = Math.Max(a, b);
float menor = Math.Min(a, b);

System.Console.WriteLine($"O maior número é: {maior}");
System.Console.WriteLine($"O menor número é: {menor}");
