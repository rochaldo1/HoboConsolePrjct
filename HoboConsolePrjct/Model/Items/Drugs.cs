using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoboConsole.Model.Items.Base;

namespace HoboConsole.Model.Items
{
    public class Drugs : IItem
    {
        public Guid Id { get; }
        public decimal Price { get; }
        public string Name { get; }
        public decimal Pleasure { get; } //Определяет как и как сильно влияет купленная вещь на эмоц. состояние
        public int Healthy { get; } //Определяет насколько увеличится или уменьшится здоровье
        public ItemTypeEnum ItemType { get; }

        public Drugs(Guid id, decimal price, string name, decimal pleasure, int healthy, ItemTypeEnum itemType)
        {
            Id = id;
            Price = price;
            Name = name;
            Pleasure = pleasure;
            Healthy = healthy;
            ItemType = itemType;
        }

        public void Effect(IHobo hobo, IItem item)
        {
            throw new NotImplementedException();
        }
    }
}
