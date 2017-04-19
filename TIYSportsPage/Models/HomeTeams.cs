﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TIYSportsPage.Models
{
    public class HomeTeams
    {
        public int Id { get; set; }
        public string HomeTeamName { get; set; }
        public string TeamDescription { get; set; }
        public int NumOfPlayers { get; set; }
        public string TeamImage { get; set; }

    }
}