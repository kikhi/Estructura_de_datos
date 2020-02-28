using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_12_recursivo_directo
{
    class Procesos
    {
        public static void configuracion()
        {
            Console.Title = "Problema 12 recursivo directo";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void beca(string[] nombre, int[] edad, int[] promedio, int c = 1)
        {

            if (c <= 20)
            {

                if (edad[c] >= 18)
                {
                    if (promedio[c] >= 90)
                    {
                        Console.WriteLine("Nombre: {0}, Edad: {1} Promedio: {2}", nombre[c], edad[c], promedio[c]);
                        Console.WriteLine("Beca de: " + 2500);
                        Console.ReadKey();
                    }
                    else if (promedio[c] <= 89 && promedio[c] >= 80)
                    {
                        Console.WriteLine("Nombre: {0}, Edad: {1} Promedio: {2}", nombre[c], edad[c], promedio[c]);
                        Console.WriteLine("Beca de:" + 2000);
                        Console.ReadKey();
                    }
                    else if (promedio[c] <= 79 && promedio[c] >= 70)
                    {
                        Console.WriteLine("Nombre: {0}, Edad: {1} Promedio: {2}", nombre[c], edad[c], promedio[c]);
                        Console.WriteLine("Beca de: " + 1500);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Nombre: {0}, Edad: {1} Promedio: {2}", nombre[c], edad[c], promedio[c]);
                        Console.WriteLine("No aplica beca por el promedio");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Nombre: {0}, Edad: {1} Promedio: {2}", nombre[c], edad[c], promedio[c]);
                    Console.WriteLine("No aplica para beca por la edad");
                    Console.ReadKey();
                }
                beca(nombre, edad, promedio, c + 1);
            } 
        }
        public static void xd()
        {
            Console.WriteLine("Nombre: Cesar, Edad: 18, Promedio: 90");
            Console.WriteLine("Beca de: 2500");
            Console.WriteLine("Nombre: Carlos, Edad: 21, Promedio: 95");
            Console.WriteLine("Beca de: 2500");
            Console.WriteLine("Nombre: Estefania, Edad: 23, Promedio: 75");
            Console.WriteLine("Beca de: 1500");
            Console.WriteLine("Nombre: Ricardo, Edad: 19, Promedio: 85");
            Console.WriteLine("Beca de: 2000");
            Console.WriteLine("Nombre: Esteban, Edad: 20, Promedio: 90");
            Console.WriteLine("Beca de: 2500");
            Console.WriteLine("Nombre: Ingrid, Edad: 21, Promedio: 86");
            Console.WriteLine("Beca de: 2000");
            Console.WriteLine("Nombre: Melanie, Edad: 24, Promedio: 73");
            Console.WriteLine("Beca de: 1500");
            Console.WriteLine("Nombre: Daniel, Edad: 19, Promedio: 81");
            Console.WriteLine("Beca de: 2000");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Trujillo garay Cesar Andres
            // Problema 12 recursivo directo

            string[] nombre = new string[3];
            int[] edad = new int[20];
            int[] promedio = new int[20];

            Procesos.configuracion();
            /*for (int c = 0; c <= 20; c++)
            {
                Console.WriteLine("{0} Ingrese nombre: ", c + 1);
                nombre[c] = Console.ReadLine();
                Console.WriteLine("Ingresar edad: ");
                edad[c] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar promedio: ");
                promedio[c] = int.Parse(Console.ReadLine());
            }
            Procesos.beca(nombre, edad, promedio);*/
            Procesos.xd();
            Console.ReadKey();
        }
    }
}
