using HoboConsole.Model.Stacks;
using HoboConsolePrjct.Model.InventoryFolder;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoboConsolePrjct.Model.Hobo
{
    public class Hobo : IHobo
    {
        public Guid Id { get; set; }
        public string Name { get; }
        public int Health { get; set; }
        public int Energy { get; set; }
        public int Satiation { get; set; }
        public int EmotionalState { get; set; }
        public int Money { get; set; }
        //[JsonProperty]
        public Inventory inventory {  get; set; }

        public Hobo(Guid id ,string name, int health, int energy, int satiation, int emotionalState, int money, Inventory inventory)
        {
            Id = id;
            Name = name;
            Health = health;
            Energy = energy;
            Satiation = satiation;
            EmotionalState = emotionalState;
            Money = money;
            this.inventory = inventory;
        }

        public override string ToString()
        {
            return $"Имя: {Name}\nЗдоровье: {Health}\nЭнергия: {Energy}\nНАСЫЩЕНИЕ: {Satiation}\nЭМОТИОНАЛ ДАМАГЕ:{EmotionalState}\n";
        }
    }
}
