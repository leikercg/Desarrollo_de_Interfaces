using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    internal class Program
    {
        static void Main()
        {
            // Definir los dos primeros números de Fibonacci
            long fibAnterior = 0;
            long fibActual = 1;

            bool encontrado = false;

            // Generar los primeros 1000 números de Fibonacci
            for (int i = 0; i < 1000; i++)
            {
                // Comprobar si el último dígito del número actual de Fibonacci es 9
                if (fibActual % 10 == 9)
                {
                    Console.WriteLine($"El número de Fibonacci que termina en 9 es: {fibActual}");
                    encontrado = true;
                    break; // Salir del bucle si encontramos el número
                }

                // Calcular el siguiente número de Fibonacci
                long fibSiguiente = fibAnterior + fibActual;
                fibAnterior = fibActual;
                fibActual = fibSiguiente;
            }

            // Si no se encontró ningún número que termine en 9
            if (!encontrado)
            {
                Console.WriteLine("-1");
            }

            Console.ReadKey();
        }
    }
}
