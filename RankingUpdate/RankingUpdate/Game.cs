using System;
using System.Collections.Generic;
using System.Text;

namespace RankingUpdate
{
    public class Game
    {
        private readonly Team firstTeam;
        private readonly Team secondTeam;
        private readonly int firstTeamScore;
        private readonly int secondTeamScore;

        public Game(Team firstTeam,Team secondTeam,int firstTeamScore,int secondTeamScore)
        {
            this.firstTeam = firstTeam;
            this.secondTeam = secondTeam;
            this.firstTeamScore = firstTeamScore;
            this.secondTeamScore = secondTeamScore;
        }

        public Team[] UpdatePlayingTeamsPoints()
        {
            string[] team1 = firstTeam.PrintTeam().Split(" ");
            string firstTeamName = team1[0];
            int firstTeamPoints = Convert.ToInt32(team1[1]);

            string[] team2 = secondTeam.PrintTeam().Split(" ");
            string secondTeamName = team2[0];
            int secondTeamPoints = Convert.ToInt32(team2[1]);

            Team[] playingTeams = new Team[2];


            if (firstTeamScore > secondTeamScore)
            {
                firstTeamPoints += 3;
            }
            if (firstTeamScore < secondTeamScore)
            {
                secondTeamPoints += 3;
            }
            else
            {
                firstTeamPoints += 1;
                secondTeamPoints += 1;
            }

            Team first = new Team(firstTeamName, firstTeamPoints);
            Team second = new Team(secondTeamName, secondTeamPoints);
            playingTeams[0] = first;
            playingTeams[1] = second;
            return playingTeams;
        }
    }


}
