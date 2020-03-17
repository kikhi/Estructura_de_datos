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
            Console.Title = "Programa 14 insercion y eliminacion"; 
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        static int insertar(ref Stack<string> nombre,ref Stack<int> calificacion, float promedio, float cuenta, int i = 1)
        {
            cuenta = cuenta + 1;
            Console.WriteLine("==============Programa 14 insercion y eliminacion====================");
            Console.Write("Ingresar nombre: ");
            string insercion = Console.ReadLine();
            Console.Write("Ingresa calificacion: ");
            int insercion_C = int.Parse(Console.ReadLine());

            Console.Clear();

            if (nombre.Count == 40)
            {
                Console.WriteLine("La pila esta llena");
                Console.ReadKey();
                Console.Clear();
                return 0;
            }
            else
            {
                nombre.Push(insercion);
                calificacion.Push(insercion_C);
                Console.WriteLine("Desea ingresar otro dato");
                Console.WriteLine("0- No");
                Console.WriteLine("1- Si");
                i = int.Parse(Console.ReadLine());
                Console.Clear();
                return i;
            }
        }
        public static void MostrarInsercion(Stack<string> nombre, Stack<int> calificacion, double promedio, double cuenta)
        {
            if (calificacion.Count > 0)
            {
                Console.WriteLine("");
                foreach (int dato in calificacion)
                {
                    Console.WriteLine(dato);   
                }
                foreach (string nom in nombre)
                {
                    Console.WriteLine(nom);

                }
                promedio = promedio / cuenta;
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Promedio general: {0}", promedio);
                Console.WriteLine("Cantidad de nombres en la pila: {0}", calificacion.Count);
                Console.WriteLine("Cantidad de calificaciones en la pila: {0}", calificacion.Count);
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Preciona cualquier tecla para continuar:");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static int eliminar_p(ref Stack<string> nombres, ref Stack<int> calificacion)
        {
            if (nombres.Count > 0)
            {
                Console.WriteLine("Eliminaras este elemento: {0}", nombres.Peek());
                Console.ReadKey();
                string valor = (string)nombres.Pop();
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
        static void MostrarEliminacion(Stack<string> nombres)
        {
            if (nombres.Count > 0)
            {
                Console.WriteLine("Tamaño de la pila");
                foreach (string dato in nombres)
                {
                    Console.WriteLine(dato);
                }
            }
            Console.ReadKey();
        }
        class Program
        {
            static float promedio;
            static float cuenta;
            static void Main(string[] args)
            {
                //Trujillo Garay Cesar Andres
                //Programa 14 insercion y eliminacion

                int insertar = 1;
                int eliminar = 1;
                Stack<string> nombres = new Stack<string>(40);
                Stack<int> calificacion = new Stack<int>(40);

                Procesos.configuracion();

                while (insertar == 1)
                {
                    insertar = Procesos.insertar(ref nombres, ref calificacion, promedio, cuenta);
                }
                Procesos.MostrarInsercion(nombres, calificacion, promedio, cuenta);

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
                        eliminar = eliminar_p(ref nombres, ref calificacion);
                    }
                }
                Procesos.MostrarEliminacion(nombres);
            }            
        }
    }
}