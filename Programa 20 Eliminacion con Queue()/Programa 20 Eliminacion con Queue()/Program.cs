using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_20_Eliminacion_con_Queue__
{
    class Procesos
    {
        public static void configuracion()
        {
            Console.Title = "Programa 20 Eliminacion con Queue()";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void menu(Queue<string> nombre, int menu, int F, string nombre_S, int dato, int I)
        {
            Console.WriteLine("====================Programa 20 Eliminacion con Queue()======================");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Desea ingresar nombre?");
            Console.WriteLine("0- Salir \n1- Ingresar \n2- Eliminar \n3- Mostrar");
            Console.WriteLine("-----------------------------------------------------------------------------");
            menu = int.Parse(Console.ReadLine());
            if (menu == 1)
            {
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine("Ingrese elnombre:");
                    nombre_S = Console.ReadLine();

                    insercion(nombre, menu, F, nombre_S, dato, I);
                }
                Procesos.menu(nombre, menu, F, nombre_S, dato, I);

            }
            else if(menu == 2)
            {
                nombre.Dequeue();
                Procesos.menu(nombre, menu, F, nombre_S, dato, I);
            }
            else if (menu == 3)
            {
                Procesos.mostrar(nombre, menu, F, nombre_S, dato, I);
            }
            else
            {
                Environment.Exit(0);
            }
        }
        public static void insercion(Queue<string> nombre, int menu, int F, string nombre_S, int Dato, int I)
        {
            F++;
            nombre.Enqueue(nombre_S);
            
            if (I == -1)
            {
                I = 0;
            }
        }
        public static void mostrar(Queue<string> nombre, int menu, int F, string nombre_S, int Dato, int I)
        {
            foreach (var item in nombre)
            {
                Console.WriteLine("Nombre: {0}", item);
                Console.ReadKey();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> nombre = new Queue<string>();
            int menu = 0;
            int F = 0;
            string nombre_S = "";
            int dato = 0;
            int I = 0;

            Procesos.configuracion();
            Procesos.menu(nombre, menu, F, nombre_S, dato, I);
            Procesos.mostrar(nombre, menu, F, nombre_S, dato, I);
            
            Console.ReadKey();
        }
    }
}
