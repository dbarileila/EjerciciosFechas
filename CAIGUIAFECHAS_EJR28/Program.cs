using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUIAFECHAS_EJR28
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite el ingreso de un número al usuario y determine si corresponde a un año bisiesto.

            do
            {
                Console.Write("Ingrese una fecha: ");
                string ingreso = Console.ReadLine();

                if (!DateTime.TryParse(ingreso, out DateTime salida))
                {
                    Console.WriteLine("No ingreso una fecha correcta.");
                    continue;
                }

                if (DateTime.IsLeapYear(salida.Year))
                {
                    Console.WriteLine($"{salida.Year} corresponde a un año bisiesto");
                    break;
                }
                else
                {
                    Console.WriteLine("No corresponde a un año bisiesto");
                    break;
                }

            } while (true);

            Console.ReadKey();
        }
    }
}
