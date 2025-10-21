float salario, salariogasto;

Console.WriteLine("Digite seu salario");
salario = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o quanto gastou");
salariogasto = float.Parse(Console.ReadLine());

if (salario > salariogasto)
{
    Console.WriteLine("Gastos dentro do orçamento");
}
else
{
    Console.WriteLine("Orçameto estourado");
}