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
            Food food = new Food(Guid.NewGuid(), 500M, "ЕДА", 25M, ItemTypeEnum.Food, 23, 21);
            StackItems stackFood = new StackItems(food, 3);
            Food food2 = new Food(Guid.NewGuid(), 100000M, "ГОВНИЩЕ", -10M, ItemTypeEnum.Food, 1, 1000);
            StackItems stackFood2 = new StackItems(food2, 1);
            Clothes clothes = new Clothes(Guid.NewGuid(), 600M, "ОДЕЖДА", 21M, ItemTypeEnum.Clothes);
            StackItems stackClothes = new(clothes, 5);

            Hobo hobo = new("БомжарА", 23, 44, 1, 23);
            hobo.inventory.AddStack(stackFood);
            hobo.inventory.AddStack(stackFood2);
            hobo.inventory.AddStack(stackClothes);

            Console.WriteLine(hobo.ToString() + "\n");
            Console.WriteLine(hobo.inventory.ToString() + "\n");
            hobo.inventory.UseItem(1, hobo);
            Console.WriteLine(hobo.ToString() + "\n");
            Console.WriteLine(hobo.inventory.ToString() + "\n");
            hobo.inventory.UseItem(0, hobo);
            Console.WriteLine(hobo.ToString() + "\n");
            Console.WriteLine(hobo.inventory.ToString() + "\n");
        }
    }
}