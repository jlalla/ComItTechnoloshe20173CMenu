using System;

namespace Calculadora
{
    class Program
    {
        /// <summary>
        /// Muestra el menú de la aplicación.
        /// </summary>
        static void MostrarMenu()
        {
            Console.WriteLine("Qué querés hacer?");
            Console.WriteLine();
            Console.WriteLine("1- Sumar dos números");
            Console.WriteLine("2- Multiplicar dos números");
            Console.WriteLine("0- Salir");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora");
            MostrarMenu();

            int opcion = int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    //sumar TODO
                    break;
                case 2:         
                    //multiplicar TODO           
                    break;
                default:
                    Console.WriteLine("Opción inválida");                    
                    MostrarMenu();
                    break;            
            }

        }
    }
}
