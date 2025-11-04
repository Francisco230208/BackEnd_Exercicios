using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    public class Pessoa3Sobrecarga
    {
        public string Nome = "";
        public int Idade;

        public Pessoa3Sobrecarga()
        {
            Nome = "Desconhecido";
            Idade = 0;
        }


        public Pessoa3Sobrecarga(string n )
        {
            Nome = n;
            Idade = 0;
        }

        //Método construtor de Pessoa possui parametros 
        //Parametros representam os valores de nome e idade
        //ou seja, estamos inicializando valores para as props nome e idade

        public Pessoa3Sobrecarga(string n, int i)
        {
            Nome = n;
            Idade = i;
        }
        public void ExibirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}, idade {Idade}");
        }
    }
    
}