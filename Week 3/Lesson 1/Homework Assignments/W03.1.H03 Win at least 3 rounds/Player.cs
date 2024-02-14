public class Player
{
    public string Name { get; set; }
    public int Points { get; set; }
    public int Skill { get; set; }
    public int Intelligence { get; set; }
    public int Knowledge { get; set; }

    public Player(string name, int skill, int intelligence, int knowledge)
    {
        Name = name;
        Skill = skill;
        Intelligence = intelligence;
        Knowledge = knowledge;
    }

    public void Score()
    {
        Points++;
    }

    public static Player WhoIsWinning(Player player1, Player player2)
    {
        if (player1.Points == player2.Points)
        {
            return null;
        }

        if (player1.Points >= player2.Points)
        {
            return player1;
        }
        
        return player2;
    }
}