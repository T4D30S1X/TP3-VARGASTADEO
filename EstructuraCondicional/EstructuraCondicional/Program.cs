using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota = 0;

            
            Console.WriteLine("Ingrese una nota");
            nota = int.Parse(Console.ReadLine());


            if (nota > 6)
            {
                if (nota >= 8)
                {
                    Console.WriteLine("Candidato a una beca");
                    Console.WriteLine("Su nota es: " + nota);
                }

                Console.WriteLine("Esta aprobado");
                Console.WriteLine("Su nota es: " + nota);
            }
           
            else
            {
                Console.WriteLine("Esta desaprobado");
            }


            Console.ReadKey();
            


            Console.ReadKey();

        }
    }
}
