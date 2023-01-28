using SnamesAndLadders;

Console.WriteLine("To start the game press enter");
Console.WriteLine();
ConsoleKeyInfo keyInfo = Console.ReadKey(true);
if (keyInfo.Key == ConsoleKey.Enter)
{
    Console.WriteLine("The game is started");
    var game = new Game();
    var player = new Player(new Die());
    while (!game.IsFinished())
    {
        Console.WriteLine();
        Console.WriteLine("Press enter to rolls a die");
        Console.WriteLine();
        ConsoleKeyInfo enter = Console.ReadKey(true);
        if (enter.Key == ConsoleKey.Enter)
        {
            var valueOfDie = player.RollADie();
            Console.WriteLine($"Value of die is: {valueOfDie}");
            game.MoveToken(valueOfDie);
            Console.WriteLine($"Token is on square: {game.GetTokenPosition()}");
        }
    }
    Console.WriteLine();
    Console.WriteLine("The game is finished");
}
