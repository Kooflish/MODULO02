using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];

        Console.WriteLine("Digite 10 números (uno por uno):");

        // Leer los 10 números y guardarlos en el arreglo
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Ordenar el arreglo
        Array.Sort(numeros);

        // Mostrar los números ordenados
        Console.WriteLine("\nNúmeros ordenados:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
