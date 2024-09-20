using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio = 2.5;

            double resultado = radio * radio * Math.PI;

            decimal resultadoDecimal= (decimal)(radio * radio * Math.PI);

            Console.WriteLine("El area es "+ resultado);
            Console.WriteLine("El area con decimal es " + resultado);

            Console.ReadLine();



        }
    }
}
