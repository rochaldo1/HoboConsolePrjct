using HoboConsole.Model.Items.Base;
using HoboConsole.Model.Items;
using HoboConsole.Model.Stacks;
using HoboConsolePrjct.Model.InventoryFolder;
using HoboConsolePrjct.Model.Hobo;
using HoboConsolePrjct.Data;
using HoboConsolePrjct.Model.Places;
using HoboConsolePrjct.Model.InventoryEvents;
using HoboConsolePrjct.Model.Events;
using HoboConsolePrjct.Model.Event;

namespace HoboConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Inventory hoboinventory = new();
            Hobo hobo = new(Guid.NewGuid(), "Саспенс", 100, 100, 100, 100, 100, hoboinventory);

            Food food = new(Guid.NewGuid(), 10, "обед", 10, ItemTypeEnum.Food, 10, 10, 10);
            StackItems stackItemsForOneFoodItem = new(Guid.NewGuid(), food, 3);
            hobo.inventory.AddStack(stackItemsForOneFoodItem);

            EventsList list = new();
            GarbageEvents garbageEvents = new(Guid.NewGuid(), list);
            Garbage garbage = new(Guid.NewGuid(), 5, "Glass bottle", 1, 0, ItemTypeEnum.Garbage);
            StackItems stackItems = new(Guid.NewGuid(), garbage, 2);

            Inventory inventory = new();
            EventHobo eventHobo = new(Guid.NewGuid(), "You found some bottles!", 5, 0, -2, -1, inventory);
            eventHobo.Inventory.AddStack(stackItems);
            garbageEvents.EventsList.AddEvent(eventHobo);


            Garbage garbage2 = new(Guid.NewGuid(), 3, "Can", 1, -1, ItemTypeEnum.Garbage);
            StackItems stackItems2 = new(Guid.NewGuid(), garbage2, 3);

            Inventory inventory2 = new();
            EventHobo eventHobo2 = new(Guid.NewGuid(), "You found some cans!", 5, 0, -2, -1, inventory2);
            eventHobo2.Inventory.AddStack(stackItems2);
            garbageEvents.EventsList.AddEvent(eventHobo2);



            StackItems stackItems3 = new(Guid.NewGuid(), garbage, 1);

            Inventory inventory3 = new();
            EventHobo eventHobo3 = new(Guid.NewGuid(), "You found a bottle!", 5, 0, -2, -1, inventory3);
            eventHobo3.Inventory.AddStack(stackItems3);
            garbageEvents.EventsList.AddEvent(eventHobo3);


            StackItems stackItems4 = new(Guid.NewGuid(), garbage2, 1);

            Inventory inventory4 = new();
            EventHobo eventHobo4 = new(Guid.NewGuid(), "You found a can!", 5, 0, -2, -1, inventory4);
            eventHobo4.Inventory.AddStack(stackItems4);
            garbageEvents.EventsList.AddEvent(eventHobo4);



            Inventory inventory5 = new();
            EventHobo eventHobo5 = new(Guid.NewGuid(), "You didn't find anything...", -3, -2, -2, -1, inventory5);
            garbageEvents.EventsList.AddEvent(eventHobo5);


            Inventory inventory6 = new();
            EventHobo eventHobo6 = new(Guid.NewGuid(), "You didn't find anything and got hurt!", -5, -5, -5, -1, inventory6);
            garbageEvents.EventsList.AddEvent(eventHobo6);


            Console.WriteLine(hobo.ToString());

            garbageEvents.ApplyEffect(hobo, 3);

            Console.WriteLine(hobo.ToString());
        }
    }
}