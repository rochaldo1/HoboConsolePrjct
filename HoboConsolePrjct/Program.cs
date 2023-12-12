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
            AlmsEventsRepository almsEventsRepository = new("C:\\Users\\Artur\\source\\repos\\HoboConsolePrjct\\HoboConsolePrjct\\bin\\Debug\\net8.0\\AlmsEvents.json");
            JobEventsRepository jobEventsRepository = new("C:\\Users\\Artur\\source\\repos\\HoboConsolePrjct\\HoboConsolePrjct\\bin\\Debug\\net8.0\\JobEvents.json");
            Inventory hoboinventory = new();
            Hobo hobo = new(Guid.NewGuid(), "Саспенс", 100, 100, 100, 100, 100, hoboinventory);

            Food food = new(Guid.NewGuid(), 10, "обед", 10, ItemTypeEnum.Food, 10, 10, 10);
            StackItems stackItemsForOneFoodItem = new(Guid.NewGuid(), food, 3);
            hobo.inventory.AddStack(stackItemsForOneFoodItem);

            EventsList list = new();
            Inventory eventInventory = new();
            EventHobo eventHobo = new(Guid.NewGuid(), "You worked at a construction site and got 250 coins", -10, -5, -5, 0, 250, eventInventory);
            JobEvents jobEvents = new(Guid.NewGuid(), list);
            jobEvents.EventsList.AddEvent(eventHobo);

            Inventory eventInventory2 = new();
            EventHobo eventHobo2 = new(Guid.NewGuid(), "You handed out flyers and got 100 coins!", -5, -2, -2, 0, 100, eventInventory2);
            jobEvents.EventsList.AddEvent(eventHobo2);

            Inventory eventInventory3 = new();
            EventHobo eventHobo3 = new(Guid.NewGuid(), "You swept the yard and got 150 coins", -7, -3, -5, 0, 150, eventInventory3);
            jobEvents.EventsList.AddEvent(eventHobo3);

            Inventory eventInventory4 = new();
            EventHobo eventHobo4 = new(Guid.NewGuid(), "You washed the floors in the store and got 125 coins", -6, -3, -4, 0, 125, eventInventory4);
            jobEvents.EventsList.AddEvent(eventHobo4);

            Inventory eventInventory5 = new();
            EventHobo eventHobo5 = new(Guid.NewGuid(), "You worked hard but didn't get anything... You got scammed!", -10, -3, -5, 0, 0, eventInventory5);
            jobEvents.EventsList.AddEvent(eventHobo5);

            jobEventsRepository.Add(jobEvents);
            jobEventsRepository.Save();
        }
    }
}