using Exercicio04;

public class Aluno : Pessoa
    {
        public string Curso { get; set; }

        public override void MostrarInfo()
        {
            Console.WriteLine("=== Informações do Aluno ===");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Curso: {Curso}");
            Console.WriteLine();
        }
    }