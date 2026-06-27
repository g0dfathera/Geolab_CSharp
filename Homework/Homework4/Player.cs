namespace SurvivalRPG
{
    public class Player
    {
        private int _health;
        private int _energy;
        private bool _isAlive;
        private int _xLocation;
        private int _yLocation;

        public Bag Bag { get; private set; }

        public Player()
        {
            _health = 100;
            _energy = 100;
            _isAlive = true;
            _xLocation = 0;
            _yLocation = 0;
            Bag = new Bag();
        }

        public void UpdateHealth(int amount)
        {
            _health += amount;
            if (_health > 100) _health = 100;
            if (_health <= 0)
            {
                _health = 0;
                _isAlive = false;
            }
        }

        public void UpdateEnergy(int amount)
        {
            _energy += amount;
            if (_energy > 100) _energy = 100;
            if ( _energy <= 0)  _energy = 0; 
        }


        private void Move(int dx, int dy, string direction)
        {
            _xLocation += dx;
            _yLocation += dy;
            _energy -= 5;

            Console.WriteLine($"You move {direction}. Location: ({_xLocation},{_yLocation})");

            if (_energy <= 0)
            {
                Console.WriteLine("You are out of energy! Losing 5 health per move.");
                UpdateHealth(-5);
                _energy = 0;
            }
        }

        public void MoveUp() => Move(0, 1, "Up");
        public void MoveDown() => Move(0, -1, "Down");
        public void MoveRight() => Move(1, 0, "Right");
        public void MoveLeft() => Move(-1, 0, "Left");


        public void Search()
        {
            Item? found = Map.FindItemAt(_xLocation, _yLocation);
            if (found != null)
            {
                Console.WriteLine($"You found: {found.Name}!");
                Bag.AddItem(found);
                Map.RemoveItem(found);
            }
            else
            {
                Console.WriteLine("Nothing here.");
            }
        }

        public void ListItems()
        {
            List<Item> items = Bag.GetItems();
            if (items.Count == 0)
            {
                Console.WriteLine("Your bag is empty.");
                return;
            }
            Console.WriteLine("--- Bag ---");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {items[i].GetItemInfo()}");
            }
        }

        public void UseItem(int itemIndex)
        {
            List<Item> items = Bag.GetItems();
            int index = itemIndex - 1;

            if (index < 0 || index >= items.Count)
            {
                Console.WriteLine("Invalid item number.");
                return;
            }

            Item item = items[index];
            item.ApplyItem(this);
            Bag.RemoveItem(item);
        }

        public bool IsAlive() => _isAlive;

        public void PrintPlayerStatus()
        {
            Console.WriteLine($"\n[Player Status] HP: {_health} | Energy: {_energy} | Location: ({_xLocation},{_yLocation}) | Bag: {Bag.GetItems().Count} item(s)");
        }
    }
}