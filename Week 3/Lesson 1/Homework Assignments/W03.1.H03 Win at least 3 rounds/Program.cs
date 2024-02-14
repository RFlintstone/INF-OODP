using System;

internal class Program
{
    public static void Main(string[] args)
    {
        // Create players and game instance
        var player1 = new Player("John", 20, 20, 50);
        var player2 = new Player("Zoey", 10, 30, 40);
        var game = new Game(player1, player2);

        // Print instructions
        Console.WriteLine(Game.Instructions());

        // Play the game
        var round1Winner = game.Round1();
        Console.WriteLine($"{round1Winner.Name} won the first round!");

        var round2Winner = game.Round2();
        Console.WriteLine($"{round2Winner.Name} won the second round!");

        var round3Winner = game.Round3();
        Console.WriteLine($"{round3Winner.Name} won the third round!");
    }
}