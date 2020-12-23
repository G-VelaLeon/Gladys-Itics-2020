using System;
using System.Collections.Generic;

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
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    default:
                        break;
                }
            } while (opcion != 0) ;
            Console.WriteLine("Fin del Proyecto");
        }
    }
}
