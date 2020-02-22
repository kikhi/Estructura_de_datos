using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1_General
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trujillo Garay Cesar Andres
            // Problema 1 General

            string nombre;
            int dia;
            int mes;
            int año;
            string direccion;
            double monto;

            //Ingresa nombre
            Console.WriteLine("Escribe tu nombre:");
            nombre = (Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------------------");

            //Ingresa Fecha
            Console.WriteLine("Fecha de nacimiento");
            Console.WriteLine("Dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Año: ");
            año = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------------------");

            //Ingresa direccion
            Console.WriteLine("Escribe tu direccion: ");
            direccion = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------------------------------");

            //Monto a haorrar
            Console.WriteLine("Ingresa tu monto a haorrar");
            monto = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------------------");

            //Impresion de los datos
            Console.WriteLine("Nombre Ingresado: {0}", nombre);
            Console.WriteLine("Fecha de nacimiento ingresada: {0}/{1}/{2}", dia, mes, año);
            Console.WriteLine("Direccion Ingresada: {0}", direccion);
            HaorroA(monto);
            HaorroB(monto);
            HaorroC(monto);
            Console.ReadLine();
        }

        //Haorro A
        public static void HaorroA(double monto)
        {
            double montoA;
            double retencionA;
            montoA = monto * 0.15;
            retencionA = monto * .02;
            Console.WriteLine("El haorro A es: {0} Mensuales sobre el saldo", montoA);
        }
        public static void HaorroB(double monto)
        {
            double montoA;
            double retencionA;
            montoA = monto * .10;
            retencionA = monto * .015;
            Console.WriteLine("El haorro A es: {0} Mensuales sobre el saldo", montoA);
        }
        public static void HaorroC(double monto)
        {
            double montoA;
            double retencionA;
            montoA = monto * 0.08;
            retencionA = monto * .05;
            Console.WriteLine("El haorro A es: {0} Mensuales sobre el saldo", montoA);
        }
    }
}
