using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoboConsole.Model.Items.Base;

namespace HoboConsole.Model.Items
{
    public class RealEstate : IItem
    {
        public Guid Id { get; }
        public decimal Price { get; }
        public string Name { get; }
        public decimal Pleasure { get; } //Определяет как и как сильно влияет купленная вещь на эмоц. состояние
        public ItemTypeEnum ItemType { get; }

        public RealEstate(Guid id, decimal price, string name, decimal pleasure, ItemTypeEnum itemType)
        {
            Id = id;
            Price = price;
            Name = name;
            Pleasure = pleasure;
            ItemType = itemType;
        }

        public void Effect(IHobo hobo, IItem item)
        {
            throw new NotImplementedException();
        }
    }
}
