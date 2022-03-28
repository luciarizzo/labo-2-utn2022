/*
 * Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

 */

using System;

namespace _2_project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroEntero;
            char respuesta;
            Console.WriteLine("Ingrese A para convertir de Decimal a Binario o B para convertir de Binario a Decimal: ");
            Char.TryParse(Console.ReadLine(), out respuesta);
            switch (respuesta)
            {
                case 'A':
                    Console.WriteLine("Ingrese un numero para convertir de Decimal a BSinario: ");
                    int.TryParse(Console.ReadLine(), out numeroEntero);
                    Conversor.ConvertirDecimalABinario(numeroEntero);
                    break;
                case 'B':
                    Console.WriteLine("Ingrese un numero para convertir de Binario a Decimal: ");
                    int.TryParse(Console.ReadLine(), out numeroEntero);
                    Conversor.ConvertirBinarioADecimal(numeroEntero);
                    break;
            }
        }
    }
}
