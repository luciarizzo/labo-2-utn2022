/*
 * Escribir un programa que imprima por consola un triángulo como el siguiente:

El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. 
Para el ejemplo anterior, la altura ingresada fue de 5.
 */
using System;

namespace _1_project_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char star = '*';
            int size = 5;
            if (size > 0)
            {
                // for write every line
                for (int height = 0; height <= size; height++)
                {
                    //for write the spaces
                    for (int i = 1; i <= (size - height); i++)
                    {
                        Console.Write(" ");
                    }

                    //for write the asterisks
                    //long = double -1
                    for (int asterisk = 1; asterisk <= (height * 2) - 1; asterisk++)
                    {
                        Console.Write(star);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
