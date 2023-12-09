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
    public class Clothes : IItem, IEntity
    {
        public Guid Id { get; }
        public decimal Price { get; }
        public string Name { get; }
        public int Pleasure { get; } //Определяет как и как сильно влияет купленная вещь на эмоц. состояние
        public ItemTypeEnum ItemType { get; }

        public Clothes(Guid id, decimal price, string name, int pleasure, ItemTypeEnum itemTypeEnum)
        {
            Id = id;
            Price = price;
            Name = name;
            Pleasure = pleasure;
            ItemType = itemTypeEnum;
        }
        public void Effect(IHobo hobo, IItem item)
        {
            ChangeValueStatic.EmotionalChange(hobo, item);
        }
    }
}
