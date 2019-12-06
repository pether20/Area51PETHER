using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassExercise {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Character Type");
            Console.WriteLine("      1 :Type Wizard");
            Console.WriteLine("      2 :Type Warrior");
            Console.WriteLine("      3 :Type Rogue");

            string type = Console.ReadLine();
            string name = Console.ReadLine();

            Character myCharacter = null;
            switch (type) {
                case "1":
                myCharacter = new Wizard(name);
                break;

                case "2":
                myCharacter = new Warrior(name);
                break;

                case "3":
                myCharacter = new Rogue(name);
                break;

                default:
                break;
            }

            if (myCharacter != null)
                myCharacter.ShowActionMenu();

            Console.ReadLine();

        }
    }
}
