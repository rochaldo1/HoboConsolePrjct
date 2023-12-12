using HoboConsolePrjct.Model.Events;
using HoboConsolePrjct.Model.InventoryEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboConsolePrjct.Model
{
    public static class GetCount
    {
        public static int GetCountOf(IEntity entity)
        {
            if(entity is EventsList list)
            {
                List<IEvents> list2 = list.ShowEvent();
                return list2.Count;
            }
            return 0;
        }
    }
}
