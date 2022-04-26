using System;
using System.Collections.Generic;

using Entidades;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Lautaro", "Galarza", 40256132);
            Profesor prof1 = new Profesor("Programacion II", "Cerizza", 40254563, "Mauricio");
            Estudiante est1 = new Estudiante(p1, 411245578);

            Persona p2 = prof1; //guarde en un objeto de tipo persona una referencia de profesor. PRINCIPIO de sustitucion de liskov. No implica que tengamos perdida de información
                                //en memoria, p2 sigue teniendo referencia de tipo profesor, por medio de un casteo podemos recuperar esa información
                                //intercambias una referencia de la clase hija por una de la clase padre. En un objeto de tipo persona guardas una referencia de la clase hija.
                                 

            //podemos reemplazar referencia de una clase hija por una referencia de clase base.
            //podemos llegar a tener collecciones genericas de nuestra clase base y cargarle cualquier referencia a una clase derivada.
            List<Persona> personas = new List<Persona>(); 
            //esto lo permite la herencia, porque un profesor y un estudiante son una persona. pero eso no significa que una persona sea un profesor
            //es una forma de poder manejar de manera genérica
            personas.Add(p1);
            personas.Add(prof1);
            personas.Add(est1);

            //una persona no es un profesor, esto NO se puede hacer:
            //Profesor profesor = p1;

            foreach (Persona item in personas)
            {
                Console.WriteLine(item.Mostrar());

                //NO SE PUEDE CASTEAR UNA PERSONA A PROFESOR:
                //Profesor profe = (Profesor)item;
                //Console.WriteLine(profe.Corregir());

                //Cómo lo resolvemos? Tenemos la palabra reservado is. Revisa en tiempo de ejecucion si el objeto es de dicha clase o referencia.
                if(item is Profesor) //casteas objeto de tipo persona a su referencia original. como en memoria nuestro objeto sigue siendo de tipo profesor o estudiante
                                     //por medio del casteo podemos recuperar los miembros que estan "perdidos" en el getter
                                     //cuando está iterando valide si es profesor o alumno y en base a eso utilice algun metodo.
                {
                    Profesor profe = (Profesor)item;
                    Console.WriteLine(profe.Corregir());
                } 
                else if(item is Estudiante)
                {
                    Estudiante profe = (Estudiante)item;
                    Console.WriteLine(profe.Estudiar());
                }

                //todas las clases de C# heredan de object. TODO TODITO son métodos de la clase object (gethashcode, tostring, equals...). 

            }

        }
    }
}
