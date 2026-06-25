namespace SurvivalRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game Name: SURVIVAL RPG");
            Console.WriteLine("Commands: W=Up, S=Down, A=Left, D=Right, F=Search, I=Inventory, U <num>=Use item, Q=Quit");
            Console.WriteLine("You start at (0,0). Find items to survive!\n");

            Player player = new Player();
            player.PrintPlayerStatus();

            while (player.IsAlive())
            {
                Console.Write("\n> Enter command: ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    continue;

                string[] parts = input.Trim().ToUpper().Split(' ');
                string command = parts[0];

                switch (command)
                {
                    case "W":
                        player.MoveUp();
                        break;
                    case "S":
                        player.MoveDown();
                        break;
                    case "A":
                        player.MoveLeft();
                        break;
                    case "D":
                        player.MoveRight();
                        break;
                    case "F":
                        player.Search();
                        break;
                    case "I":
                        player.ListItems();
                        break;
                    case "U":
                        if (parts.Length < 2 || !int.TryParse(parts[1], out int itemNum))
                            Console.WriteLine("Usage: U <item number>  (e.g. U 1)");
                        else
                            player.UseItem(itemNum);
                        break;
                    case "Q":
                        Console.WriteLine("Thanks for playing. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Unknown command. Use W/A/S/D, F, I, U <num>, or Q.");
                        break;
                }

                player.PrintPlayerStatus();
            }

            Console.WriteLine("\n GAME OVER — You died! ");
        }
    }
}