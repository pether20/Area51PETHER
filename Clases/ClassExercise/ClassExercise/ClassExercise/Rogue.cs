﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassExercise {
    class Rogue :Character
    
    {
        public int stamina;

        public Rogue(string name) : base(name) {
            Console.WriteLine("Creando Rogue");
        }

        public Rogue(string name, int hp) : base(name, hp) {
        }

        public Rogue(string name, int hp, Stats stats) : base(name, hp, stats) {
        }
        public void Steak() {
            Console.WriteLine("Steal");
        }
    }
}
