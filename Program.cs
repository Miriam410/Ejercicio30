using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            // 30. Solicite el ingreso de una fecha al usuario y muestre sólo la hora
            string fecha;
            DateTime salidaFecha;
            bool flag=false ;
            do
            {
                Console.WriteLine("Ingrese una fecha");
                fecha = Console.ReadLine();
                if (!DateTime.TryParse(fecha, out salidaFecha))
                {
                    Console.WriteLine("Usted no ha ingresado una fecha");
                }
                else
                {
                    flag = true;
                    Console.WriteLine($"La fecha ingresada, se muestra la hora que es {salidaFecha.ToString("hh:mm:ss")}");
                    Console.WriteLine("Presione una tecla para salir");
                }
            } while (flag==false);
            Console.ReadKey();
        }   
    }
}
