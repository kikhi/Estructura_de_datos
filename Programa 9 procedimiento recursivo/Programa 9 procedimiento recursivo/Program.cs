using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_9_procedimiento_recursivo
{
    class Procesos
    {
        public static void configuracion()
        {
            Console.Title = "Programa 9 procedimiento recursivo";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void menu()
        {
            Console.WriteLine("=======================Programa 9 procedimiento recursivo=====================");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Toca cualquier tecla para continuar");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.ReadLine();
        }
        public static void nombres(string[] nombres)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.Write("Ingresa el nombre de la persona numero {0}: ", i + 1);
                nombres[i] = Console.ReadLine();
            }
        }
        public static void edades(int[] edades)
        {
            for (int z = 0; z <= 2; z++)
            {
                Console.Write("Ingresa el edad de la persona numero {0}: ", z + 1);
                edades[z] = int.Parse(Console.ReadLine());
            }
        }
        public static string numero_mayor(int[] edades, string[] nombres, int i, int mayor, string nom)
        {
            if (i == edades.Length)
            {
                return nom;
            }
            if (edades[i] < mayor)
            {
                mayor = edades[i];
                nom = nombres[i];
            }
            return numero_mayor(edades, nombres, ++i, mayor, nom);
        }
        public static int persona_mayor(int[] edades, int i, int mayor)
        {
            if (i == edades.Length)
                return mayor;
            
            if (edades[i] > mayor)
                mayor = edades[i];
                return persona_mayor(edades, ++i, mayor);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Trujillo Garay Cesar Andres
            // Programa 9 procedimiento recursivo

            string[] nombres = new string[3];
            int[] edades = new int[3];

            Procesos.configuracion();
            Procesos.menu();
            Console.Clear();
            Procesos.nombres(nombres);
            Procesos.edades(edades);
            Console.Clear();
            Console.WriteLine("============================Resultados========================================");
            Console.WriteLine("------------------------------------------------------------------------------");
            for (int p = 0; p <= 2; p++)
            {
                Console.WriteLine("La persona numero {0} {1}, tiene {2} años", p + 1, nombres[p], edades[p]);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("La edad mayor es de {0} años y es de {1}", Procesos.persona_mayor(edades, 0, edades[0]), Procesos.numero_mayor(edades, nombres, 0, 0, ""));
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Presiona cualquier tecla para salir");
            Console.ReadLine();
        }
    }
}
