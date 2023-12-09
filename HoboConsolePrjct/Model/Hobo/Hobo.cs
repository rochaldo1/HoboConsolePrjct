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
        public int Satiation { get; set; }
        public int EmotionalState { get; set; }
        public int Money { get; set; }

        public List<int> Changes { get; set; }

        public Inventory inventory = new();

        public Hobo(string name, int health, int energy, int satiation, int emotionalState)
        {
            Name = name;
            Health = health;
            Energy = energy;
            Satiation = satiation;
            EmotionalState = emotionalState;
        }

        public override string ToString()
        {
            return $"Имя: {Name}\nЗдоровье: {Health}\nЭнергия: {Energy}\nНАСЫЩЕНИЕ: {Satiation}\nЭМОТИОНАЛ ДАМАГЕ:{EmotionalState}\n";
        }
    }
}
