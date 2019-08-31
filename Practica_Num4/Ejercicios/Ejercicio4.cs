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

<<<<<<< HEAD
            int ventas ;
            double total = 0.0;
=======
            double ventas, total = 0.0;
>>>>>>> 762b9ed24164cbf5354e281040dffc6e3e53f615
            int contador = 0;
            do
            {
                Console.WriteLine("Ingrese el monto de la venta:");
<<<<<<< HEAD
                //ventas = Convert.ToDouble(Console.ReadLine());
                if(int.TryParse (Console.ReadLine(), out ventas))
                {

                    if (ventas == -1.0)
                    {

                    }
                    else
                    {
                        total += ventas;
                        contador++;
                    }
                }
                else
                {
                    Console.WriteLine("No Valido");
=======
                ventas = Convert.ToDouble(Console.ReadLine());
                if (ventas == -1.0)
                {

                }
                else
                {
                    total += ventas;
                    contador++;
>>>>>>> 762b9ed24164cbf5354e281040dffc6e3e53f615
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
