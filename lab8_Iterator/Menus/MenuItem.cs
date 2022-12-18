namespace lab8_Iterator.Menus
{
    internal class MenuItem
    {
        public string Name { get; }

        public float Price { get; }

        public MenuItem(string name, float price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Наименование: {Name}\nЦена: {Price}\n------------";
        }
    }
}
