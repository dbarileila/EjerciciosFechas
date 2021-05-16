using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUIAFECHA_EJR27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite el ingreso de una fecha al usuario y presente las fechas 30, 60, 90 y 
            //180 días posteriores a la ingresada.

            do
            {
                Console.Write("Ingrese una fecha: ");
                string ingreso = Console.ReadLine();

                if (!DateTime.TryParse(ingreso, out DateTime salida))
                {
                    Console.WriteLine("Usted no ingreso una fecha válida.");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Fecha 30 días posterior a la ingresada: {salida.AddDays(30).ToShortDateString()}");
                    Console.WriteLine($"Fecha 60 días posterior a la ingresada: {salida.AddDays(60).ToShortDateString()}");
                    Console.WriteLine($"Fecha 90 días posterior a la ingresada: {salida.AddDays(90).ToShortDateString()}");
                    Console.WriteLine($"Fecha 180 días posterior a la ingresada: {salida.AddDays(180).ToShortDateString()}");
                    break;
                }

            } while (true);
            Console.ReadKey();

        }
    }
}
