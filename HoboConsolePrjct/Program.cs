using HoboConsole.Model.Items.Base;
using HoboConsole.Model.Items;
using HoboConsole.Model.Stacks;
using HoboConsolePrjct.Model.Inventory;
using HoboConsolePrjct.Model.Hobo;

namespace HoboConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Food food = new Food(Guid.NewGuid(), 500M, "ЕДА", 25M, ItemTypeEnum.Food, 23, 21);
            StackItems stackFood = new StackItems(food, 3);
            Clothes clothes = new Clothes(Guid.NewGuid(), 600M, "ОДЕЖДА", 21M, ItemTypeEnum.Clothes);
            StackItems stackClothes = new(clothes, 5);

            //Console.WriteLine(stackClothes.ToString());
            Inventory inventory = new();
            inventory.AddStack(stackFood);
            inventory.AddStack(stackClothes);
            Console.WriteLine(inventory.ToString());

            Hobo hobo = new("БомжарА", 23, 44, 1, 23);
            hobo.inventory.AddStack(stackFood);
            hobo.inventory.UseItem()
        }
    }
}