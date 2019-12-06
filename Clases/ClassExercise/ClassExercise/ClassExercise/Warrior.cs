using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassExercise {
    class Warrior :Character {

        public int stamina;

        public Warrior(string name) : base(name) {
            Console.Write("Creando Warrior");
        }

        public Warrior(string name, int hp) : base(name, hp) {
            
        }

        public Warrior(string name, int hp, Stats stats) : base(name, hp, stats) {
        }
    }
}
