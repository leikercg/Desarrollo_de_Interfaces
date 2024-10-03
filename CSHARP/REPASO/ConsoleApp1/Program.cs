using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdoce un número");
            int numero = int.Parse (Console.ReadLine());
            Console.WriteLine($"Los divisores de {numero} son: ");

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
