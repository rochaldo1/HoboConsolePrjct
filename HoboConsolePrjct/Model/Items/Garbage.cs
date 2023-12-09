﻿using HoboConsole.Model.Items.Base;
using HoboConsolePrjct.Model.Effects;
using HoboConsolePrjct.Model.Hobo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoboConsolePrjct.Model;

namespace HoboConsole.Model.Items
{
    public class Garbage : IItem, IEntity
    {
        public Guid Id { get; }
        public decimal Price { get; }
        public string Name { get; }
        public int Pleasure { get; }
        public int Healthy { get; }
        public ItemTypeEnum ItemType { get; }

        public Garbage(Guid id, decimal price, string name, int pleasure, int healthy, ItemTypeEnum itemTypeEnum)
        {
            Id = id;
            Price = price;
            Name = name;
            Pleasure = pleasure;
            Healthy = healthy;
            ItemType = itemTypeEnum;
        }

        public void Effect(IHobo hobo, IItem item)
        {
            ChangeStatic.EmotionalChange(hobo, item);
            ChangeStatic.HealthChange(hobo, item);
        }
    }
}
