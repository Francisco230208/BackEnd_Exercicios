using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using Exercicio2;

List<IImprimivel> documentos = new List<IImprimivel>();

Fatura fatEdu = new Fatura("Eduardo", "Izabel Dark Lab", 50, 1);

fatEdu.Imprimir();

int opcao;
do
{


    //Desenha io Menu
    System.Console.WriteLine("Menu de opções");
    System.Console.WriteLine($@"
1)Cadastrar Fatura 
2)Cadastrar Relatorio
3)Cadastrar Contrato
4)Listar Faturas
5)Listar Relatórios
6)Listar Contratos
Escolha uma opção
");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1: CadastrarFatura();
            System.Console.WriteLine($"Cadastrar fatura");
            break;

        case 2: CadastrarRelatorio();
            System.Console.WriteLine("Cadastrar relatorio");
            break;

        case 3:CadastrarFatura();
            System.Console.WriteLine("Cadastrar contrato");
            break;

        case 4:ListarFraturas();
            System.Console.WriteLine("Listar faturas");
            break;

        case 5:ListarRelatorios();
            System.Console.WriteLine("Listar relatorios");
            break;

        case 6:ListarContratos();
            System.Console.WriteLine("Listar contratos");
            break;
            default:
            System.Console.WriteLine("Opção inválida");
            break;

    }




    System.Console.WriteLine("Digite  <Enter> para continuar ...");
    System.Console.WriteLine();//Para o console para dar tempo de ver as mensagens do progama

} while (opcao != 0);




//funções auxiliares

void CadastrarFatura()
{
    System.Console.WriteLine("Digite o nome do Devedor");
    string dev = Console.ReadLine();

     System.Console.WriteLine("Digite o nomedo credor");
    string cred = Console.ReadLine();

       System.Console.WriteLine("Digite o valor da fatura");
    int diasAtraso = int.Parse(Console.ReadLine());


     System.Console.WriteLine("Quantos dias a fatura esta em atraso");
    float  valor = float.Parse(Console.ReadLine());


    //Cria o objeto da fatura
    Fatura f = new Fatura(dev, cred, valor, diasAtraso);
    //Cadastrar a fatura na lista
    documentos.Add(f);
}

void CadastrarContrato()
{
    System.Console.WriteLine("Digite o o nome do contratante");
    string contr = Console.ReadLine();

     System.Console.WriteLine("Digite o nome da empresa contratante");
    string prest = Console.ReadLine();

 System.Console.WriteLine("Digite as clausula do contratao");
    string clau = Console.ReadLine();

    Contrato c = new Contrato(contr, prest, clau);

        documentos.Add(c);

}

    void CadastrarRelatorio()
{
    System.Console.WriteLine("Digite o nome do responsável pelo relatório");
    string nome = Console.ReadLine();

    System.Console.WriteLine("Digite o texto do relatorio");
    string txtRelat = Console.ReadLine();

    Relatorio c = new Relatorio(nome, txtRelat);
}

void ListarFraturas()
{
    System.Console.WriteLine("Listando as fraturas");
    foreach (var item in documentos)
    {
        if (item is Fatura)
        {               
          item.Imprimir();

        }
    }
}

void ListarContratos()
{
    System.Console.WriteLine("Listando os Contratos");
    foreach (var item in documentos)
    {
        if (item is Fatura)
        {
                    item.Imprimir();

        }
    }
}

void ListarRelatorios()
{
    System.Console.WriteLine("Listando os relatórios");
    foreach (var item in documentos)
    {
        if (item is Fatura)
        {
                    item.Imprimir();

        }
    }
}