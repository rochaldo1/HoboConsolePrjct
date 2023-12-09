using HoboConsole.Model.Items.Base;
using HoboConsole.Model.Stacks;
using HoboConsolePrjct.Model.Hobo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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
        public bool UseItem(int i)
        {
            //var p = from selectItem in stacks
            //        where item.Id == selectItem.Id
            //        select selectItem;
            //if(p == null) return false;
            //return true;
            if (CheckCount.Check(stacks[i]))
            {
                //
                stacks[i].Count--;
                if(CheckCount.Check(stacks[i])) return true;
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
                s += stacks[i].Item.ToString();
            }
            return s;
        }

    }
}
