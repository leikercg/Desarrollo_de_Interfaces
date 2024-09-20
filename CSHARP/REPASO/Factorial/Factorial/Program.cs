using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaro las variables
            int i, n, fact;
            Console.WriteLine("PROGRAMA FACTORIAL");
            Console.WriteLine();
            Console.Write("Introduce un numero para calcular su factorial: ");

            //INICIALIZAR
            n = int.Parse(Console.ReadLine());
            fact = 1;

            //INICIANALIZO LA SECUENCIA
            i = 1;

            //RECORRO LA SECUENCIA CON UN BUCLE
            while (i <= n)
            {
                //TRATO EL ELEMENTO DE LA SECUENCIA
                fact = fact * i;
                // INREMENTO LA SECUENCIA
                i++;
            }
            //ESCRIBO EL RESULTADO
            Console.WriteLine($"El factorial de {n} es: {fact}");
            Console.ReadKey();

        }
    }
}
