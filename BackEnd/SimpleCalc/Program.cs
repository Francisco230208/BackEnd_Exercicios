/*
Pedir o nome do usuário, dois números e mostrar a soma dos números no final
*/
string nome;
int numero1;
int numero2;
/*
Pedir os nomes pro usuário
*/
Console.WriteLine("Digite seu nome");
nome = Console.ReadLine(); //pede o nome do usuario
//somar os dois numeros
//exibir o nome e a soma

//Pedir os dois numeros
Console.WriteLine("Digite primeiro numero");
numero1 = int.Parse(Console.ReadLine());//converte texto em numero
Console.WriteLine("Digite segundo numero");
numero2 = int.Parse(Console.ReadLine());//converte texto em numero

//somar os dois numeros
int soma = numero1 + numero2;

//Exibir nome e a soma
Console.WriteLine(nome);//exibe o nome do usuario
Console.WriteLine(soma);//exibe o total da soma

