using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_7_Indice_de_un_caracter_en_especifico
{
    class Procesos
    {
        public static void configuracion()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void menu(string frase)
        {
            int opcion;

            Console.Clear();
            Console.WriteLine("==================Programa 7 Indice de un caracter en especifico=================");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Tenemos el la frase: ESTO ES SOLO UNA PRUEBA");
            Console.WriteLine("1- Obtener tamaño \n2- Recortar \n3- Ambos \n4-Salir");
            Console.WriteLine("---------------------------------------------------------------------------------");
            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Procesos.tamaño(frase);
            }
            else if (opcion == 2)
            {
                Procesos.recortar(frase);
            }
            else if (opcion == 3)
            {
                Procesos.ambas(frase);
            }
            else
            {
                Environment.Exit(0);
            }

        }
        public static void tamaño(string frase)
        {
            int frase_N;
            frase_N = frase.Length;

            Console.Clear();
            Console.WriteLine("==============================Tamaño de la frase=================================");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("ESTO ES SOLO UNA PRUEBA");
            Console.WriteLine("Al recortar de la primera let {0} caracteres", frase_N);
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Teclea cualquier cosapara continuar");
            Console.ReadKey();
            menu(frase);
        }
        public static void recortar(string frase)
        {
            string frase_R;
            frase_R = frase.Substring(0, 4);

            Console.Clear();
            Console.WriteLine("==============================Tamaño de la frase=================================");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("ESTO ES SOLO UNA PRUEBA");
            Console.WriteLine("recortada es {0}", frase_R);
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Teclea cualquier cosapara continuar");
            Console.ReadKey();
            menu(frase);
        }
        public static void ambas(string frase)
        {
            int frase_N;
            frase_N = frase.Length;
            string frase_R;
            frase_R = frase.Substring(0, 4);

            Console.Clear();
            Console.WriteLine("==============================Tamaño de la frase=================================");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("ESTO ES SOLO UNA PRUEBA");
            Console.WriteLine("La palabra tiene {0} caracteres, recortada es {1}", frase_N, frase_R);
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Teclea cualquier cosapara continuar");
            Console.ReadKey();
            menu(frase);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Trujillo Garay Cesar Andres
            // Programa 7 Indice de un caracter en especifico

            string frase = "ESTO ES SOLO UNA PRUEBA";

            Procesos.configuracion();
            Procesos.menu(frase);
            Console.ReadKey();
            
        }
    }
}
