using HoboConsole.Model.Items.Base;
using HoboConsole.Model.Stacks;
using HoboConsolePrjct.Model.Hobo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HoboConsolePrjct.Model.InventoryFolder
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


        public bool UseItem(IHobo hobo, int i)
        {
            if (stacks.Count == 0 || (i > stacks.Count - 1)) return false;
            if (CheckCount.Check(stacks[i]))
            {
                stacks[i].Item.Effect(hobo, stacks[i].Item);
                stacks[i].Count--;
                if (CheckCount.Check(stacks[i])) return true;
                DeleteItem(i);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string s = string.Empty;
            for (var i = 0; i < stacks.Count; i++)
            {
                s += stacks[i].Item.Name.ToString();
                s += " " + stacks[i].Count.ToString();
            }
            return s;
        }

    }
}
