using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUIAFECHA_EJR26
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Solicite el ingreso de una fecha al usuario y le presente: el día, el año, el número 
             * y nombre del mes y el nombre y número del día de la semana.      
             */

            do
            {
                Console.Write("Ingrese una fecha: ");
                string ingreso = Console.ReadLine();

                if (!DateTime.TryParse(ingreso, out DateTime salida))
                {
                    Console.WriteLine("No ingreso una fecha.");
                    continue;

                }
                else
                {

                    Console.WriteLine($"Día: {salida.Day}");
                    Console.WriteLine($"Año: {salida.Year}");
                    Console.WriteLine($"Número del mes: {salida.Month} / Nombre del mes: {salida.ToString("MMMM")}");
                    var ns = Convert.ToInt16(salida.DayOfWeek);
                    /*https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-extract-the-day-of-the-week-from-a-specific-date*/

                    Console.WriteLine($"Número de la semana: {ns}  / Nombre de la semana {salida.DayOfWeek}");

                    break;
                }

            } while (true);
            Console.ReadKey();
        }


    }
}
