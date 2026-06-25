namespace SurvivalRPG
{
    public static class Map
    {
        public static List<Item> ItemsList { get; private set; }

        static Map()
        {
            ItemsList = new List<Item>
            {
                new Banana(2, 3),
                new Cherry(-1, 2),
                new Cake(4, 4),
                new Poison(1, -2),
                new ExpiredFood(-3, 1),
                new Banana(0, 3),
                new Cherry(3, -1),
                new Cake(-2, -2),
                new Poison(-4, 0),
                new ExpiredFood(2, 2)
            };
        }

        public static Item FindItemAt(int x, int y)
        {
            foreach (Item item in ItemsList)
            {
                if (item.GetXLocation() == x && item.GetYLocation() == y)
                    return item;
            }
            return null;
        }

        public static void RemoveItem(Item item)
        {
            ItemsList.Remove(item);
        }
    }
}