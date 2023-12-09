using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboConsole.Model.Items.Base
{
    public interface IItem
    {
        public Guid Id { get; }
        public decimal Price { get; }
        public string Name { get; }
        public decimal Pleasure { get; } //Определяет как и как сильно влияет купленная вещь на эмоц. состояние
        public void Effect(IHobo hobo, IItem item);
    }
}
