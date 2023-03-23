using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6
{
    internal class Program
    {
        /* La política de cobro de la empresa telefónica CELphone es: Cuando se realiza una llamada, el cobro es
        por el tiempo que esta dura, de tal forma el costo por minuto es uniforme y es de 30 pesos; además, se
        carga un impuesto del 3% cuando es domingo, y si es otro día, en turno de mañana 15% y en turno de tarde
        10%. Realiza un programa para determinar cuánto debe pagar una persona que realiza una llamada, el
u       suario debe ingresar los minutos que duró la llamada, el día, y el turno. */

        static void Main(string[] args)
        {
            int min, dia, turno;
            int precio, total;
            int por3, por15, por10;

            Console.WriteLine("Ingrese los minutos de llamada");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Ingrese  un numero dependiendo del dia");
            Console.WriteLine();
            Console.WriteLine("1 = Domingo");
            Console.WriteLine("2 = Otro dia");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine() ;

            precio = min * 30;

            por3 = (precio * 3) / 100;
            por15= (15 * precio) / 100;
            por10= (10 * precio) / 100;

            if (dia == 1)  
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine();
                total = precio + por3;
                Console.WriteLine("El total de pagar por los " + min + " minutos de llamada es de: $" + total + " pesos");
            } 
            
            if (dia == 2) {
                Console.WriteLine("Ingrese un numero depediendo del turno");
                Console.WriteLine("1 = Turno Mañana");
                Console.WriteLine("2 = Turno Tarde");
                turno=int.Parse(Console.ReadLine());

             if (turno == 1) {
                    Console.WriteLine();
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine();
                    total = precio + por15;
                    Console.WriteLine("El total de pagar por los " + min + " minutos de llamada es de: $" + total + " pesos");
                }
             if(turno == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine();
                    total=precio + por10;
                    Console.WriteLine("El total de pagar por los " + min + " minutos de llamada es de: $" + total + " pesos");
                }
               
            }


            Console.ReadKey ();
        }
    }
}
