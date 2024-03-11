namespace Evidencia1;

using System;

class Program
{
    static void Main(string[] args)
    {
        // Mostrar el menú al usuario
        MostrarMenu();
        // Leer la opción seleccionada por el usuario
        int opcion = int.Parse(Console.ReadLine());

        // Seleccionar una acción basada en la opción elegida
        switch (opcion)
        {
            case 1:
                RealizarOperacionesBasicas(); // Realizar operaciones básicas
                break;
            case 2:
                ResolverEcuacionLineal(); // Resolver una ecuación lineal
                break;
            case 3:
                ResolverEcuacionesTrigonometricas(); // Resolver ecuaciones trigonométricas
                break;
            case 4:
                ResolverSistemaEcuacionesLineales(); // Resolver un sistema de ecuaciones lineales
                break;
            default:
                Console.WriteLine("Opción no válida."); // Opción no válida
                break;
        }
    }

    // Metod para mostrar el menú de opciones
    static void MostrarMenu()
    {
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Operaciones Básicas");
        Console.WriteLine("2. Resolver Ecuación Lineal");
        Console.WriteLine("3. Resolver Ecuaciones Trigonométricas");
        Console.WriteLine("4. Resolver Sistema de Ecuaciones Lineales de Dos Variables");
    }

    // Metod para realizar operaciones básicas (suma, resta, multiplicación, división)
    static void RealizarOperacionesBasicas()
    {
        // Pedir al usuario que ingrese dos números
        Console.WriteLine("Ingrese el primer número:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double num2 = double.Parse(Console.ReadLine());

        // Mostrar las opciones de operaciones básicas
        Console.WriteLine("Seleccione la operación:");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");

        // Leer la operación seleccionada por el usuario
        int operacion = int.Parse(Console.ReadLine());

        // Realizar la operación correspondiente
        switch (operacion)
        {
            case 1:
                Console.WriteLine($"El resultado de la suma es: {num1 + num2}");
                break;
            case 2:
                Console.WriteLine($"El resultado de la resta es: {num1 - num2}");
                break;
            case 3:
                Console.WriteLine($"El resultado de la multiplicación es: {num1 * num2}");
                break;
            case 4:
                if (num2 != 0)
                {
                    Console.WriteLine($"El resultado de la división es: {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("No se puede dividir entre cero.");
                }
                break;
            default:
                Console.WriteLine("Operación no válida.");
                break;
        }
    }

    // Metod para resolver una ecuación lineal
    static void ResolverEcuacionLineal()
    {
        // Pedir al usuario que ingrese los coeficientes de la ecuación
        Console.WriteLine("Ingrese el coeficiente 'a':");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el coeficiente 'b':");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el término independiente 'c':");
        double c = double.Parse(Console.ReadLine());

        // Resolver la ecuación
        if (a != 0)
        {
            double x = (c - b) / a;
            Console.WriteLine($"La solución de la ecuación {a}x + {b} = {c} es: x = {x}");
        }
        else if (b == c)
        {
            Console.WriteLine("La ecuación es una identidad. Tiene infinitas soluciones.");
        }
        else
        {
            Console.WriteLine("La ecuación no tiene solución.");
        }
    }

    // Metod para resolver ecuaciones trigonométricas
    static void ResolverEcuacionesTrigonometricas()
    {
        // Pedir al usuario que ingrese el valor del ángulo en grados
        Console.WriteLine("Ingrese el valor del ángulo en grados:");
        double anguloGrados = double.Parse(Console.ReadLine());

        // Convertir el ángulo de grados a radianes
        double anguloRadianes = anguloGrados * Math.PI / 180.0;

        // Calcular y mostrar el seno, coseno y tangente del ángulo
        Console.WriteLine($"El seno de {anguloGrados} grados es: {Math.Sin(anguloRadianes)}");
        Console.WriteLine($"El coseno de {anguloGrados} grados es: {Math.Cos(anguloRadianes)}");
        Console.WriteLine($"La tangente de {anguloGrados} grados es: {Math.Tan(anguloRadianes)}");
    }

    // Metod para resolver un sistema de ecuaciones lineales
    static void ResolverSistemaEcuacionesLineales()
    {
        // Pedir al usuario que ingrese los coeficientes del sistema de ecuaciones
        Console.WriteLine("Ingrese los coeficientes para la matriz de coeficientes (ax + by = c, dx + ey = f):");
        double[,] coeficientes = new double[2, 3];

        // Leer los coeficientes ingresados por el usuario
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                coeficientes[i, j] = double.Parse(Console.ReadLine());
            }
        }

        // Extraer los coeficientes y las constantes del sistema de ecuaciones
        double[,] matrizCoeficientes = { { coeficientes[0, 0], coeficientes[0, 1] }, { coeficientes[1, 0], coeficientes[1, 1] } };
        double[] constantes = { coeficientes[0, 2], coeficientes[1, 2] };

        // Calcular el determinante de la matriz de coeficientes
        double determinante = matrizCoeficientes[0, 0] * matrizCoeficientes[1, 1] - matrizCoeficientes[0, 1] * matrizCoeficientes[1, 0];

        // Resolver el sistema de ecuaciones si el determinante es diferente de cero
        if (determinante != 0)
        {
            double x = (matrizCoeficientes[1, 1] * constantes[0] - matrizCoeficientes[0, 1] * constantes[1]) / determinante;
            double y = (matrizCoeficientes[0, 0] * constantes[1] - matrizCoeficientes[1, 0] * constantes[0]) / determinante;
            Console.WriteLine($"La solución del sistema de ecuaciones es: x = {x}, y = {y}");
        }
        else
        {
            Console.WriteLine("El sistema de ecuaciones no tiene solución única.");
        }
    }
}
