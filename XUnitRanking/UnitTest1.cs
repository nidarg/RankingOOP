using System;
using Xunit;
using RankingUpdate;


namespace XUnitRanking
{
    public class UnitTest1
    {
        
     
        
        [Theory]
        [InlineData("FCSB", 32, "FCSB 32")]
        public void TestPrintTeam(string name, int points, string expected)
        {
            Team team = new Team(name, points);
            string actual = team.PrintTeam();

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("FCSB", 32, "CFR", 30,0,2,"CFR 33")]
        public void TestUpdatePlayingTeamsPoints(string firstName, int firstPoints,string secondName,int secondPoints,int firstScore,int secondScore, string expected)
        {
            Team firstTeam = new Team(firstName, firstPoints);
            Team secondTeam = new Team(secondName, secondPoints);
            Game game = new Game(firstTeam, secondTeam, firstScore, secondScore);
            Team[] teams = game.UpdatePlayingTeamsPoints();
            string actual = teams[1].PrintTeam();

            Assert.Equal(expected, actual);
        }



        [Theory]
        [InlineData("FCSB", 32, "CFR", 30, "Dinamo", 33, 0, 2, "CFR 33")]
        public void TestUpdateRanking(string firstName, int firstPoints, string secondName, int secondPoints, string thirdName,int thirdPoints,int firstScore, int secondScore, string expected)
        {
            Team firstTeam = new Team(firstName, firstPoints);
            Team secondTeam = new Team(secondName, secondPoints);
            Team thirdTeam = new Team(thirdName, thirdPoints);
            Team[] rankingTeams = new Team[]{ firstTeam, secondTeam, thirdTeam };
            Ranking ranking = new Ranking(rankingTeams);
            Game game = new Game(firstTeam, secondTeam, firstScore, secondScore);
            ranking.UpdateRanking(game);
            string actual = rankingTeams[1].PrintTeam();
            //Team[] teams = game.UpdatePlayingTeamsPoints();


            Assert.Equal(expected, actual);
        }

    }
    
}
