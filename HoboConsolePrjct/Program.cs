using HoboConsole.Model.Items.Base;
using HoboConsole.Model.Items;
using HoboConsole.Model.Stacks;
using HoboConsolePrjct.Model.InventoryFolder;
using HoboConsolePrjct.Model.Hobo;
using HoboConsolePrjct.Data;

namespace HoboConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HoboRepository serializeUsers = new HoboRepository("C:\\Users\\dima2\\Desktop\\HoboConsolePrjct\\HoboConsolePrjct\\bin\\Debug\\net8.0\\Hobos.json");

            serializeUsers.Load();
            List<Hobo> usersFromJson = serializeUsers.GetHobos();
            Hobo hobo = usersFromJson[0];
            Console.WriteLine(hobo.ToString() + "\n");
            Console.WriteLine(hobo.inventory.ToString() + "\n");

            //Food food = new Food(Guid.NewGuid(), 500M, "NiceFOOD", 25, ItemTypeEnum.Food, 23, 5, 21);
            //StackItems stackFood = new StackItems(Guid.NewGuid(), food, 3);
            //Food food2 = new Food(Guid.NewGuid(), 100000M, "POP", -12, ItemTypeEnum.Food, -51, -31, 30);
            //StackItems stackFood2 = new StackItems(Guid.NewGuid(), food2, 1);
            //Clothes clothes = new Clothes(Guid.NewGuid(), 600M, "CLOTHES", 2, ItemTypeEnum.Clothes);
            //StackItems stackClothes = new(Guid.NewGuid(), clothes, 5);

            //Inventory inventory = new();
            //Hobo hobo = new(Guid.NewGuid(), "Basic hobo", 50, 73, 40, 50, 500, inventory);
            //hobo.inventory.AddStack(stackFood);
            //hobo.inventory.AddStack(stackFood2);
            //hobo.inventory.AddStack(stackClothes);

            //Console.WriteLine(hobo.ToString() + "\n");
            //Console.WriteLine(hobo.inventory.ToString() + "\n");
            //hobo.inventory.UseItem(hobo, 1);
            //Console.WriteLine(hobo.ToString() + "\n");
            //Console.WriteLine(hobo.inventory.ToString() + "\n");
            //hobo.inventory.UseItem(hobo, 0);
            //Console.WriteLine(hobo.ToString() + "\n");
            //Console.WriteLine(hobo.inventory.ToString() + "\n");
            //serializeUsers.Add(hobo);
            //serializeUsers.Save();

        }
    }
}