using HoboConsole.Model.Items.Base;
using HoboConsole.Model.Stacks;
using HoboConsolePrjct.Model.Hobo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboConsolePrjct.Model.Inventory
{
    public class Inventory : IInventory
    {

        private List<IStack> stacks = new();

        public Inventory() {; }

        public void AddStack(IStack item) => stacks.Add(item);

        public void DeleteItem(int i)
        {
            stacks.RemoveAt(i);
        }
        public void ApplyEffect(IHobo hobo, IItem item, int i)
        {
            stacks[i].Item.Effect(hobo, item);
            DeleteItem(i);
        }

        public override string ToString()
        {
            string s = string.Empty;
            for (var i = 0; i < stacks.Count; i++)
            {
                s += stacks[i].Item.ToString();
            }
            return s;
        }

    }
}
