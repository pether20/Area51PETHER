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

            Character character = null;
            switch (type) {
                case "1":
                character = new Wizard(name);
                break;

                case "2":
                character = new Warrior(name);
                break;

                case "3":
                character = new Rogue(name);
                break;

                default:
                break;
            }

            character.Attack();

            Console.ReadLine();

        }
    }
}
