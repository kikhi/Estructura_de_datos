using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_22_Listas_enlazadas
{
    class Lista
    {
        int C1 = 0;
        int C2 = 0;
        int C3 = 0;
        int C4 = 0;

        double D1 = 0;
        double D2 = 0;
        double D3 = 0;
        double D4 = 0;

        private Nodo Dato_A = new Nodo();
        private Nodo Dato_Z = new Nodo();

        public Lista()
        {
            Dato_A = null;
            Dato_Z = null;
        }
        public void Inserta_Nodo()
        {
            Nodo Nuevo = new Nodo();
            Console.WriteLine("Ingresa edad: ");
            Nuevo.Dato = int.Parse(Console.ReadLine());

            if (Nuevo.Dato <= 70 && Nuevo.Dato >= 5)
            {
                if (Nuevo.Dato <= 10 && Nuevo.Dato >= 5)
                {
                    C1 = C1 + 1;
                    D1 = D1 + 15;
                }
                else if (Nuevo.Dato <= 17 && Nuevo.Dato >= 11)
                {
                    C2 = C2 + 1;
                    D2 = D2 + 25;
                }
                else if (Nuevo.Dato <= 60 && Nuevo.Dato >= 18)
                {
                    C3 = C3 + 1;
                    D3 = D3 + 35;
                }
                else if (Nuevo.Dato <= 69 && Nuevo.Dato >= 61)
                {
                    C4 = C4 + 1;
                    D4 = D4 + 12;
                }
                if (Dato_A == null)
                {
                    Dato_A = Nuevo;
                    Dato_A.Siguiente = null;
                    Dato_Z = Nuevo;
                }
                else
                {
                    Dato_Z.Siguiente = Nuevo;
                    Nuevo.Siguiente = null;
                    Dato_Z = Nuevo;
                }
                Console.WriteLine("Nodo ingresado satisfactoriamente");
            }
            else
            {
                Console.WriteLine("Edad invalida");
            }
        }
        public void Numero_Personas()
        {
            Console.WriteLine("cantidad de personas: ");
            Console.WriteLine("Personas de 5 a 10 años: {0}", C1);
            Console.WriteLine("Personas de 11 a 17 años: {0}", C2);
            Console.WriteLine("Personas de 18 a 60 años: {0}", C3);
            Console.WriteLine("Personas mayor de 60 años: {0}", C4);
            Console.ReadKey();
        }

        public void Cantidad_Personas()
        {
            double cantidad = D1 + D2 + D3 + D4;

            Console.WriteLine("Dinero ganado: {0}", cantidad);
            Console.ReadKey();
        }
        public void Desplegar()
        {
            Nodo Actual = new Nodo();
            Actual = Dato_A;

            if (Dato_A != null)
            {
                while (Actual != null)
                {
                    Console.WriteLine("Edad: {0}", Actual.Dato);
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("Lista vacia");
            }
        }
    }
    class Procesos
    {
        public static void configuracion()
        {
            Console.Title = "Programa 22 Listas enlazadas";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        static public void Menu()
        {
            Lista i = new Lista();
            Console.Clear();

            Console.WriteLine("==================Programa 22 Listas enlazadas====================");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("1 - Inserta edad");
            Console.WriteLine("2 - Personas por rangos");
            Console.WriteLine("3 - Cantidad de personas queentraron");
            Console.WriteLine("4 - Mostrar Las edades");
            Console.WriteLine("5 - Salir");
            Console.WriteLine("------------------------------------------------------------------");
            int menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
            case 1:
                i.Inserta_Nodo();
                Console.ReadKey();
                Console.Clear();
                Menu();
                break;
            case 2:
                i.Numero_Personas();
                Console.ReadKey();
                Console.Clear();
                Menu();
                break;
            case 3:
                i.Cantidad_Personas();
                Console.ReadKey();
                Console.Clear();
                Menu();
                break;
            case 4:
                i.Desplegar();
                Console.ReadKey();
                Console.Clear();
                Menu();
                break;
            case 5:
                    Environment.Exit(0);
                break;
            default:
            break;
            }
        }
    }
    class Nodo
    {
        static Lista i = new Lista();
        private int dato;
        private Nodo Otro;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodo Siguiente
        {
            get { return Otro; }
            set { Otro = value; }
        }
    }
    class Program
    {
        public Lista i = new Lista();
        static void Main(string[] args)
        {
            Procesos.configuracion();
            Procesos.Menu();
        }
    }
}
