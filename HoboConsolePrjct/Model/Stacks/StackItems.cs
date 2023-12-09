using HoboConsole.Model.Items.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboConsole.Model.Stacks
{
    public class StackItems : IStack
    {
        public IItem Item { get; set; }
        public int Count { get; set; }
        public StackItems(IItem item, int count)
        {
            Item = item;
            Count = count;
        }

    }
}
