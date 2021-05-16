using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUIAFECHAS_EJR23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite el ingreso de una fecha al usuario y determine si es un ingreso válido.

            do
            {

                Console.Write("Ingrese una fecha con el formato MM/dd/yyyy: ");

                string ingreso = Console.ReadLine();

                if (!DateTime.TryParse(ingreso, out DateTime salida))
                {
                    Console.WriteLine("No ingreso una fecha válida.");
                    
                }
                else
                {
                    Console.WriteLine($"Usted ingreso: {salida.ToShortDateString()}");
                    break;
                }

            } while (true);

            Console.ReadKey();
        }
    }
}
