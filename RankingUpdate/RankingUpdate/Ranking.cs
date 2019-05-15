using System;
using System.Collections.Generic;
using System.Text;

namespace RankingUpdate
{
    public class Ranking
    {
        Team[] teams;

        public Ranking(Team[] teams)
        {
            this.teams = teams;
        }

        public void UpdateRanking(Game game)
        {
            Team[] playingTeams = game.UpdatePlayingTeamsPoints();
            for(int i = 0; i < teams.Length; i++)
            {
                for(int j = 0; j < playingTeams.Length; j++)
                {
                    if (teams[i].CompareTeamsNames(playingTeams[j]))
                    {
                        teams[i] = playingTeams[j];
                    }
                }
            }
        }

        public void PrintAll()
        {
            foreach(Team team in teams)
            {
                Console.WriteLine(team.PrintTeam());
            }
        }
    }
}
