using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboConsole.Model
{
    public class Hobo : IHobo
    {
        public string Name { get; }
        public int Health { get; set; }
        public int Energy { get; set; }
        public int Hunger { get; set; }
        public decimal EmotionalState { get; set; }

        public Hobo(string name, int health, int energy, int hunger, decimal emotionalState)
        {
            this.Name = name;
            this.Health = health;
            this.Energy = energy;
            this.Hunger = hunger;
            this.EmotionalState = emotionalState;
        }

        public override string ToString()
        {
            return $"ЭМОТИОНАЛ ДАМАГЕ:{EmotionalState} здоровье: {Health}\n";
        }
    }
}
