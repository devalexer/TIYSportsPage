using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TIYSportsPage.Models;

namespace TIYSportsPage.DataContext
{
    public class SportContext : DbContext
    {
        public SportContext():base()
        {

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<HomeTeam> HomeTeams { get; set; }
        public DbSet<AwayTeam> AwayTeams { get; set; }
    }
}