using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaro las variables y luego inicializo a cero. 
            double num1 = 0; double num2 = 0;

            // Muestro titulo como la aplicación de calculadora de consola en C#
            Console.WriteLine("Calculadora de Consola en C# by ConoSurTech\r");
            Console.WriteLine("--------------------------------------------\n");

            // Pido el ingreso del primer número
            Console.WriteLine("Ingresa un número, luego aprieta ENTER");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Pido el ingreso del segundo número
            Console.WriteLine("Ingresa otro número, luego aprieta ENTER");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Pido la selección de una operación
            Console.WriteLine("Elije una opción de la lista:");
            Console.WriteLine("\ts - Sumar");
            Console.WriteLine("\tr - Restar");
            Console.WriteLine("\tm - Multiplicar");
            Console.WriteLine("\td - Dividir");
            Console.Write("¿Cuál es tu opción? ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "s":
                    Console.WriteLine($"Tu resultado: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "r":
                    Console.WriteLine($"Tu resultado: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Tu resultado: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Tu resultado: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Wait for the user to respond before closing.
            Console.Write("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
