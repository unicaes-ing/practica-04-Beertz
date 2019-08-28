using System;

namespace Practica_Num4.Ejercicios
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            //Variables y Arreglos
            int llevaCuentas;
            decimal[] notas;
            int[] asistencia;


            //Confirmaciones
            bool C1 = false;
            bool C2 = false;

            //Proceso: Obtener datos.
            do
            {
                Console.Clear();
                Console.Write("Sistema de Califcación y Asistencia final: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Programación Estructurada");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Escriba el numero de Alumnos: ");
                if (int.TryParse(Console.ReadLine(), out llevaCuentas))
                {
                    //El programa puede entrar al siguiente proceso.

                    C1 = true;
                    do
                    {
                        for (int i = 0; i <= llevaCuentas - 1; i++)
                        {
                            notas = new decimal[llevaCuentas];
                            Console.Clear();
                            Console.Write("Escriba la nota del Num.{0}: ", i + 1);
                            if (decimal.TryParse(Console.ReadLine(), out notas[i]))
                            {

                                //El programa continua.
                                Console.Write("Porcentaje de asistencia: % ");
                                asistencia = new int[llevaCuentas];
                                if (int.TryParse(Console.ReadLine(), out asistencia[i]))
                                {

                                    //El programa continua
                                    C2 = true;

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Dato Incorrecto");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                //El programa vuelve a pedir el dato

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("----Dato invalido----");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ReadKey();
                                i = i - 1;
                            }


                        }


                    } while (C2 == false);
                }

                else
                {

                    //El programa vuelve a pedir el dato.

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("----Dato invalido-----");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                }

                

            } while (C1 == false);
        }
    }
}
