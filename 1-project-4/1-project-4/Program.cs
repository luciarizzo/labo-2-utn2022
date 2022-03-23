using System;

namespace _1_project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int divisor;
            int numero;
            int acumuladorDivisor = 0;
            int contadorNumPerfectos = 0;
            for (numero = 1; contadorNumPerfectos < 4; numero++)
            {
                acumuladorDivisor = 0;
                for(divisor = 1; divisor <= (numero / 2); divisor++)
                {
                    if((numero % divisor) == 0)
                    {
                        acumuladorDivisor += divisor;
                    }
                }
                if (acumuladorDivisor == numero)
                {
                    Console.WriteLine("El numero " + numero + " es perfecto");
                    contadorNumPerfectos++;
                }
            }
        }
    }
}
