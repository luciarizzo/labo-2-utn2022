// See https://aka.ms/new-console-template for more information
/*https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/introduccion/Ejercicios/I02-error-al-cubo
 * Consigna#
Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero, 
caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
 */
int numero;
double numeroCuadrado;
double numeroCubo;

Console.WriteLine("Ingrese un número: ");
numero = int.Parse(Console.ReadLine());
if(numero > 0)
{
    numeroCuadrado = Math.Pow(numero, 2);
    numeroCubo = Math.Pow(numero, 3);
    Console.WriteLine("El cuadrado de {0} es {1}", numero, numeroCuadrado);
    Console.WriteLine("El cubo de {0} es {1}", numero, numeroCubo);
} else
{
    Console.WriteLine("ERROR. ¡Reingresar número!");
}
