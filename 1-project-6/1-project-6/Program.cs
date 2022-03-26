/*
 * Escribir un programa que determine si un año es bisiesto.

Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo 
si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.

Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
 */

using System;

namespace _1_project_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anioinicio;
            int aniofin;
            Console.WriteLine("Ingrese un año de inicio: ");
            while(!(int.TryParse(Console.ReadLine(), out anioinicio)))
            {
                Console.WriteLine("Error, reingrese un número");
            }

            Console.WriteLine("Ingrese un año de fin: ");
            
            while (!(int.TryParse(Console.ReadLine(), out aniofin)))
            {
                Console.WriteLine("Error, reingrese un número");
            }

            for (int i = anioinicio; i <= aniofin; i++)
            {
                if (((i % 4) == 0) && ((i % 100) != 0 || (i % 400) == 0))
                {
                        Console.WriteLine("{0} es un año bisiesto", i);
                }
            }
        }
    }
}
