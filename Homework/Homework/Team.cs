using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class Team
    {
        private List<Football_player> players;
        public Coach Coach { get; set; }
        public List<Football_player> Players 
        {
            get { return players; }
            set
            {
                if (value.Count >= 11)
                {
                    players = value;
                }
                else
                {
                    throw new ArgumentException("Team must have at least 11 players.");
                }
            }
        }

        public double GetAverageAge()
        {
            int totalAge = 0;
            foreach (var player in players)
            {
                totalAge += player.Age;
            }
            return (double)totalAge / players.Count;
        }

        public override string ToString()
        {
            string teamInfo = $"Coach: {Coach.Name}\n";
            teamInfo += "Players:\n";

            foreach (var player in Players)
            {
                teamInfo += $"- {player.Name} (#{player.Number})\n";
            }

            teamInfo += $"Average age: {GetAverageAge():F1}";

            return teamInfo;
        }
    }
}
