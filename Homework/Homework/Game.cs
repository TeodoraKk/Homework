using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class Game
    {
        public Team team1 { get; set; }
        public Team team2 { get; set; }
        public Referee referee { get; set; }
        public List<Referee> assistantReferees { get; set; }
        public List<Goals> goals { get; set; }
        public string result { get; set; }
        public Team winner { get; set; }

        public void PrintResult()
        {
            Console.WriteLine("Game Result:");
            Console.WriteLine("Team 1: {0}", team1.ToString()) ;
            Console.WriteLine("Team 2: {0}", team2.ToString());
            Console.WriteLine("Result: {0}", result);
            Console.WriteLine("Winner: {0}", winner.ToString());
            Console.WriteLine("Goals:");
            foreach (var goal in goals)
            {
                Console.WriteLine("- Minute: {0}, Player: {1}", goal.Minute, goal.Player.ToString());
            }
        }

    }
}
