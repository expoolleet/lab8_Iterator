using lab8_Iterator.Menus.Iterators;

namespace lab8_Iterator.Menus
{
    internal static class MenuDisplay
    {
        static public void Print(IteratorAggregate menu)
        {
            foreach (MenuItem item in menu)
            {
                Console.WriteLine(item);
            }
        }
    }
}
