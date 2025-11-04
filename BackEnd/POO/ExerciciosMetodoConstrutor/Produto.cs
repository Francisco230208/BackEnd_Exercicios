
namespace ExerciciosMetodoConstrutor
{
    public class Produto
    {
        public string nome = "";
        public double preco = 0;
        public int estoque = 0;


        public Produto(string n, int p, int e)
        {
            nome = n;
            preco = p;
            estoque = e;
        }
        
        
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}, Preço: {preco}, Estoque: {estoque}");
        }
    }
}