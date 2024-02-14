using System.Collections.Generic;

public class Game
{
    public Player Player1 { get; private set; }
    public Player Player2 { get; private set; }

    public Game(Player player1, Player player2)
    {
        Player1 = player1;
        Player2 = player2;
    }

    public Player Round1()
    {
        if (Player1.Skill >= Player2.Skill)
        {
            Player1.Score();
            return Player1;
        }

        Player2.Score();
        return Player2;
    }

    public Player Round2()
    {
        if (Player1.Intelligence >= Player2.Intelligence)
        {
            Player1.Score();
            return Player1;
        }

        Player2.Score();
        return Player2;
    }

    public Player Round3()
    {
        if (Player1.Knowledge >= Player2.Knowledge)
        {
            Player1.Score();
            return Player1;
        }

        Player2.Score();
        return Player2;
    }

    public static string Instructions()
    {
        return "Win at least 2 rounds to win!";
    }
}