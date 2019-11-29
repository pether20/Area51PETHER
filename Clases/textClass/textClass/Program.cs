using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textClass {
    class Program {
        static void Main(string[] args) {

            string secretWord = "zapato";
            string letter = "";
            string tempWord = "";
            string publicWord = "";
            int hp = 3;

            //Console.WriteLine(secretWord.Length);
            for(int i=0;i < secretWord.Length;i++) 
                {
                tempWord += "";
            }
            publicWord = tempWord;
            Console.WriteLine(publicWord);


            while (hp > 0) {
                Console.WriteLine("Ingrese una letra:");
                letter = Console.ReadLine();
                //Console.WriteLine(">" + letter);

                tempWord = "";
                for (int i = 0; i < secretWord.Length; i++) 
                    {
                    if (letter == "" + secretWord[i]) 
                    {
                        tempWord += letter;

                    } 
                    else {
                        tempWord += publicWord[i];
                         }
                }

                if (publicWord == tempWord) {
                    hp--;
                }
                
                Console.WriteLine(tempWord);
                
            }

            Console.ReadLine();

        }
    }
}
//foreach (char c in secretWord) {
//  if (letter == "" + c) {
//    tempWord += c;
//Console.WriteLine(tempWord);
// } else {
//   tempWord += "*";
//Console.WriteLine(tempWord);
// }
//}