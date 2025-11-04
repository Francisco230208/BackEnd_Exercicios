
namespace MetodoConstrutor
{
    public class Carro
    {
        public string Marca = "";
        public string Modelo = "";
        public int Ano;

        public Carro()
        {
            Marca = "Desconhecida";
            Modelo = "Desconhecido";
            Ano = 0;
        }

        public Carro(string m)
        {
            Marca = m;
            Modelo = "Desconhecido";
            Ano = 0;
        }

        public Carro(string m, string mod)
        {
            Marca = m;
            Modelo = mod;
            Ano = 0;
        }

        public Carro(string m, string mod, int a)
        {
            Marca = m;
            Modelo = mod;
            Ano = a;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
        }
    }
}
