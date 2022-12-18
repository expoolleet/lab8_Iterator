using lab8_Iterator.Menus;

namespace lab8_Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tiraspolRestaurant = new TiraspolRestaurant();
            tiraspolRestaurant.AddItem(new MenuItem("Картошка в грыбном соусе", 10));
            tiraspolRestaurant.AddItem(new MenuItem("Гренки с борщом", 15));
            MenuDisplay.Print(tiraspolRestaurant);

            var benderRestaurant = new BenderRestaurant();
            benderRestaurant.AddItem(new MenuItem("Рыбные палочки в салате", 15));
            benderRestaurant.AddItem(new MenuItem("Вареники", 10));
            MenuDisplay.Print(benderRestaurant);

            Console.ReadKey();
        }
    }
}