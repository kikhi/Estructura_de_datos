using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_16_Menu_de_opciones_con_pilas
{
    class Procesos
    {
        public static void configuracion()
        {
            Console.Title = "Programa 16 Menu de opciones con pilas";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void menu(int menu, ref Stack<string> ciudades, ref Stack<int> precios)
        {
            Console.WriteLine("=================Programa 16 Menu de opciones con pilas==============");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("1- Insercion");
            Console.WriteLine("2- Eliminacion");
            Console.WriteLine("3- Recorrido de pila");
            Console.WriteLine("4- Salida");
            Console.WriteLine("---------------------------------------------------------------------");
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Insertar(menu, ref ciudades, ref precios);
                    break;
                case 2:
                    eliminar(menu, ref ciudades, ref precios);
                    break;
                case 3:
                    recorrido(menu, ref ciudades, ref precios);
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }

        public static void Insertar(int menu, ref Stack<string> ciudades, ref Stack<int> precios)
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.Write("Ingresar ciudad: ");
            string insercion_ciudades = Console.ReadLine();
            Console.Write("Ingresar precio: ");
            int insercion_precios = int.Parse(Console.ReadLine());

            Console.Clear();

            if (ciudades.Count == 50)
            {
                Console.WriteLine("La pila esta llena");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                ciudades.Push(insercion_ciudades);
                precios.Push(insercion_precios);
            }
            Procesos.menu(menu, ref ciudades, ref precios);
        }

        public static void recorrido(int menu, ref Stack<string> ciudades, ref Stack<int> precios)
        {
            if (ciudades.Count > 0)
            {
                foreach (string dato in ciudades)
                {
                    foreach (int datos in precios)
                    {
                        Console.WriteLine("Ciudad: {0}, Precio: {1}", dato, datos);
                    }
                }
                Console.ReadKey();
                Console.Clear();
                Procesos.menu(menu, ref ciudades, ref precios);
            }
        }
        static void eliminar(int menu, ref Stack<string> ciudades, ref Stack<int> precios)
        {
            if (ciudades.Count > 0)
            {
                string valor = ciudades.Pop();
                Console.WriteLine("Elemento " + valor + " eliminado");
            }
            else
            {
                Console.WriteLine(ciudades);
            }
            Console.ReadLine();
            Procesos.menu(menu, ref ciudades, ref precios);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Trujillo Garay Cesar Andres
            //Programa 16 Menu de opciones con pilas

            int menu = 0;
            Stack<string> ciudades = new Stack<string>(50);
            Stack<int> precios = new Stack<int>(50);

            Procesos.configuracion();
            Procesos.menu(menu, ref ciudades, ref precios);
        }
    }
}
