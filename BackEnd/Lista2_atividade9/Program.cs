int opcao = -1;
while (opcao != 4)
{
    Console.WriteLine("-------------------------");
    Console.WriteLine("BEM VINDO, USUARIO");
    Console.WriteLine("-------------------------");

    Console.WriteLine("Escolha uma das opcões abaixo");
    opcao = int.Parse(Console.ReadLine());

    Console.WriteLine("opcão 1");
    Console.WriteLine("opcão 2");
    Console.WriteLine("opcão 3");
    Console.WriteLine("opcão 4 sair");



    switch (opcao)
    {
        case 1:
            opcao1();
            break;

        case 2:
            opcao2();
            break;

        case 3:
            opcao3();
            break;

        case 4:
            opcao4();
            break;

        default:
            opcao5();
            break;
    }

}

void opcao1()
{
    Console.WriteLine("Você escolheu a Opção 1.");
}

void opcao2()
{
    Console.WriteLine("Você escolheu a Opção 2.");

}
void opcao3()
{
    Console.WriteLine("Você escolheu a Opção 3.");

}
void opcao4()
{
    Console.WriteLine("Você escolheu a Opção 4 saindo do progama");

}
void opcao5()
{
        Console.WriteLine("Opação invalida");

}