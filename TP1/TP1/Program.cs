using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Program
    {
        /* Un hombre desea saber si su sueldo es mayor al sueldo minimo. El programa le pedira su sueldo actual y el minimo,
          si el sueldo es mayor al minimo se debe mostrar un mensaje ne paalla indicandolo */

        static void Main(string[] args)
        {
            int sueldo, sm;

            Console.WriteLine("Ingrese su sueldo actual: ");
            sueldo=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo minimo: ");
            sm = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
            if(sueldo > sm) 
            {
                Console.WriteLine("Su sueldo es mayor al minimo");
            }
            else 
            {
                Console.WriteLine("Su sueldo es menor al minimo");
             }

            Console.ReadKey();
        }
    }
}
