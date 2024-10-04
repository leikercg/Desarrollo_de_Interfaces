using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_Primo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Introducimos texto
            Console.WriteLine("Introduce un número");
            int num =int.Parse(Console.ReadLine());

           

            // Usamos la función
            Console.WriteLine(esPrimo(num));
 

            Console.ReadKey();
        }

        public static string esPrimo(int num)
        {
            // Variables
            int i = 2; // Evitamos el 1, ya que todos son divisibles enrte 1
            bool esPrimo = true;

            while (i < num)
            {
                // Si encontramos un divisor exacto
                if (num % i == 0)
                {
                    esPrimo = false; 
                    
                    // Salimos de la función devolviendo una cadana, es más eficiente ya que no sigue recorriendo
                    if (!esPrimo)                   
                    return $"El número {num} no es primo"; 
                }

                // Incrementamos el divisor
                i++;
            }

            // Si no se encontró ningún divisor, el número es primo y devolvemos esta cadena
            return $"El número {num} es primo";
        }
    }
}
