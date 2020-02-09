using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_6_Manejo_de_string
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trujillo Garay Cesar Andres
            // Programa 6 Manejo de string

            string saludo = "";
            ConsoleKeyInfo repetir;

            Procesos.configuracion();
            Procesos.menu();
            Procesos.reemplazar(saludo);

            Console.Clear();
            Console.WriteLine("===================================Continuar=========================================");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("Continuar o salir del programa y/n");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            repetir = Console.ReadKey();
            if (repetir.KeyChar == 'y')
            {
                Procesos.menu();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
    class Procesos
    {
        public static void configuracion()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void menu()
        {
            Console.WriteLine("========================Programa 6 Manejo de string==================================");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("Hola usuario");
            Console.WriteLine("-------------------------------------------------------------------------------------");
        }
        public static void reemplazar(string saludo)
        { 
            string saludo_reemplazado;
            saludo = Console.ReadLine();
            saludo_reemplazado = saludo.Replace("a", "o");
            Console.Clear();
            Console.WriteLine("=======================Mostrar saludo norma y reemplazado============================");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine(saludo);
            Console.WriteLine(saludo_reemplazado);
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("Preciona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
