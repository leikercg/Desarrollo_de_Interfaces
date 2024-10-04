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
            // Variables
            int numAnterior = 0;
            int numActual = 1;

            int i = 0;
            bool encontrado = false;

            
            while (i<100)
            {
                // Imprimir números que contienen 9
                if (numActual % 10 == 9)
                {
                    Console.WriteLine($"Acaba en 9: {numActual}");
                    encontrado = true;
    
                }

                // Calcular el siguiente número
                int numSiguiente = numAnterior + numActual;
                numAnterior = numActual;
                numActual = numSiguiente;
                i++;
            }

            // Si no existe imrpimir -1
            if (!encontrado)
            {
                Console.WriteLine("-1");
            }

            Console.ReadKey();
        }
    }
}
