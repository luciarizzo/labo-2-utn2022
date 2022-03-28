using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_project_2
{
    internal class Validador
    {
        public static bool ValidarRespuesta(char respuesta)
        {
            bool validado = false;
            if(respuesta == 'S')
            {
                validado = true;
            }
            return validado;
        }
    }
}
