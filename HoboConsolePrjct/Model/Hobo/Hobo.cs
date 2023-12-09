using HoboConsolePrjct.Model.InventoryFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboConsolePrjct.Model.Hobo
{
    public class Hobo : IHobo
    {
        public Guid Id { get; }
        public string Name { get; }
        public int Health { get; set; }
        public int Energy { get; set; }
        public int Hunger { get; set; }
        public decimal EmotionalState { get; set; }
        //public Inventory Inventory { get; set; }
        public Inventory inventory = new();

        public Hobo(string name, int health, int energy, int hunger, decimal emotionalState)
        {
            Name = name;
            Health = health;
            Energy = energy;
            Hunger = hunger;
            EmotionalState = emotionalState;
        }

        public override string ToString()
        {
            return $"Имя: {Name}\nЗдоровье: {Health}\nЭнергия: {Energy}\nГолод: {Hunger}\nЭМОТИОНАЛ ДАМАГЕ:{EmotionalState}\n";
        }
    }
}
