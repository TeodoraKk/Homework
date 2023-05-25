using System;
using System.Collections.Generic;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create players
            Football_player player1 = new Striker { Name = "John Doe", Number = 1, Age = 25, Height = 180 };
            Football_player player2 = new Defender { Name = "Mike Smith", Number = 5, Age = 28, Height = 185 };
            Football_player player3 = new Defender { Name = "David Johnson", Number = 3, Age = 24, Height = 182 };
            Football_player player4 = new Defender { Name = "Chris Williams", Number = 4, Age = 26, Height = 188 };
            Football_player player5 = new Midfield { Name = "Daniel Brown", Number = 5, Age = 27, Height = 175 };
            Football_player player6 = new Midfield { Name = "Matthew Davis", Number = 6, Age = 23, Height = 180 };
            Football_player player7 = new Midfield { Name = "Andrew Taylor", Number = 7, Age = 25, Height = 178 };
            Football_player player8 = new Midfield { Name = "Steven Wilson", Number = 8, Age = 29, Height = 183 };
            Football_player player9 = new Striker { Name = "Robert Anderson", Number = 9, Age = 26, Height = 185 };
            Football_player player10 = new Striker { Name = "Mark Thompson", Number = 10, Age = 24, Height = 180 };
            Football_player player11 = new Striker { Name = "James White", Number = 11, Age = 27, Height = 182 };

            // Create coach
            Coach coach = new Coach { Name = "Alex Johnson", Age = 40 };

            // Create team
            Team team1 = new Team { Coach = coach, Players = new List<Football_player> { player1, player2, player3, player4, player5, player6, player7,player7, player8, player9, player10, player11 } };
            Team team2 = new Team { Coach = coach, Players = new List<Football_player> { player1, player2, player3, player4, player5, player6, player7, player7, player8, player9, player10, player11 } };


            // Create referee
            Referee referee = new Referee { Name = "David Brown", Age = 35 };

            // Create assistant referees
            Referee referee1 = new Referee { Name = "Peter Green", Age = 30 };
            Referee referee2 = new Referee { Name = "Sarah White", Age = 28 };
            List<Referee> referees = new List<Referee> { referee1, referee2 };

            List<Goals> goals = new List<Goals> { new Goals { Minute = 11, Player = player1} };



            // Create game
            Game game = new Game
            {
                team1 = team1,
                team2 = team2,
                referee = referee,
                assistantReferees = referees,
                goals = goals,
                result = "1:0",
                winner = team1
            };

            game.PrintResult();
        }
    }
}
