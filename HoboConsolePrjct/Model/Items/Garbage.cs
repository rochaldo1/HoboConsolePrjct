using HoboConsole.Model.Items.Base;
using HoboConsolePrjct.Model.Hobo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboConsole.Model.Items
{
    public class Garbage : IItem
    {
        public Guid Id { get; }
        public decimal Price { get; }
        public string Name { get; }
        public decimal Pleasure { get; }

        public void Effect(IHobo hobo, IItem item)
        {
            if(item is Garbage garbage)
            {
                hobo.EmotionalState = garbage.Pleasure;
            }
        }
    }
}
