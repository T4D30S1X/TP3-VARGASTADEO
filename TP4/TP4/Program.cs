using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    internal class Program
    {
        /* Diseñe un programa  que lea un numero de 3 cifras y determine si es o no capicua */

        static void Main(string[] args)
        {
            int n, aux, aux2;

            Console.WriteLine("Ingrese un numero de 3 cifras");
            n = int.Parse(Console.ReadLine());

            aux = (int)Math.IEEERemainder(n, 10);
            aux2 = n / 100;

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();

            if (aux == aux2) 
            {
                Console.WriteLine("El numero: " + n + " es Capicua");
            } else
            {
                Console.WriteLine("El numero " + n + " no es Capicua");
            }


            Console.ReadKey();

        }
    }
}
