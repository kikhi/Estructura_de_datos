using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_15_insercion_y_eliminacion
{
    class Procesos
    {
        public static void configuracion()
        {
            Console.Title = "Programa 15 insercion y eliminacion";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        static int insertar(ref Stack<int> edad, float promedio, float cuenta, int i = 1)
        {
            cuenta = cuenta + 1;
            Console.WriteLine("==============Programa 15 insercion y eliminacion====================");
            Console.Write("Ingresar Edad: ");
            int insercion = int.Parse(Console.ReadLine());
            promedio = insercion + promedio;

            Console.Clear();

            if (edad.Count == 100)
            {
                Console.WriteLine("La pila esta llena");
                Console.ReadKey();
                Console.Clear();
                return 0;
            }
            else
            {
                edad.Push(insercion);
                Console.WriteLine("Desea ingresar otro dato");
                Console.WriteLine("0- No");
                Console.WriteLine("1- Si");
                i = int.Parse(Console.ReadLine());
                Console.Clear();
                return i;
            }
        }
        public static void MostrarInsercion(Stack<int> pila, double promedio, double cuenta)
        {
            if (pila.Count > 0)
            {
                Console.WriteLine("");
                foreach (int dato in pila)
                {

                    if (dato < 10)
                        Console.WriteLine(dato);
                    else
                        Console.WriteLine(dato);

                }
                promedio = promedio / cuenta;
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Promedio: {0}", promedio);
                Console.WriteLine("Cantidad de elementos en la pila: {0}", pila.Count);
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Preciona cualquier tecla para continuar:");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static int Eliminacion(ref Stack<int> Ed)
        {
            if (Ed.Count > 0)
            {
                Console.WriteLine("Eliminaras este elemento: {0}", Ed.Peek());
                Console.ReadKey();
                int valor = (int)Ed.Pop();
                Console.WriteLine("Elemento {0} eliminado", valor);
                Console.ReadKey();
                Console.Clear();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static void MostrarEliminacion(Stack<int> pila)
        {
            if (pila.Count > 0)
            {
                Console.WriteLine("Tamaño de la pila");
                foreach (int dato in pila)
                {
                    if (dato < 10)
                        Console.WriteLine(dato);
                    else
                        Console.WriteLine(dato);
                }
            }
            Console.ReadKey();
        }
        class Program
        {
            static float promedio;
            static float contador;
            static void Main(string[] args)
            {
                //Trujillo Garay Cesar Andres
                //Programa 15 insercion y eliminacion

                int insertar = 1;
                int eliminar = 1;
                Stack<int> Edades = new Stack<int>(100);

                Procesos.configuracion();

                while (insertar == 1)
                {
                    insertar = Procesos.insertar(ref Edades, promedio, promedio);
                }
                Procesos.MostrarInsercion(Edades, promedio, promedio);

                while (eliminar == 1)
                {
                    Console.WriteLine("=========================Eliminar===========================");
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Deseas eliminar algun dato de la pila?");
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("0- No");
                    Console.WriteLine("1- Si");
                    eliminar = Int16.Parse(Console.ReadLine());
                    Console.Clear();
                    if (eliminar == 1)
                    {
                        eliminar = Eliminacion(ref Edades);
                    }
                }
                Procesos.MostrarEliminacion(Edades);
            }
        }
    }
}