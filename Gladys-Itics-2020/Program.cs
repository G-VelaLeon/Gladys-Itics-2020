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
                        Console.WriteLine($"Serie ingresada con Exito: {series.TryAdd(nombre,descripcion)}");
                        break;
                    case 2:
                        if (series != null)
                        {
                            foreach (var item in series.Keys)
                            {
                                Console.WriteLine(item);
                            }
                            Console.WriteLine("Por favor ingrese la Serie que desea Consultar");
                            nombre = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine(series[nombre]);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Actualmente no hay Series Archivadas");
                            Thread.Sleep(5000);
                        }
                        break;
                    default:
                        Console.WriteLine("La opción ingresada no es valida");
                        Thread.Sleep(5000);
                        break;
                }
            } while (opcion != 0) ;
            Console.WriteLine("Fin del Proyecto");
        }
    }
}
