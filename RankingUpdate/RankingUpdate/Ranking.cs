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
                        if(i>0 && teams[i].CompareTeamsPoints(teams[i - 1])){
                            Team t = teams[i];
                            teams[i] = teams[i - 1];
                            teams[i - 1] = t;

                        }
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
