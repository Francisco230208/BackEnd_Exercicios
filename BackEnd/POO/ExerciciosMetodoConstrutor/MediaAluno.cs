using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodoConstrutor
{
    public class MediaAluno
    {
        public string nome = "";
        public double n1, n2, n3;

        //construtor com parâmetros
        public MediaAluno(double param1, double param2, double param3)
        {
            n1 = param1;
            n2 = param2;
            n3 = param3;
        }

        public MediaAluno()
        {
            n1 = n2 = n3 = 0;
        }
        

        public void media()
        {
            double media = (n1 + n2 + n3) / 3;
            System.Console.WriteLine($"A média do (a) {nome}, foi {media}😗❤️😍");
        }
    }
}