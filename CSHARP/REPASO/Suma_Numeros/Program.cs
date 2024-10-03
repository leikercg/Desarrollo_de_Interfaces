using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un número:"); // Introducir número
            //int numero = int.Parse(Console.ReadLine());
            String numero = Console.ReadLine();

            /* int suma = 0; // Valor inicial de la suma
             int numeroOriginal = numero; // Guardamos valor original para mostrarlo en consola


             while (numero > 0) // 0 Por que en algún momento llegara a 0,4, pero el oint solo coge valores enteros
             {
                 int resto = numero % 10;  
                 suma += resto;            
                 numero /= 10;         
             }


             Console.WriteLine($"La suma de {numeroOriginal} es: {suma}");*/

            int suma = 0;

            char [] numeros = numero.ToCharArray();

            foreach (char c in numeros) { 
                suma += int.Parse(c.ToString());
            }

            Console.WriteLine(suma);

            Console.ReadKey();
        }
    }
}
