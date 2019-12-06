using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassExercise {
    class Wizard : Character
    {

        public int MP;

        public Wizard(string name) : base(name) {
            Console.WriteLine("Creando Wizard");
        }

        public Wizard(string name, int hp, int MP) : base(name, hp) {
            this.MP = MP;
        }

        public Wizard(string name, int hp, Stats stats) : base(name, hp, stats) {
        }

        public void Cast() {
            Console.WriteLine("Cast");

         }
         
        public override void ShowActionMenu() {
            base.ShowActionMenu();
            Console.WriteLine("4 - Cast");

            string action = Console.ReadLine();
            switch (action) {

                case "1":
                Walk();
                break;

                case "2":
                Jump();
                break;

                case "3":
                Attack();
                break;

                case "4":
                Cast();
                break;

                default:
                break;

            }

            ShowActionMenu();
        }
    }

}
