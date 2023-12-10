using HoboConsole.Model.Items.Base;
using HoboConsolePrjct.Model.Effects;
using HoboConsolePrjct.Model.Events;
using HoboConsolePrjct.Model.Hobo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboConsolePrjct.Model.Event
{
    public class Events : IEvents
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public int Pleasure { get; set; }
        public int Healthy { get; set; }
        public int EnergyBoost { get; set; }
        public int Nutrition {  get; set; }

        public Events(Guid id, string text, int pleasure, int healthy, int energyBoost, int nutrition) 
        {
            Id = id;
            Text = text;
            Pleasure = pleasure;
            Healthy = healthy;
            EnergyBoost = energyBoost;
            Nutrition = nutrition;
        }

        public void Effect(IHobo hobo, IItem item)
        {
            ChangeValueStatic.HealthChange(hobo, item);
            ChangeValueStatic.EnergyChange(hobo, item);
            ChangeValueStatic.EmotionalChange(hobo, item);
            ChangeValueStatic.SatiationChange(hobo, item);
        }
    }
}
