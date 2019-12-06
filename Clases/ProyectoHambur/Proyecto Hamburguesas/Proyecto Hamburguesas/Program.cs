using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Hamburguesas
{
    class Program
    {
        private static string c;

        static void Main(string[] args)
        {
            int p = 0;
            string Cremas = "";

            Console.WriteLine("/////    Bienvenido a Glotones51    /////");
            Console.WriteLine();
            Console.WriteLine(" /\\     __");
            Console.WriteLine("   \\ .-':::. ");
            Console.WriteLine("    \\ ::::: |\\ ");
            Console.WriteLine("   |,\\:::' /  \\ ");
            Console.WriteLine("    `.:::-'    \\");
            Console.WriteLine("      `-.       \\          ___");
            Console.WriteLine("          `-.    |      .-'';:::.");
            Console.WriteLine("             `-.-'     / ',''.;;;\\");
            Console.WriteLine("                      |  ','','.''|");
            Console.WriteLine("                      |\\  ' ,',' /'");
            Console.WriteLine("                       `.`-.___.-;'");
            Console.WriteLine("                         `--._.-'");
            Console.WriteLine();

            Console.WriteLine("Eliga el numero de su pedido:");
            Console.WriteLine("1.Salchipapa");
            Console.WriteLine("2.Hamburguesa");
            Console.WriteLine("3.Pollo Broster");
            Console.WriteLine();

            p = Convert.ToInt32(Console.ReadLine());
            if (1 == p)
            {
                Console.WriteLine("Cuales son las cremas para su SALCHIPAPA");
                Console.WriteLine();
                Cremas = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Confirmamos su pedido:");
                Console.WriteLine("Una SALCHIPAPA con cremas "+Cremas);


            }
            
            if (2 == p)
            {
                Console.WriteLine("Cuales son las cremas para su HAMBURGUESA");
                Console.WriteLine();
                Cremas = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Confirmamos su pedido:");
                Console.WriteLine("Una HAMBURGUESA con cremas " + Cremas);
            }


            if (3 == p)
            {
                Console.WriteLine("Cuales son las cremas para su POLLO BROASTER");
                Console.WriteLine();
                Cremas = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Confirmamos su pedido:");
                Console.WriteLine("Un POLLO BROASTER con cremas " + Cremas);
            }

            else
            {
                if (p >= 4)
                {
                    Console.WriteLine("No es una opcion valida");
                }
                if (p < 0)
                {
                    Console.WriteLine("No es una opcion valida");
                }
            }

            Console.ReadLine();
        }
    }
}
