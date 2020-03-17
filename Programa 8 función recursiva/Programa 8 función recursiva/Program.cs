using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_8_función_recursiva
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trujillo Garay Cesar Andres
            // Programa 8 función recursiva

            string nombre;
            int[] sueldos = new int[3];

            Procesos p = new Procesos();
            p.configuracion();
            p.nombre();
            nombre = Console.ReadLine();
            p.sueldo(sueldos);

            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("El sueldo mayor es: {0}", Procesos.Mayor(sueldos, 0, sueldos[0]));
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("El sueldo menor es: {0}", Procesos.Menor(sueldos, 0, sueldos[0]));
            Console.WriteLine("------------------------------------------------------------------------------");


            Console.WriteLine(nombre);
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(sueldos[i]);
            }
            Console.ReadLine();

            
        }
        
    }
    class Procesos
    {
        public void configuracion()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public void nombre()
        {
            Console.WriteLine("=======================Programa 8 función recursiva===========================");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Ingresa nombre del empleado");
            Console.WriteLine("------------------------------------------------------------------------------");
            
        }
        public void sueldo(int[] sueldos)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Ingresa sueldo {0}:", i + 1);
                sueldos[i] = int.Parse(Console.ReadLine());
            }
        }
        public static int Mayor(int[] sueldos, int n, int mayor)
        {
            if (n == sueldos.Length)
                return mayor;

            if (sueldos[n] > mayor)
                mayor = sueldos[n];

            return Mayor(sueldos, ++n, mayor);
        }
        public static int Menor(int[] sueldos, int n, int menor)
        {
            if (n == sueldos.Length)
                return menor;

            if (sueldos[n] < menor)
                menor = sueldos[n];

            return Menor(sueldos, ++n, menor);
        }

    }
}
