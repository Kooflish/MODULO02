using System;

class Program
{
    static void Main()
    {
        int opcion;
        double num1, num2, resultado;

        do
        {
            Console.WriteLine("***** CALCULADORA *****");
            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - Multiplicación");
            Console.WriteLine("4 - División");
            Console.WriteLine("5 - Elevar un número a la potencia");
            Console.WriteLine("6 - Salir");
            Console.Write("Seleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion >= 1 && opcion <= 5)
            {
                Console.Write("Ingrese el primer número: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
                        break;

                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
                        break;

                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
                        break;

                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir entre 0.");
                        }
                        break;

                    case 5:
                        resultado = Math.Pow(num1, num2);
                        Console.WriteLine($"Resultado: {num1} ^ {num2} = {resultado}");
                        break;
                }
            }
            else if (opcion == 6)
            {
                Console.WriteLine("Saliendo del programa...");
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
            }

            Console.WriteLine(); // Línea en blanco

        } while (opcion != 6);
    }
}
