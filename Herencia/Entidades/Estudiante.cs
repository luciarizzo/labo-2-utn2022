using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante:Persona
    {
        public int legajo;
        public List<string> materias;

        public Estudiante(Persona persona, int legajo):base(persona.Apellido, persona.Nombre, persona.Dni)
        {
            this.legajo = legajo;
            this.materias = new List<string>();
        }

        public Estudiante(int legajo, long dni, string nombre, string apellido) : this(new Persona(nombre, apellido, dni), legajo)
        {

        }

        public string Estudiar()
        {
            return "Estoy estudiando...";
        }

        public string MostrarEstudiante()
        {
            return $"{base.Mostrar()} Legajo: {this.legajo}";
        }



    }
}
