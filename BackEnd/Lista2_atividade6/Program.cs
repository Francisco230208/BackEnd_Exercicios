float media, frequencia;

Console.WriteLine("Digite sua media");
media = float.Parse(Console.ReadLine());

Console.WriteLine("Digite sua frequencia");
frequencia = float.Parse(Console.ReadLine());

if (frequencia < 75)
{
    Console.WriteLine("Reprovado por frequencia");
}
else
{
 
if (media >= 7)
{
    Console.WriteLine("Aprovado por nota");
}
else if (media >= 3)
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Reprovado por nota");
}
}
