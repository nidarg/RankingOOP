﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RankingUpdate
{
    public class Team
    {

        private readonly string name;
        private readonly int points;

        public Team(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public string PrintTeam()
        {
            return (this.name + " " + this.points.ToString());
        }

        public bool CompareTeamsNames(Team team)
        {
            return this.name == team.name;
        }
        public bool CompareTeamsPoints(Team team)
        {
            return this.points > team.points;
        }

    }
}
