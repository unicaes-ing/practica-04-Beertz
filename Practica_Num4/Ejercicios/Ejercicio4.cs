using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Num4.Ejercicios
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {

            double ventas, total = 0.0;
            int contador = 0;
            do
            {
                Console.WriteLine("Ingrese el monto de la venta:");
                ventas = Convert.ToDouble(Console.ReadLine());
                if (ventas == -1.0)
                {

                }
                else
                {
                    total += ventas;
                    contador++;
                }

            } while (ventas != -1.0);

            Console.WriteLine("Cantidad de ventas: {0:N2}", contador);
            Console.WriteLine("Dinero en ventas: {0:C2}", total);
            Console.WriteLine("Ventas + 5% de bono: {0:C2}", (total + (total * 0.05)));
            Console.ReadKey(); 
            Console.ReadKey();
        }
    }
}
