using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUIAFECHA_EJR22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Presente al usuario la fecha actual con el siguiente formato: dd/MM/yyyy

            var fecha = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine($" Fecha actual: {fecha}");

            Console.ReadKey();

        }
    }
}
