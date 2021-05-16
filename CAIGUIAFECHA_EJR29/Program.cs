using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUIAFECHA_EJR29
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite el ingreso de una fecha al usuario y presente la fecha correspondiente 
            //al primero de mes inmediato anterior.

            do
            {
                Console.Write("Ingrese una fecha: ");
                string ingreso = Console.ReadLine();

                if (!DateTime.TryParse(ingreso, out DateTime salida))
                {
                    Console.WriteLine("No ingreso una fecha válida.");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Fecha al mes anterior: {salida.AddMonths(-1).ToShortDateString()}");
                    break;
                }

            } while (true);
            Console.ReadKey();
        }
    }
}
