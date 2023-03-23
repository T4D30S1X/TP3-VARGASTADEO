using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class Program
    {
        /* Construir un programa q permite ingresar un numero, si el numero es mayr a 500, 
         se debe calcular y mostrar en pantalla el 18% de este. */

        static void Main(string[] args)
        {
            int num, por;

            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());

            por = (num * 18) / 100;

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();

            if (num > 500) 
            {
                Console.WriteLine("El 18% del numero es: " + por);
            }

            Console.ReadKey();
        }
    }
}
