using System;
using System.Collections.Generic;
using System.Threading;

namespace Gladys_Itics_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parte Inicial del Proyecto");
            Console.WriteLine("Registro de Series Televisivas");
            Dictionary<string, string> series = new Dictionary<string, string>();
            int opcion; string nombre; string descripcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Por favor seleccione una opción:");
                Console.WriteLine("         1.-  Ingresar Nueva Serie");
                Console.WriteLine("         2.-  Buscar Serie por Nombre");
                Console.WriteLine();
                Console.WriteLine("         0.-  Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Fin Aplicación");
                        Thread.Sleep(3000);
                        break;
                    case 1:
                        Console.WriteLine("Por favor ingrese el Nombre de la Serie:");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Por favor ingrese una descripción para esta serie:");
                        descripcion = Console.ReadLine();
                        break;
                    case 2:
                        if (series != null)
                        {
                            Console.WriteLine("Por favor ingrese la Serie que desea Consultar");
                        }
                        else
                        {
                            Console.WriteLine("No hay Series en archivo");
                        }
                        break;
                    default:
                        break;
                }
            } while (opcion != 0) ;
            Console.WriteLine("Fin del Proyecto");
        }
    }
}
