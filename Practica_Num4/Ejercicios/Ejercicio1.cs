using System;
using System.Threading;


namespace Practica_Num4
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            //Variables y Arreglos
            decimal[] sueldos;
            sueldos = new decimal[21];
            int i;


            //Recolección de datos
            do
            {
                for (i = 1; i <= 20; i++)
                {
                    Console.Clear();
                    Console.WriteLine("Escriba el sueldo del empleado Núm.{0}", i);
                    Console.Write("$ ");
                    if (decimal.TryParse(Console.ReadLine(), out sueldos[i]))
                    {
                        //El programa continua con normalidad.
                    }
                    else
                    {

                        Console.WriteLine("Dato ingresado no valido (No es un sueldo)");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Presione <Enter> para continuar");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        i = i - 1;
                    }

                }

            } while (i != 21);

            Console.Clear();
            Console.WriteLine("----Muestra de Sueldos----");
            for (int t = 1; t <= 20; t++)
            {
                Console.WriteLine("Sueldo del empleado Núm.{0}: ${1}", t, sueldos[t]);
            }


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--Se han mostrado todos los sueldos--");
            Console.ReadKey();

        }
    }
}


