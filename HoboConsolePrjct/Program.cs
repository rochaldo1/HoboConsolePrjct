using HoboConsole.Model.Items.Base;
using HoboConsole.Model.Items;
using HoboConsole.Model.Stacks;
using HoboConsolePrjct.Model.InventoryFolder;
using HoboConsolePrjct.Model.Hobo;

namespace HoboConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Food food = new Food(Guid.NewGuid(), 500M, "ЕДА", 25, ItemTypeEnum.Food, 23, 5, 21);
            StackItems stackFood = new StackItems(food, 3);
            Food food2 = new Food(Guid.NewGuid(), 100000M, "ГОВНИЩЕ", -12, ItemTypeEnum.Food, -51, -31, 1000);
            StackItems stackFood2 = new StackItems(food2, 1);
            Clothes clothes = new Clothes(Guid.NewGuid(), 600M, "ОДЕЖДА", 2, ItemTypeEnum.Clothes);
            StackItems stackClothes = new(clothes, 5);

            Hobo hobo = new("БомжарА", 100, 100, 100, 50);
            hobo.inventory.AddStack(stackFood);
            hobo.inventory.AddStack(stackFood2);
            hobo.inventory.AddStack(stackClothes);

            Console.WriteLine(hobo.ToString() + "\n");
            Console.WriteLine(hobo.inventory.ToString() + "\n");
            hobo.inventory.UseItem(hobo, 1);
            Console.WriteLine(hobo.ToString() + "\n");
            Console.WriteLine(hobo.inventory.ToString() + "\n");
            hobo.inventory.UseItem(hobo, 0);
            Console.WriteLine(hobo.ToString() + "\n");
            Console.WriteLine(hobo.inventory.ToString() + "\n");
        }
    }
}