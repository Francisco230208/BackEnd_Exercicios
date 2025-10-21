int placar1, placar2 ;

Console.WriteLine("Digite o placar do 1 time");
placar1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o placar do 2 time");
placar2 = int.Parse(Console.ReadLine());

if (placar1 > placar2)
{
    Console.WriteLine("Time 1 ganhou");
}
else if (placar1 > placar1)
{
    Console.WriteLine("Time 2 ganhou");
}
else
{
    Console.WriteLine("O jogo empatou");
}