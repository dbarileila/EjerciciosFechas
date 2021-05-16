using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUIAFECHA_EJR30
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite el ingreso de una fecha al usuario y muestre sólo la hora.

            do
            {
                Console.Write("Ingrese fecha (dd/MM/yyyy/hh): ");
                string ingreso = Console.ReadLine();

                if (!DateTime.TryParse(ingreso, out DateTime salida))
                {
                    Console.WriteLine("No ingreso une fecha correcta.");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Hora: {salida.Hour}:{salida.Minute}:{salida.Second}");
                    break;
                }

            } while (true);
            Console.ReadKey();

        }
    }
}
