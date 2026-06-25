namespace SurvivalRPG
{
    public abstract class Item
    {
        protected int _xLocation;
        protected int _yLocation;

        public string Name { get; protected set; }

        public Item(string name, int x, int y)
        {
            Name = name;
            _xLocation = x;
            _yLocation = y;
        }

        public int GetXLocation() => _xLocation;
        public int GetYLocation() => _yLocation;

        public abstract void ApplyItem(Player player);

        public abstract string GetItemInfo();
    }


    public class Banana : Item
    {
        public Banana(int x, int y) : base("Banana", x, y) { }

        public override void ApplyItem(Player player)
        {
            player.UpdateHealth(10);
            player.UpdateEnergy(5);
            Console.WriteLine("You eat the Banana. +10 health, +5 energy.");
        }

        public override string GetItemInfo() =>
            $"{Name} [+10 HP, +5 Energy] at ({_xLocation},{_yLocation})";
    }

    public class Cherry : Item
    {
        public Cherry(int x, int y) : base("Cherry", x, y) { }

        public override void ApplyItem(Player player)
        {
            player.UpdateHealth(5);
            player.UpdateEnergy(15);
            Console.WriteLine("You eat the Cherry. +5 health, +15 energy.");
        }

        public override string GetItemInfo() =>
            $"{Name} [+5 HP, +15 Energy] at ({_xLocation},{_yLocation})";
    }

    public class Cake : Item
    {
        public Cake(int x, int y) : base("Cake", x, y) { }

        public override void ApplyItem(Player player)
        {
            player.UpdateHealth(30);
            player.UpdateEnergy(20);
            Console.WriteLine("You ate the Cake. +30 health, +20 energy!");
        }

        public override string GetItemInfo() =>
            $"{Name} [+30 HP, +20 Energy] at ({_xLocation},{_yLocation})";
    }

    public class Poison : Item
    {
        public Poison(int x, int y) : base("Poison", x, y) { }

        public override void ApplyItem(Player player)
        {
            player.UpdateHealth(-30);
            Console.WriteLine("You drank the Poison. -30 health!");
        }

        public override string GetItemInfo() =>
            $"{Name} [-30 HP] at ({_xLocation},{_yLocation})";
    }

    public class ExpiredFood : Item
    {
        public ExpiredFood(int x, int y) : base("Expired Food", x, y) { }

        public override void ApplyItem(Player player)
        {
            player.UpdateHealth(-10);
            player.UpdateEnergy(-10);
            Console.WriteLine("You ate the Expired Food. -10 health, -10 energy. Yuck!");
        }

        public override string GetItemInfo() =>
            $"{Name} [-10 HP, -10 Energy] at ({_xLocation},{_yLocation})";
    }
}