/*
 * Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de 
 * números, cuyas sumas son iguales.

El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) 
cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a 49) 
en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.

Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.

 */

using System;

namespace _1_project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese hasta qué numero quiere buscar centros numéricos: ");
            int numero;
            while(int.TryParse(Console.ReadLine(), out numero))
            {
                for (int centro = 1; centro < numero; centro++)
                {
                    int sumaAnterior = 0;
                    for(int i = 0; i < centro; i++)
                    {
                        sumaAnterior += i;
                    }

                    int sumaPosterior = 0;
                    for (int j = centro + 1; j <= sumaAnterior; j++)
                    {
                        if((sumaAnterior == sumaPosterior) || (sumaPosterior > sumaAnterior))
                        {
                            break;
                        }
                        sumaPosterior += j;
                    }

                    if(sumaAnterior == sumaPosterior)
                    {
                        Console.WriteLine("{0} es un centro numérico", centro);
                    }
                }
            }
            Console.WriteLine("Error. Lo ingresado no es un número");
        }
    }
}
