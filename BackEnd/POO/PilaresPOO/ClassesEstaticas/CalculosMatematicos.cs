

using System.Dynamic;

namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
        //Operações matemáticas simples
        //visibilidade tipoDeRetorno Nome(parâmetros){corpo}
        public static float Somar(float a, float b)
        {
            return a + b;
        }

        public static float Subtrair(float a, float b)
        {
            return a - b;
        }

        public static float Multiplicar(float a, float b)
        {
            return a * b;
        }

        public static float Dividir(float a, float b)
        {
             if(b == 0)
            {
              System.Console.WriteLine("Não é permitido fazer divisão por 0");
              return 0;
            }
               return a / b ;
        }

        
    }
}