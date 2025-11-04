using System;

namespace ExerciciosMetodoConstrutor
{
    public class ClasseAluno
    {
        public string nome = "Desconhecido";
        public int nota = 0;

        public ClasseAluno()
        {
        }

        public ClasseAluno(string no, int n)
        {
            nome = no;
            nota = n;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}, Nota: {nota}");
        }
    }
}
