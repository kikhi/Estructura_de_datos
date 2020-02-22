using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3_Uso_de_Métodos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trujilo Garay Cesar Andres
            // Problema 3 Uso de Métodos

            string nombre;
            int semestre;
            int numero_control;
            string[] materias_1 = { "Mate. Discretas", "Calculo", "Etica", "Fundamentos de programacion", "Administracion" };
            int[] promedio_1 = { 8, 9, 8, 6, 6 };
            string[] materias_2 = { "Probabilidad y estadistica", "Quimica", "Fisica", "Programacion", "Estructura de datos" };
            int[] promedio_2 = { 10, 9, 8, 8, 7 };

            //Captura de datos
            Console.WriteLine("Nombre del alumno: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Semestre: ");
            semestre = int.Parse(Console.ReadLine());
            Console.WriteLine("numero de control: ");
            numero_control = int.Parse(Console.ReadLine());
            
            //Manda llamar metodo cardex
            Kardex(materias_1, materias_2, nombre, semestre, numero_control, promedio_1, promedio_2);
        }
        public static void Kardex(string[] materias_1, string[] materias_2, string nombre, int semestre, int numero_control, int[] promedio1, int[] promedio2)
        {
            Console.WriteLine("Las materias de primer semestre son:");
            for (int e = 0; e < promedio1.Length; e++)
            {
                foreach (string i in materias_1)
                {
                    Console.WriteLine("{0} {1}", i, promedio1[e]);
                }
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine("Las materias del segundo semestre son:");
            for (int e = 0; e < promedio2.Length; e++)
            {
                foreach (string i in materias_2)
                {
                    Console.WriteLine("{0} {1}", i, promedio1[e]);
                }
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine("Nombre del alumno: {0}", nombre);
            Console.WriteLine("Semestre: {0}", semestre);
            Console.WriteLine("Numero de control: {0}", numero_control);
            Console.WriteLine("El promedio final de el primer semestre es: {0}", promedio1.Sum() / 6);
            Console.WriteLine("El promedio final de el segundo semestre es: {0}", promedio2.Sum() / 6);
            Console.ReadLine();
        }
    }
}
