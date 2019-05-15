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

    }
    
}
