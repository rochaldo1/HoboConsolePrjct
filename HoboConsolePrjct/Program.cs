using HoboConsole.Model.Items.Base;
using HoboConsole.Model.Items;
using HoboConsole.Model.Stacks;
using HoboConsolePrjct.Model.InventoryFolder;
using HoboConsolePrjct.Model.Hobo;
using HoboConsolePrjct.Data;
using HoboConsolePrjct.Model.Places;

namespace HoboConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HoboRepository serializeUsers = new HoboRepository("C:\\Users\\dima2\\Desktop\\HoboConsolePrjct\\HoboConsolePrjct\\bin\\Debug\\net8.0\\Hobos.json");
            //StoreRepository storeRepository = new StoreRepository("C:\\Users\\dima2\\Desktop\\HoboConsolePrjct\\HoboConsolePrjct\\bin\\Debug\\net8.0\\Store.json");
            //HospitalRepository hospitalRepository = new HospitalRepository("C:\\Users\\dima2\\Desktop\\HoboConsolePrjct\\HoboConsolePrjct\\bin\\Debug\\net8.0\\Hospital.json");
            DrugDenRepository drugDenRepository = new DrugDenRepository("C:\\Users\\dima2\\Desktop\\HoboConsolePrjct\\HoboConsolePrjct\\bin\\Debug\\net8.0\\DrugDen.json");
            //EstateEngencyRepository estateEngencyRepository = new EstateEngencyRepository("C:\\Users\\dima2\\Desktop\\HoboConsolePrjct\\HoboConsolePrjct\\bin\\Debug\\net8.0\\EstateEgency.json");

            Inventory drugInventory = new Inventory();
            DrugDen drugDen = new(Guid.NewGuid(), "Drug Dealer SHOP", drugInventory);


            Drugs drugs = new(Guid.NewGuid(), 400, "Maria Ivanovna", 25, -2, -5, ItemTypeEnum.Drugs);
            StackItems stackItems = new(Guid.NewGuid(), drugs, 1);
            drugDen.inventory.AddStack(stackItems);

            Drugs drugs2 = new(Guid.NewGuid(), 600, "Mith", 20, -6, 10, ItemTypeEnum.Drugs);
            StackItems stackItems2 = new(Guid.NewGuid(), drugs2, 1);
            drugDen.inventory.AddStack(stackItems2);

            Drugs drugs3 = new(Guid.NewGuid(), 1000, "Metaphore", 40, -15, 20, ItemTypeEnum.Drugs);
            StackItems stackItems3 = new(Guid.NewGuid(), drugs3, 1);
            drugDen.inventory.AddStack(stackItems3);

            Drugs drugs4 = new(Guid.NewGuid(), 1200, "Crocodile", 20, -25, 60, ItemTypeEnum.Drugs);
            StackItems stackItems4 = new(Guid.NewGuid(), drugs4, 1);
            drugDen.inventory.AddStack(stackItems4);

            Drugs drugs5 = new(Guid.NewGuid(), 1500, "Xmuriy", 50, -40, 90, ItemTypeEnum.Drugs);
            StackItems stackItems5 = new(Guid.NewGuid(), drugs5, 1);
            drugDen.inventory.AddStack(stackItems5);


            drugDenRepository.Add(drugDen);
            drugDenRepository.Save();








            //serializeUsers.Load();
            //List<Hobo> usersFromJson = serializeUsers.GetHobos();
            //Hobo hobo = usersFromJson[0];
            //Console.WriteLine(hobo.ToString() + "\n");
            //Console.WriteLine(hobo.inventory.ToString() + "\n");

            //Food food = new Food(Guid.NewGuid(), 500, "NiceFOOD", 25, ItemTypeEnum.Food, 23, 5, 21);
            //StackItems stackFood = new StackItems(Guid.NewGuid(), food, 3);
            //Food food2 = new Food(Guid.NewGuid(), 100000, "POP", -12, ItemTypeEnum.Food, -51, -31, 30);
            //StackItems stackFood2 = new StackItems(Guid.NewGuid(), food2, 1);
            //Food food3 = new Food(Guid.NewGuid(), 10, "Bread", 2, ItemTypeEnum.Food, 5, 5, 1);
            //StackItems stackFood3 = new StackItems(Guid.NewGuid(), food3, 1);
            //Clothes clothes = new Clothes(Guid.NewGuid(), 600, "CLOTHES", 2, ItemTypeEnum.Clothes);
            //StackItems stackClothes = new(Guid.NewGuid(), clothes, 5);

            //Inventory shopInventory = new();

            //Stores stores = new(Guid.NewGuid(),"SHOOOP",shopInventory);
            //stores.inventory.AddStack(stackFood3);

            //Inventory inventory = new();
            //Hobo hobo = new(Guid.NewGuid(), "Basic hobo", 50, 73, 40, 50, 500, inventory);
            //hobo.inventory.AddStack(stackFood);
            //hobo.inventory.AddStack(stackFood2);
            //hobo.inventory.AddStack(stackClothes);

            //Console.WriteLine(hobo.ToString() + "\n");
            //hobo.UseItem(hobo, 1);
            //Console.WriteLine(hobo.ToString() + "\n");
            //hobo.UseItem(hobo, 0);
            //Console.WriteLine(hobo.ToString() + "\n");
            //hobo.UseItem(hobo, 0);
            //Console.WriteLine(hobo.ToString() + "\n");
            //hobo.SellItem(0);
            //Console.WriteLine(hobo.ToString() + "\n");
            //hobo.BuyItem(stores, 0);
            //Console.WriteLine(hobo.ToString() + "\n");
            //hobo.BuyItem(stores, 0);
            //Console.WriteLine(hobo.ToString() + "\n");
            //hobo.BuyItem(stores, 0);
            //Console.WriteLine(hobo.ToString() + "\n");
            //hobo.BuyItem(stores, 0);
            //Console.WriteLine(hobo.ToString() + "\n");
            //hobo.BuyItem(stores, 0);
            //Console.WriteLine(hobo.ToString() + "\n");
            //hobo.BuyItem(stores, 0);
            //Console.WriteLine(hobo.ToString() + "\n");
            //hobo.BuyItem(stores, 0);
            //Console.WriteLine(hobo.ToString() + "\n");
            //serializeUsers.Add(hobo);
            //serializeUsers.Save();
        }
    }
}