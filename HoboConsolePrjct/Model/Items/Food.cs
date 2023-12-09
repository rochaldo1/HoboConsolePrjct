﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoboConsole.Model.Items.Base;
using HoboConsolePrjct.Model.Effects;
using HoboConsolePrjct.Model.Hobo;
using HoboConsolePrjct.Model;


namespace HoboConsole.Model.Items
{
    public class Food : IItem, IEntity
    {
        public Guid Id { get; }
        public decimal Price { get; }
        public string Name { get; }
        public int Pleasure { get; } //Определяет как и как сильно влияет купленная вещь на эмоц. состояние
        public ItemTypeEnum ItemType { get; }
        public int Nutrition { get; } //Определяет энергетическую ценность еды
        public int EnergyBoost { get; }
        public int Healthy { get; } //Определяет насколько увеличится или уменьшится здоровье

        public Food(Guid id, decimal price, string name, int pleasure, ItemTypeEnum itemType, int nutrition, int energyBoost, int healthy)
        {
            Id = id;
            Price = price;
            Name = name;
            Pleasure = pleasure;
            ItemType = itemType;
            Nutrition = nutrition;
            EnergyBoost = energyBoost;
            Healthy = healthy;
        }

        public void Effect(IHobo hobo, IItem item)
        {
            ChangeStatic.HealthChange(hobo, item);
            ChangeStatic.EnergySatiation(hobo, item);
            ChangeStatic.EmotionalChange(hobo, item);
            ChangeStatic.SatiationChange(hobo, item);
        }
    }
}
