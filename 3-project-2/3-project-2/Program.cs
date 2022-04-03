/*
Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

Deberá tener los atributos:

nombre
fechaDeNacimiento
dni

Deberá tener un constructor que inicialice todos los atributos.

Construir los siguientes métodos para la clase:

Setter y getter para cada uno de los atributos.

CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la 
fecha de nacimiento.

Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo 
la edad actual.

EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.

Instanciar 3 objetos de tipo Persona en el método Main.

Mostrar quiénes son mayores de edad y quiénes no.
 */

using System;
using Logica;

namespace _3_project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona gaston = new Persona("Gaston", new DateTime(1988, 03, 09), "21563486");
            Persona noelia = new Persona("Noelia", new DateTime(1999, 05, 23), "41568752");
            Persona pedro = new Persona("Pedro", new DateTime(1997, 09, 05), "29745314");

            Console.WriteLine(gaston.Mostrar());
            Console.WriteLine(noelia.Mostrar());
            Console.WriteLine(pedro.Mostrar());

            gaston.MostrarEsMayorOMenor();
            noelia.MostrarEsMayorOMenor();
            pedro.MostrarEsMayorOMenor();

        }
    }
}
