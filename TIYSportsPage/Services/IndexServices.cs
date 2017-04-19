using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TIYSportsPage.DataContext;
using TIYSportsPage.Models;

namespace TIYSportsPage.Services
{
    public class IndexServices
    {
        public IEnumerable<Sport> GetAllSports()
        {
            var rv = new SportContext().Sports.ToList();
            return rv;
        }

        public IEnumerable<AwayTeam> GetAllAwayTeams()
        {
            var rv = new SportContext().AwayTeams.ToList();
            return rv;
        }

        public IEnumerable<HomeTeam> GetAllHomeTeams()
        {
            var rv = new SportContext().HomeTeams.ToList();
            return rv;
        }

        public IEnumerable<Game> GetAllGames()
        {
            var rv = new SportContext().Games.ToList();
            return rv;
        }


    }
}