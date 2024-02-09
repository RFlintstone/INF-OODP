using System;

namespace W02._1.H03_Theyll_only_speak_of_how_you_coded_in_Csharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Player p1 = new Player("John Snow", 30);
            Player p2 = new Player("Night King", 60);
            
            Player winner = null;
            
            Console.WriteLine($"{p1.Name}: {p1.Power} Power; {p1.HealthPoints} Healthpoints");
            Console.WriteLine($"{p2.Name}: {p2.Power} Power; {p2.HealthPoints} Healthpoints");
            
            while (winner == null)
            {
                p1.TakeDamage(p2.Power);
                p2.TakeDamage(p1.Power);
                if (!p1.isAlive())
                    winner = p2;
                else if (!p2.isAlive())
                    winner = p1;
                Console.WriteLine($"{p1.Name}: {p1.Power} Power; {p1.HealthPoints} Healthpoints");
                Console.WriteLine($"{p2.Name}: {p2.Power} Power; {p2.HealthPoints} Healthpoints");
            }

            Console.WriteLine(
                $"-----The winner is:-----\n{winner.Name}: {winner.Power} Power; {winner.HealthPoints} Healthpoints");
        }
    }

    public class Player
    {
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public int Power { get; set; }

        public Player(string name, int power)
        {
            Name = name;
            HealthPoints = 100;
            Power = power;
        }

        public bool isAlive()
        {
            bool isAlive;
            if (HealthPoints > 0)
            {
                isAlive = true;
            }
            else
            {
                isAlive = false;
            }

            return isAlive;
        }

        public void TakeDamage(int damage)
        {
            if (HealthPoints - damage < 0)
            {
                HealthPoints = 0;
            }
            else
            {
                HealthPoints -= damage;
            }
        }
    }
}