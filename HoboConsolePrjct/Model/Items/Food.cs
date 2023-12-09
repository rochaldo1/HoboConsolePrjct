using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoboConsole.Model.Items.Base;
using HoboConsolePrjct.Model.Hobo;


namespace HoboConsole.Model.Items
{
    public class Food : IItem
    {
        public Guid Id { get; }
        public decimal Price { get; }
        public string Name { get; }
        public decimal Pleasure { get; } //Определяет как и как сильно влияет купленная вещь на эмоц. состояние
        public ItemTypeEnum ItemType { get; }
        public int Nutrition { get; } //Определяет энергетическую ценность еды

        public int EnergyBoost { get; }
        public int Healthy { get; } //Определяет насколько увеличится или уменьшится здоровье

        public Food(Guid id, decimal price, string name, decimal pleasure, ItemTypeEnum itemType, int nutrition, int healthy)
        {
            Id = id;
            Price = price;
            Name = name;
            Pleasure = pleasure;
            ItemType = itemType;
            Nutrition = nutrition;
            Healthy = healthy;
        }

        public void Effect(IHobo hobo, IItem item)
        {
            if (item is Food food)
            {
                hobo.Health += food.Healthy;
                hobo.Hunger += food.Nutrition;
                hobo.Energy += food.EnergyBoost;
            }
        }
    }
}
