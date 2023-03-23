using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    internal class Program
    {
        /* Se pide ingresar una letra del alfabeto y mostrar si dicha letra es vocal o consonante */

        static void Main(string[] args)
        {
            char let;

            Console.WriteLine("Ingrese una letra");
            let = char.Parse(Console.ReadLine());

     

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();

            if (let == 'a' || let == 'e' || let == 'i' || let == 'o' || let == 'u')
            {
                Console.WriteLine("La letra "+let+" es una vocal");
            }
            else
            {
                Console.WriteLine("La letra "+let+" es una consonante");
            }

            Console.ReadKey();
        }
    }
}