using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_project_3
{
    internal class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string numeroFormandose = "";
            int decimalActualizado = numeroEntero;
            int flagPrimerIngreso = 0;
            if(numeroEntero > 0)
            {
                do
                {
                    if (flagPrimerIngreso == 1)
                    {
                        decimalActualizado = decimalActualizado / 2;
                    }

                    flagPrimerIngreso = 1;

                    if ((decimalActualizado % 2) == 0)
                    {

                        numeroFormandose = "0" + numeroFormandose;
                    }
                    else if ((decimalActualizado % 2) == 1)
                    {
                        numeroFormandose = "1" + numeroFormandose;
                    }  
                } while (decimalActualizado > 1);
            }
            else
            {
                Console.WriteLine("Error. Por favor, ingrese un numero positivo");
            }
            Console.WriteLine("El numero {0} en Binario es: {1}", numeroEntero, numeroFormandose);
            return numeroFormandose;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            string numero = numeroEntero.ToString();
            int tamanio = numero.Length;
            for(int i = 0; i <= tamanio; i++)
            {
                i = Math.Pow(2, i);

            }

        }
    }
}
