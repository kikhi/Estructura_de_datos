using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_5_manejo_de_TDA_y_estructuras_estaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trujiloo Garay Cesar Andres
            // Programa 5 manejo de TDA y estructuras estaticas

            string[] alumnos = new string[4];
            string[] c_estructura = new string[4];
            string[] c_vectorial = new string[4];
            

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Capturas.menu(alumnos, c_estructura, c_vectorial);
         
            Console.ReadKey();
        }
    }
    class Capturas
    {
        
        public static void menu(string[] alumnos, string[] c_estructura, string[] c_vectorial)
        {
            int menu;
            Console.WriteLine("=================Sistema de calificaciones======================");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("1- Capturar \n2- Salir");
            Console.WriteLine("----------------------------------------------------------------");
            menu = int.Parse(Console.ReadLine());
            if(menu == 1)
            {
                capturar(alumnos, c_estructura, c_vectorial);
            }
            else
            {
                Environment.Exit(0);
            }
        }
        public static void menu2(string[] alumnos, int[] c_estructuraN, int[] c_vectorialN)
        {
            int menu;
            Console.WriteLine("=================Sistema de calificaciones======================");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("1- Mostrar \n2- Salir");
            Console.WriteLine("----------------------------------------------------------------");
            menu = int.Parse(Console.ReadLine());
            if (menu == 1)
            {
                mostrar(alumnos, c_estructuraN, c_vectorialN);
            }
            else if (menu == 2)
            {
                Environment.Exit(0);
            }
            
        }
        public static void capturar(string[] alumnos, string[] c_estructura, string[] c_vectorial)
        {
            int[] c_estructuraN = new int[4];
            int[] c_vectorialN = new int[4];
            Console.Clear();
            Console.WriteLine("=========================Captura de datos============================");
            Console.WriteLine("--------------------------------------------------------------------");
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Nombre del alumno:");
                alumnos[i] = Console.ReadLine();
                Console.WriteLine("Ingresa calificacio de E.D:");
                c_estructura[i] = Console.ReadLine();
                c_estructuraN[i] = int.Parse(c_estructura[i]);
                Console.WriteLine("Ingresa calificacio de calculo vectorial:");
                c_vectorial[i] = Console.ReadLine();
                c_vectorialN[i] = int.Parse(c_vectorial[i]);

            }
            Console.WriteLine("--------------------------------------------------------------------");
            menu2(alumnos, c_estructuraN, c_vectorialN);
        }
        public static void mostrar(string[] alumnos, int[] c_estructura, int[] c_vectorial)
        {
            Console.Clear();
            //Promedio general c/u materias
            Console.WriteLine("---------------=-Promedio de las dos materias-----------------------");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Promedio general de E.D: {0}", c_estructura.Sum() / 5);
            Console.WriteLine("Promedio general de calculo: {0}", c_vectorial.Sum() / 5);
            Console.WriteLine("--------------------------------------------------------------------");
            //Nombre de los estudiantes
            Console.WriteLine("-------------------Nombre de los estudiantes------------------------");
            Console.WriteLine("--------------------------------------------------------------------");
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("{0}- Nombre: {1}", i + 1, alumnos[i]);
            }
            Console.WriteLine("--------------------------------------------------------------------");
            //Calificacion de los estudiantes en ambas materias
            Console.WriteLine("-----------------Calificacion en ambas materias---------------------");
            Console.WriteLine("--------------------------------------------------------------------");
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("{0}- {1} Estructura de datos: {2}, Calculo vectorial {3}",i + 1, alumnos[i], c_estructura[i], c_vectorial[i]);
            }
            Console.WriteLine("--------------------------------------------------------------------");
            //Promedio general
            Console.WriteLine("-------------------------Promedio general---------------------------");
            Console.WriteLine((c_estructura.Sum() + c_vectorial.Sum()) / 10);
            Console.WriteLine("--------------------------------------------------------------------");

            //Mostrar en cual de las dos tuvo mayor promedio
            Console.WriteLine("-----------------Cual de los dos tiene mayor promedio---------------");
            Console.WriteLine("--------------------------------------------------------------------");
            for (int i = 0; i <= 3; i++)
            {
                
                if (c_estructura[i] < c_vectorial[i])
                {
                    Console.WriteLine("{0}- {1} Obtuvo mayor promedio en: Calculo vectorial",i + 1, alumnos[i]);
                }
                else
                {
                    Console.WriteLine("{0}- {1} Obtuvo mayor promedio en: Estructura de datos", i + 1, alumnos[i]);
                }
            }
            Console.WriteLine("--------------------------------------------------------------------");


        }
    }
}
