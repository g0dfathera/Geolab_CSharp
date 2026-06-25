namespace SurvivalRPG
{
    public class Bag
    {
        private List<Item> _itemsList;

        public Bag()
        {
            _itemsList = new List<Item>();
        }

        public void AddItem(Item item)
        {
            _itemsList.Add(item);
        }

        public void RemoveItem(Item item)
        {
            _itemsList.Remove(item);
        }

        public List<Item> GetItems()
        {
            return _itemsList;
        }
    }
}