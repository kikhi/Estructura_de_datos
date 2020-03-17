using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_19_insercion_con_Queue__
{
    class Procesos
    {
        public static void configuracion()
        {
            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void menu(Queue<int> edad, int menu, int f, int numero, int dato, int I)
        {
            Console.WriteLine("====================Programa 19 insercion con Queue()========================");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Desea ingresar edad?");
            Console.WriteLine("0- No \n1- Si");
            Console.WriteLine("-----------------------------------------------------------------------------");
            menu = int.Parse(Console.ReadLine());
            if (menu == 1)
            {
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine("Ingrese la edad:");
                    numero = Convert.ToInt32(Console.ReadLine());

                    insercion(edad, menu, f, numero, dato, I);
                }
            }
            else
            {
                
            }
        }
        public static void insercion(Queue<int> edad, int menu, int F, int nuemero, int Dato, int I)
        {

            if (Colallena(F) == 0)
            {
                Console.WriteLine("cola simple vacia");
            }
            else
            {
                F++;
                edad.Enqueue(nuemero);
            }
            if (I == -1)
            {
                I = 0;
            }
        }
        public static int Colallena(int f)
        {
            if (f == 12)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> edad = new Queue<int>(12);
            int menu = 0;
            int F = 0;
            int numero = 0;
            int dato = 0;
            int I = 0;

            Procesos.configuracion();
            Procesos.menu(edad, menu, F, numero,  dato,  I);
            Console.ReadKey();
        }
    }
}
