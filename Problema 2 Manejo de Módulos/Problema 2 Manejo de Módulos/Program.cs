using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2_Manejo_de_Módulos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trujillo Garay Cesar Andres
            // Problema 2 Manejo de Módulos

            int dia;
            int mes;
            int año;
            string articulo1;
            double precioA1;
            string articulo2;
            double precioA2;
            string articulo3;
            double precioA3;

            //Ingresa los datos de la fecha
            Console.WriteLine("Fecha (dd/mm/aaaa)");
            Console.WriteLine("Dia");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Dia");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Dia");
            año = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------------------------");

            //Ingresa los datos de compra
            Console.WriteLine("Ingresa nombre del articulo 1");
            articulo1 = Console.ReadLine();
            Console.WriteLine("Ingresa precio del articulo 1");
            precioA1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa nombre del articulo 2");
            articulo2 = Console.ReadLine();
            Console.WriteLine("Ingresa precio del articulo 2");
            precioA2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa nombre del articulo 3");
            articulo3 = Console.ReadLine();
            Console.WriteLine("Ingresa precio del articulo 3");
            precioA3 = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------------------------");

            //Ticket
            Ticket(precioA1, precioA2, precioA3, articulo1, articulo2, articulo3);
            Console.WriteLine("fecha de compra {0}/{1}/{2}", dia, mes, año);
            Console.WriteLine();
            

        }
        public static void Ticket(double precioA1, double precioA2, double precioA3, string articulo1, string articulo2, string articulo3)
        {
            double iva1 = precioA1 * .15;
            double iva2 = precioA2 * .15;
            double iva3 = precioA3 * .15;

            Console.WriteLine("El iva del primer articulo es: {0}", iva1);
            Console.WriteLine("El iva del segundo articulo es: {0}", iva2);
            Console.WriteLine("El iva del tercer articulo es: {0}", iva3);

            double final1 = iva1 + precioA1;
            double final2 = iva1 + precioA2;
            double final3 = iva1 + precioA3;

            Console.WriteLine("Ticket generado");
            Console.WriteLine("Precio final: {0}, Articulo: {1}", final1, articulo1);
            Console.WriteLine("Precio final: {0}, Articulo: {1}", final2, articulo2);
            Console.WriteLine("Precio final: {0}, Articulo: {1}", final3, articulo3);
            Console.WriteLine("El total de la compra es: {0}", final1 + final2 + final3);

            Console.ReadLine();
        }
    }
}
