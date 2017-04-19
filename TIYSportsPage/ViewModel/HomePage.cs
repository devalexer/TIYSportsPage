using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TIYSportsPage.Models;

namespace TIYSportsPage.ViewModel
{
    public class HomePage
    {
        public IEnumerable<Sport> Sports { get; set; }

        public IEnumerable<AwayTeam> AwayTeams { get; set; }

        public IEnumerable<HomeTeam> HomeTeams { get; set; }

        public IEnumerable<Game> Games { get; set; }

    }
}