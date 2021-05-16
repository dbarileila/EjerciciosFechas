using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CAIGUIAFECHAS_EJR24
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite el ingreso de una fecha al usuario utilizando, estrictamente, el formato dd/MM/yyyy

            do
            {

                Console.Write("Ingrese una fecha con el formato dd/MM/yyyy: ");
                string ingreso = Console.ReadLine();
                
                if (!string.IsNullOrEmpty(ingreso))
                {
                    var dateTimeFormat = CultureInfo.InvariantCulture.DateTimeFormat;
                    var date = DateTime.ParseExact(ingreso, "dd/MM/yyyy", dateTimeFormat);

                    Console.WriteLine($"Usted ingreso: {ingreso}");

                    break;
                }
                else
                {
                    Console.WriteLine("Debe ingresar una fecha válida.");
                    continue;
                }


            } while (true);

            Console.ReadKey();
        }
    }
}
