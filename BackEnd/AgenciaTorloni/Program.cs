//Crie um menu da seguinte forma em loop que chame as funções:
// 1. Cadastrar cliente
// 2. Depositar
// 3. Sacar
// 4. Transferir
// 5. Listar Clientes
// 0. Sair

//Por enquanto, as funções apenas devem exibir uma mensagem "Função em Desenvolvimento"

using System.Data.Common;
using System.Diagnostics.Contracts;

int opcao = -1, totalClientes = 0;
string[] nomes = new string[3];
double[] saldos = new double[3];



do
{

    System.Console.WriteLine("=========AGÊNCIA BANCARIA, BEM VINDO(A)=========");
    System.Console.WriteLine();
    System.Console.WriteLine("Bem vindo(a) a nossa agência Bancaria, o que deseja realizar?");
    System.Console.WriteLine();
    System.Console.WriteLine(" 1. Cadastrar cliente");
    System.Console.WriteLine(" 2. Depositar");
    System.Console.WriteLine(" 3. Sacar");
    System.Console.WriteLine(" 4. Transferir");
    System.Console.WriteLine(" 5. Listar Clientes");
    System.Console.WriteLine(" 0. Sair");

    opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 0:
            Console.WriteLine("Obrigado por usar nosso Sistema Bancario, Encessando...");
            Console.ReadLine();
            break;

        case 1:
            CadastrarCliente();
            break;

        case 2:
            Depositar();
            break;

        case 3:
            Sacar();
            break;

        case 4:
            Transferir();
            break;

        case 5:
            ListarClientes();
            break;



        default:
        System.Console.WriteLine($"Opção inválida");
            break;
    }

    System.Console.WriteLine($"Clique <Enter> para continuar");
    Console.ReadLine();

} while (opcao != 0);

void CadastrarCliente()
{
//Verificar se tem espaço no array para cadastrar
    if (totalClientes >= 3)
    {
        Console.WriteLine(" Limite de ocupação atingido");
        return;
    }
   
   //Cadastra o cliente
      Console.Write($"Nome do Cliente: ");
    nomes[totalClientes] = Console.ReadLine();
    saldos[totalClientes] = 0;
    totalClientes++;

    Console.WriteLine("Cadastrado com sucesso...");
    Console.WriteLine();

}

void Depositar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    System.Console.WriteLine($"Valor para depósito");
    double valorDeposito = double.Parse(Console.ReadLine());
    saldos[idCliente] += valorDeposito;
    Console.WriteLine($"Depósito de R${valorDeposito} realizado");

}

void Sacar()
{
    //BUSCAR O CLIENTE  
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    //PEDIR O VALOR DE SAQUE
    System.Console.WriteLine($"Valor do saque");
    double valorSolicitado = double.Parse(Console.ReadLine());

    //VALIDAR SE PODE SACAR OU NÃO 
    if (saldos[idCliente] >= valorSolicitado)
    {
        //ATUALIZAR O SALDO DA CONTA
        saldos[idCliente] -= valorSolicitado;
        System.Console.WriteLine($"Saque realizado com sucesso!");
    }
    else
    {
        System.Console.WriteLine($"Saldo insuficiente");
    }
    

}
int BuscarCliente()
{
    Console.WriteLine("Digite o número do cliente:");
    int idCliente = int.Parse(Console.ReadLine());

    if (idCliente < 0 || idCliente >= totalClientes)
    {
        Console.WriteLine("Cliente não encontrado");
        return -1;
    }

    return idCliente;
}

void Transferir()
{
    //Buscar cliente conta de orgem
    //Buscar cliente conta de destino
    //pedir o valor do saque
    //verificar se a conta de origem tem saldoi tem saldo para transferir
    //se tiver,

   Console.WriteLine($"== TRANSFERENCIA ==");
    Console.WriteLine($"Conta de origem: ");
    int idClienteDeOrigem = BuscarCliente();
    if (idClienteDeOrigem == -1)
    {
        return;
    }


    Console.WriteLine($"Conta de origem: ");
    int idClienteDeDestino = BuscarCliente();
    if (idClienteDeDestino == -1)
    {
        return;
    }

    Console.WriteLine($"Valor para transferir");
    double valor = double.Parse(Console.ReadLine());

    if (saldos[idClienteDeOrigem] >= valor)
    {
        saldos[idClienteDeOrigem] -= valor;
        saldos[idClienteDeDestino] += valor;
        System.Console.WriteLine($"Transferencia concluida!");
    }
    else
    {
        System.Console.WriteLine($"Saldo insuficiente!");
    }
}

void ListarClientes()
{

    System.Console.WriteLine("======LISTA DE CLIENTES======");

    for (int s = 0; s < nomes.Length; s++)
    {
        Console.WriteLine($"{s}- Nome: {nomes[s]} |{s}- Saldo: R${saldos[s]:F2}");
        Console.WriteLine();
    }

    System.Console.WriteLine();

}

