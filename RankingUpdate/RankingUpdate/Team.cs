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



    }
}
