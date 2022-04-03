using System;
using System.Text;

namespace Logica
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string dni;
        private int edad;

        public Persona(string nombre, DateTime fechaDeNacimiento, string dni)
        {
            SetNombre(nombre);
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public void SetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                nombre = "Sin nombre";
            }
            this.nombre = nombre.Trim();
        }

        public void SetFechaDeNacimiento(int dia, int mes, int anio)
        {
            fechaDeNacimiento = new DateTime(dia, mes, anio);
        }

        public void SetDni(string dni)
        {
            this.dni = dni;
        }

        public int CalcularEdad()
        {
            //DateTime fechaActual = DateTime.Now;
            //int anioActual = fechaActual.Year;
            //int anioNacimiento = fechaDeNacimiento.Year;
            int edad = DateTime.Now.Year - fechaDeNacimiento.Year;
            return edad;
        }

        public void SetEdad()
        {
            this.edad = CalcularEdad();
        }

        public string GetFechaDeNacimiento()
        {
            StringBuilder sb = new StringBuilder();
            return sb.ToString();
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetDni()
        {
            return dni;
        }



        public string Mostrar()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre de la persona: {nombre}");
            sb.AppendLine($"La edad de la persona es: {edad}");
            sb.AppendLine($"DNI de la persona: {dni}");
            sb.AppendLine($"Fecha de nacimiento: {fechaDeNacimiento.ToString("dd/MM/yyyy")}");


            return sb.ToString();

        }

        public bool EsMayorDeEdad()
        {
            if (edad > 17)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void MostrarEsMayorOMenor()
        {
            if (EsMayorDeEdad() == true)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else if(EsMayorDeEdad() == false)
            {
                Console.WriteLine("Es menor de edad");
            }
        }
    }
}
