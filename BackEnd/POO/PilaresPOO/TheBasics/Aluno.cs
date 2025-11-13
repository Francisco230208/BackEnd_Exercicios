
namespace TheBasics
{
    public class Aluno : Pessoa
    {
        //cria um construtor na classe aluno que recebe o endereço
        //e chama o construtor da classe mãe(base   ) e repessa o
        //endereço para ela
        public Aluno(Endereco endereco) : base(endereco)
        {
        }

        public string RA;
        public float NotaFinal;
        public string curso;    
    }
}