/*
 * 
 */

using System;
using System.Text;

namespace Logica
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private float promedio;
        private double notaFinal;
        private Random random;

        public Estudiante(string apellido, string nombre, string legajo)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }

        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }

        private float CalcularPromedio()
        {
            promedio = (notaPrimerParcial + notaSegundoParcial) / 2;
            return promedio;
        }

        public void CalcularNotaFinal()
        {
            var random = new Random();
            double notaFinal;
            if(notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                notaFinal = random.Next(6, 10);
            }
            else
            {
                notaFinal = -1;
            }
            this.notaFinal = notaFinal;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}. Apellido: {apellido}. Legajo: {legajo}");
            sb.AppendLine($"Nota primer parcial: {notaPrimerParcial}. Nota segundo parcial: {notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");
            if(notaFinal != -1)
            {
                sb.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                sb.AppendLine($"Alumno desaprobado");
            }
            return sb.ToString();

        }
    }
}
