using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    // Crea una aplicación que nos pida un día de la semana y que nos diga si es un día laboral o no.

    internal class Program
    {
        static void Main(string[] args)
        {
            string dia;

            Console.WriteLine("Ingrese el dia ");
            dia = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine();

            if (dia == "Lunes" || dia == "Martes" || dia == "Miercoles" || dia == "Jueves" || dia == "Viernes") 
            {
                Console.WriteLine("El dia: " + dia + " es un dia laboral");
            } else
            {
                Console.WriteLine("El dia: " + dia + " no es un dia laboral");
            }

            Console.ReadLine();
        }
    }
}
