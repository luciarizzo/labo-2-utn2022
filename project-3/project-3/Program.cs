/*
 * Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

Validar que el dato ingresado por el usuario sea un número.

Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

Si ingresa "salir", cerrar la consola.

Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. 

De lo contrario, cerrar la consola. 
 * 
 */
int numero;
int numerosDivisibles;

Console.WriteLine("Ingrese un número:");
numero = int.Parse(Console.ReadLine());
while (!int.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("ERROR, vuelva a ingresar el numero");
}

Console.WriteLine("Los numeros primos hasta el numero {0} son:", numero);
for (int i = 2; i <= numero; i++)
{
    numerosDivisibles = 0;
    for (int j = 1; j <= i; j++)
    {
        if ((i % j) == 0)
        {        
          numerosDivisibles++;
  
        }
    }
    if(numerosDivisibles == 2)
    {
        Console.WriteLine("\n {0}", i);
    }
}