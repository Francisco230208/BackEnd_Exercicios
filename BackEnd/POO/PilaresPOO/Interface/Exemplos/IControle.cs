using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public interface IControle
    {
        //propriedades obrigatórias na classe que implementar a interface
       

        //métodos obriga´torios na class
        void Ligar();
        void Desligar();
        void AumentarVolume();
        void DiminuirVolume();
    }
}