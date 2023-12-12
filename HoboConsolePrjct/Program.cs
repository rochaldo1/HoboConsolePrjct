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
using Newtonsoft.Json.Linq;
using HoboConsolePrjct.Model;

namespace HoboConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация работы приложения:\n\n");

            AlmsEventsRepository almsEventsRepository = new("C:\\Users\\Artur\\source\\repos\\HoboConsolePrjct\\HoboConsolePrjct\\bin\\Debug\\net8.0\\AlmsEvents.json");
            almsEventsRepository.Load();
            AlmsEvents almsEvents = almsEventsRepository.GetAlmsEvents();

            DrugDenRepository drugDenRepository = new("C:\\Users\\Artur\\source\\repos\\HoboConsolePrjct\\HoboConsolePrjct\\bin\\Debug\\net8.0\\DrugDen.json");
            drugDenRepository.Load();
            DrugDen drugDen = drugDenRepository.GetDrugDen();

            EstateEngencyRepository estateAngencyRepository = new("C:\\Users\\Artur\\source\\repos\\HoboConsolePrjct\\HoboConsolePrjct\\bin\\Debug\\net8.0\\EstateEgency.json");
            estateAngencyRepository.Load();
            EstateEngency estateAgency = estateAngencyRepository.GetEstateEngency();

            GarbageEventsRepository garbageEventsRepository = new("C:\\Users\\Artur\\source\\repos\\HoboConsolePrjct\\HoboConsolePrjct\\bin\\Debug\\net8.0\\GarbageEvents.json");
            garbageEventsRepository.Load();
            GarbageEvents garbageEvents = garbageEventsRepository.GetGarbageEvents();

            HospitalRepository hospitalRepository = new("C:\\Users\\Artur\\source\\repos\\HoboConsolePrjct\\HoboConsolePrjct\\bin\\Debug\\net8.0\\Hospital.json");
            hospitalRepository.Load();
            Hospital hospital = hospitalRepository.GetHospital();

            JobEventsRepository jobEventsRepository = new("C:\\Users\\Artur\\source\\repos\\HoboConsolePrjct\\HoboConsolePrjct\\bin\\Debug\\net8.0\\JobEvents.json");
            jobEventsRepository.Load();
            JobEvents jobEvents = jobEventsRepository.GetJobEvents();

            StoreRepository storeRepository = new("C:\\Users\\Artur\\source\\repos\\HoboConsolePrjct\\HoboConsolePrjct\\bin\\Debug\\net8.0\\Store.json");
            storeRepository.Load();
            Stores store = storeRepository.GetStores();

            HoboRepository hoboRepository = new("C:\\Users\\Artur\\source\\repos\\HoboConsolePrjct\\HoboConsolePrjct\\bin\\Debug\\net8.0\\Hobos.json");
            hoboRepository.Load();
            List<Hobo> hobos = hoboRepository.GetHobos();
            Hobo hobo = hobos[0];

            Console.WriteLine(hobo.ToString() + "\n");

            Console.WriteLine("Пойдём в магазин и купим предмет (например, хлеб):\n");
            hobo.BuyItem(store, 0);
            Console.WriteLine(hobo.ToString() + "\n");

            Random random = new();

            Console.WriteLine("Выполним действия (покапаемся в мусорке, попросим милостыни, сходим поработать):\n");

            int whatEvent = random.Next(0, GetCount.GetCountOf(garbageEvents.EventsList));
            garbageEvents.ApplyEffect(hobo, whatEvent);
            Console.WriteLine(garbageEvents.ToString(whatEvent) + "\n");
            whatEvent = random.Next(0, GetCount.GetCountOf(garbageEvents.EventsList));
            garbageEvents.ApplyEffect(hobo, whatEvent);
            Console.WriteLine(garbageEvents.ToString(whatEvent) + "\n");

            whatEvent = random.Next(0, GetCount.GetCountOf(almsEvents.EventsList));
            almsEvents.ApplyEffect(hobo, whatEvent);
            Console.WriteLine(almsEvents.ToString(whatEvent) + "\n");
            whatEvent = random.Next(0, GetCount.GetCountOf(almsEvents.EventsList));
            almsEvents.ApplyEffect(hobo, whatEvent);
            Console.WriteLine(almsEvents.ToString(whatEvent) + "\n");

            whatEvent = random.Next(0, GetCount.GetCountOf(jobEvents.EventsList));
            jobEvents.ApplyEffect(hobo, whatEvent);
            Console.WriteLine(jobEvents.ToString(whatEvent) + "\n");
            whatEvent = random.Next(0, GetCount.GetCountOf(jobEvents.EventsList));
            jobEvents.ApplyEffect(hobo, whatEvent);
            Console.WriteLine(jobEvents.ToString(whatEvent) + "\n");

            Console.WriteLine(hobo.ToString() + "\n");

            Console.WriteLine("Теперь применим вещь из инвентаря (хлеб):\n");
            hobo.UseItem(hobo, 0);
            Console.WriteLine(hobo.ToString() + "\n");

            Console.WriteLine("Ещё раз выполним действия, чтобы подзаработать денег:\n");

            whatEvent = random.Next(0, GetCount.GetCountOf(garbageEvents.EventsList));
            garbageEvents.ApplyEffect(hobo, whatEvent);
            Console.WriteLine(garbageEvents.ToString(whatEvent) + "\n");
            whatEvent = random.Next(0, GetCount.GetCountOf(garbageEvents.EventsList));
            garbageEvents.ApplyEffect(hobo, whatEvent);
            Console.WriteLine(garbageEvents.ToString(whatEvent) + "\n");

            whatEvent = random.Next(0, GetCount.GetCountOf(almsEvents.EventsList));
            almsEvents.ApplyEffect(hobo, whatEvent);
            Console.WriteLine(almsEvents.ToString(whatEvent) + "\n");
            whatEvent = random.Next(0, GetCount.GetCountOf(almsEvents.EventsList));
            almsEvents.ApplyEffect(hobo, whatEvent);
            Console.WriteLine(almsEvents.ToString(whatEvent) + "\n");

            whatEvent = random.Next(0, GetCount.GetCountOf(jobEvents.EventsList));
            jobEvents.ApplyEffect(hobo, whatEvent);
            Console.WriteLine(jobEvents.ToString(whatEvent) + "\n");
            whatEvent = random.Next(0, GetCount.GetCountOf(jobEvents.EventsList));
            jobEvents.ApplyEffect(hobo, whatEvent);
            Console.WriteLine(jobEvents.ToString(whatEvent) + "\n");

            Console.WriteLine(hobo.ToString() + "\n");

            Console.WriteLine("Наш бродяга не знает как правильно весeлиться, поэтому он купит наркотики и мы примем их:\n");

            hobo.BuyItem(drugDen, 0);
            Console.WriteLine(hobo.ToString() + "\n");
            int drug;
            string _drugIdx;
            do _drugIdx = Console.ReadLine();
            while (!int.TryParse(_drugIdx, out drug));
            hobo.UseItem(hobo, drug-1);

            Console.WriteLine(hobo.ToString() + "\n");

            Console.WriteLine("Скорее всего он собрал какие-то предметы, надо продать их:\n");

            int itemForSell;
            string _itemForSell;
            for (int i = 0; i < 3; i++)
            {
                do _itemForSell = Console.ReadLine();
                while (!int.TryParse(_itemForSell, out itemForSell));
                hobo.SellItem(itemForSell-1);
                Console.WriteLine(hobo.ToString() + "\n");
            }
        }
    }
}