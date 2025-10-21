int opcao;

Console.WriteLine("-------------------------");
Console.WriteLine("BEM VINDO, USUARIO");
Console.WriteLine("-------------------------");

Console.WriteLine("Escolha uma das opcões abaixo");

Console.WriteLine("opcão 1");
Console.WriteLine("opcão 2");
Console.WriteLine("opcão 3");
Console.WriteLine("opcão 4 sair");

opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.WriteLine("Você escolheu a Opção 1.");
        break;

    case 2:
        Console.WriteLine("Você escolheu a Opção 2.");
        break;

    case 3:
        Console.WriteLine("Voce escolheu a opcao 3");
        break;

         case 4:
        Console.WriteLine("Voce escolheu a opcao 4 saindo do progama");
        break;

    default:
        Console.WriteLine("OPCAO INVALIDA");
        break;
}