/*
 * 
 * 
 */

using System;
using Logica;

namespace _3_project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Argibay", "Gaston", "45785");
            Estudiante estudiante2 = new Estudiante("Zeitunlian", "Noelia", "56984");
            Estudiante estudiante3 = new Estudiante("Fleming", "Pedro", "65785");

            estudiante1.SetNotaPrimerParcial(8); 
            estudiante2.SetNotaPrimerParcial(7);
            estudiante3.SetNotaPrimerParcial(10);

            estudiante1.SetNotaSegundoParcial(1);
            estudiante2.SetNotaSegundoParcial(6);
            estudiante3.SetNotaSegundoParcial(9);

            estudiante1.CalcularNotaFinal();
            estudiante2.CalcularNotaFinal();
            estudiante3.CalcularNotaFinal();

            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());

        }
    }
}
