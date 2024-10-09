using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contar_caracteres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letra;
            int contador= 0; // Contador de mayusculas

            Console.WriteLine("El siguiente programa cuenta las letras MAYÚSCULAS, para finalizar escribe FIN en MAYÚSCULAS");
 
            
            do
            {
                letra = Console.ReadLine();

                // Si solo es una letra es válido
                if (letra.Length == 1)
                {
                    // Cogemos la letra
                    char caracter = letra[0];

                    // Verificamos si el carácter es una letra mayúscula
                    if (char.IsUpper(caracter))
                    {
                        contador++; // Incrementamos el contador
                    }
                }
            }
            while (!(letra == "FIN"));
            
            Console.WriteLine($"Se han ingresado {contador} letras mayúsculas.");

            Console.WriteLine("Fin del programa");
            Console.ReadKey();
        }
    }
}
