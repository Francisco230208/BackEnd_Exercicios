int senhacorreta = 1234;
int senha;

Console.WriteLine("Digite a senha");
senha= int.Parse(Console.ReadLine());


if (senhacorreta == senha) 
{
    Console.WriteLine("Acesso perimitido");
}
else
{
    Console.WriteLine("Acesso negado");
}