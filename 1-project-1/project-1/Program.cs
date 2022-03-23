// See https://aka.ms/new-console-template for more information

float promedio;
int i;
int numero;
int acumulador = 0;
int contador = 0;
int numeroMinimo = int.MaxValue;
int numeroMaximo = int.MinValue;

for(i = 0; i < 5; i++)
{
    Console.WriteLine("Ingrese el numero {0}: ", i+1);
    numero = int.Parse(Console.ReadLine());
    Console.WriteLine("El numero ingresado es: {0}", numero);

    acumulador += numero;
    contador++;

    if(numero < numeroMinimo)
    {
        numeroMinimo = numero;
    }
    if(numero > numeroMaximo)
    {
        numeroMaximo = numero;
    }
}

promedio = (float)(acumulador / contador);
Console.WriteLine("El minimo es {0}. El maximo es {1}. Promedio {2}", numeroMinimo, numeroMaximo, promedio);
