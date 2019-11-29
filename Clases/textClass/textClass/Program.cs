using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textClass {
    class Program {
        static void Main(string[] args) {

            string secretWord = "Zapato";
            string letter = "";
            int hp = 3;

            //Console.WriteLine(secretWord.Length);
            for(int i=0;i < secretWord.Length;i++) 
                {
                Console.Write("*");
            }
            Console.WriteLine();

            Console.WriteLine("Ingrese una letra:");
            letter = Console.ReadLine();
            Console.WriteLine(">" + letter);

            Console.ReadLine();

        }
    }
}
