using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEObjetos
{
    public class AgenciaBancaria
    {
        public string titular = "";
        public double saldo =0;


        //Métodos

        public void depositar()
        {
            System.Console.WriteLine($"Digite o valor de seu depósito");
            double valor = double.Parse(Console.ReadLine());
            saldo += valor;   
        }

        public void sacar()
        {
            System.Console.WriteLine($"Digite o valor que quer sacar");
            double valor = double.Parse(Console.ReadLine());

            if (valor <= saldo)
            {
                saldo -= valor;
                System.Console.WriteLine($"Saque realizado com sucesso");
                
            }
            else
            {
                System.Console.WriteLine($"Saldo insuficiente");
            }
        }
    }
}