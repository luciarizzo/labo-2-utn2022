/*
 * Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje 
 * "¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
 */

using System;

namespace _2_project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char respuesta;
            int suma = 0;
            int numero;
            do
            {
                Console.WriteLine("Ingrese un numero para sumar: ");
                int.TryParse(Console.ReadLine(), out numero);
                suma += numero;
                Console.WriteLine("La suma hasta ahora es: {0} ", suma);
                Console.WriteLine("¿Desea continuar? Ingrese S o N");
                Char.TryParse(Console.ReadLine(), out respuesta);

            } while (Validador.ValidarRespuesta(respuesta));
        }
    }
}
