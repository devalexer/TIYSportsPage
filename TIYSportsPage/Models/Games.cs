using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TIYSportsPage.Models
{
    public class Games
    {
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public string GameScore { get; set; }

    }
}