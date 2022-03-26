/*
 Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y la 
cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.

Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar 
el valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados 
multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.

Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar 
en bruto y el total a cobrar neto de todos los empleados ingresados.
 */


using System;

namespace _1_project_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorHora;
            string nombre;
            int antiguedad;
            int horasTrabajadas;
            int empleados;

            Console.WriteLine("¿De cuántos empleados desea realizar los recibos de sueldo?");
            while (!(int.TryParse(Console.ReadLine(), out empleados)))
            {
                Console.WriteLine("Error, reingrese la cantidad");
            }

            for (int i = 1; i <= empleados; i++)
            {
                Console.WriteLine("Ingrese el nombre del empleado ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el valor hora del empleado ");
                while(!(int.TryParse(Console.ReadLine(), out valorHora)))
                {
                    Console.WriteLine("Error, reingrese la hora");
                }
                Console.WriteLine("Ingrese la antiguedad del empleado ");
                while(!(int.TryParse(Console.ReadLine(), out antiguedad)))
                {
                    Console.WriteLine("Error, reingrese la antiguedad");
                }
                Console.WriteLine("Ingrese las horas trabajadas en el mes del empleado ");
                while(!(int.TryParse(Console.ReadLine(), out horasTrabajadas)))
                {
                    Console.WriteLine("Error, reingrese la horas trabajadas");
                }

                int totalBruto;
                double totalNeto;
                totalBruto = (valorHora * horasTrabajadas) + (antiguedad * 150);
                totalNeto = totalBruto - (totalBruto * 0.13);
                Console.WriteLine("\nEl nombre del empleado es {0} \n su hora de ingreso es {1}\n Su antiguedades es de {2} años\nLas horas trabajadas en el mes son {3}\n Su sueldo bruto es {4} y su sueldo neto es {5}", nombre, valorHora, antiguedad, horasTrabajadas, totalBruto, totalNeto);
            }
        }
    }
}
