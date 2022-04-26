using System;

namespace Entidades
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected long dni;

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }

        public long Dni
        {
            get => dni;
            set => dni = value;
        }

        public Persona(string nombre, string apellido, long dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string Mostrar()
        {
            return $"Nombre: {nombre} --Apellido {apellido} -- DNI: {dni}";
        }


    }
}
