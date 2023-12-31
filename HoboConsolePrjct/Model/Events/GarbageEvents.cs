﻿using HoboConsole.Model.Items.Base;
using HoboConsolePrjct.Model.Effects;
using HoboConsolePrjct.Model.Events;
using HoboConsolePrjct.Model.Hobo;
using HoboConsolePrjct.Model.InventoryEvents;
using HoboConsolePrjct.Model.InventoryFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoboConsole.Model.Stacks;

namespace HoboConsolePrjct.Model.Event
{
    public class GarbageEvents : IEntity
    {
        public Guid Id { get; set; }
        public EventsList EventsList { get; set; }

        public GarbageEvents(Guid id, EventsList eventsList) 
        {
            Id = id;
            EventsList = eventsList;
        }

        public string ToString(int whatEvent)
        {
            List<IEvents> listOfEvents = EventsList.ShowEvent();
            return listOfEvents[whatEvent].Text;
        }

        public void ApplyEffect(IHobo hobo, int whatEvent)
        {
            List<IEvents> list = EventsList.ShowEvent();
            List<IStack> stacks = list[whatEvent].Inventory.ShowInventory();
            for (int i = 0; i < stacks.Count; i++)
            {
                hobo.inventory.AddStack(stacks[i]);
            }
            hobo.Money += list[whatEvent].Money;
            ChangeValueStatic.HealthChange(hobo, list[whatEvent]);
            ChangeValueStatic.EnergyChange(hobo, list[whatEvent]);
            ChangeValueStatic.EmotionalChange(hobo, list[whatEvent]);
            ChangeValueStatic.SatiationChange(hobo, list[whatEvent]);
        }
    }
}
