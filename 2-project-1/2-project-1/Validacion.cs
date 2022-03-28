using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_project_1
{
    internal class Validacion
    {
        private static bool Validar(int valor, int min, int max)
        {
            bool validado = false;
            if (valor < max && valor > min)
            {
                validado = true;
            }
            return validado;
        }

        public static void PedirNumeros(int min, int max)
        {
            int valorMinimo = int.MaxValue;
            int valorMaximo = int.MinValue;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ingrese el numero {0}", i);
                int.TryParse(Console.ReadLine(), out int valorIngresado);

                if (Validar(valorIngresado, min, max))
                {
                    if (valorIngresado < valorMinimo)
                    {
                        valorMinimo = valorIngresado;
                    }
                    else if (valorIngresado > valorMaximo)
                    {
                        valorMaximo = valorIngresado;
                    }
                }
                else
                {
                    Console.WriteLine("El numero está fuera de rango");
                }
            }
            Console.WriteLine("El menor numero es {0} y el mayor numero es {1}", valorMinimo, valorMaximo);

        }
    }
}
