using System;
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
    public class Medicine : IItem, IEntity
    {
        public Guid Id { get; }
        public decimal Price { get; }
        public string Name { get; }
        public int Pleasure { get; } //Определяет как и как сильно влияет купленная вещь на эмоц. состояние
        public int Healthy { get; } //Определяет насколько увеличится или уменьшится здоровье
        public int EnergyBoost { get; }
        public ItemTypeEnum ItemType { get; }

        public Medicine(Guid id, decimal price, string name, int pleasure, int healthy, int energyBoost, ItemTypeEnum itemType)
        {
            Id = id;
            Price = price;
            Name = name;
            Pleasure = pleasure;
            Healthy = healthy;
            EnergyBoost = energyBoost;
            ItemType = itemType;
        }

        public void Effect(IHobo hobo, IItem item)
        {
            ChangeStatic.HealthChange(hobo, item);
            ChangeStatic.EnergySatiation(hobo, item);
            ChangeStatic.EmotionalChange(hobo, item);
        }
    }
}
