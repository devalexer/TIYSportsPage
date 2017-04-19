namespace TIYSportsPage.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TIYSportsPage.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TIYSportsPage.DataContext.SportContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TIYSportsPage.DataContext.SportContext context)
        {

            var sport = new List<Sport>
            {
                new Sport{SportName = "Basketball", Url = "www.ncaa.com/", SportImage = "/images/basketball.jpg"},
                new Sport{SportName = "Baseball", Url = "www.mlb.com/", SportImage = "/images/baseball.jpg"},
                new Sport{SportName = "Football", Url = "www.nfl.com/", SportImage = "/images/football.jpg"},
                new Sport{SportName = "Quidditch", Url = "www.usquidditch.org/", SportImage = "/images/quidditch.jpg"},
            };
            sport.ForEach(oc => context.Sports.AddOrUpdate(o => o.SportName, oc));
            context.SaveChanges();


            var homeTeam = new List<HomeTeam>
            {
                new HomeTeam{HomeTeamName = "Tampa Dart Dynamos", TeamDescription = "Lorem ipsum dolor sit amet", NumOfPlayers = 8, TeamImage = "/images/dartboard.jpg"},
                new HomeTeam{HomeTeamName = "St. Pete Ping Pong Power House", TeamDescription = "Lorem ipsum dolor sit amet", NumOfPlayers = 7, TeamImage = "/images/pingpong.jpg"},
                new HomeTeam{HomeTeamName = "Orlando Golf Game", TeamDescription = "Lorem ipsum dolor sit amet", NumOfPlayers = 4, TeamImage = "/images/golf.jpg"},
            };
            homeTeam.ForEach(oc => context.HomeTeams.AddOrUpdate(o => o.HomeTeamName, oc));
            context.SaveChanges();


            var awayTeam = new List<AwayTeam>
            {
                new AwayTeam{AwayTeamName = "Buffalo Bullseyes"},
                new AwayTeam{AwayTeamName = "Philly Paddlers"},
                new AwayTeam{AwayTeamName = "Portland Putters"},
            };
            awayTeam.ForEach(oc => context.AwayTeams.AddOrUpdate(o => o.AwayTeamName, oc));
            context.SaveChanges();


            var game = new List<Game>
            {
                new Game{HomeTeamId = 1, AwayTeamId = 3, GameScore = "4-5"},
                new Game{HomeTeamId = 2, AwayTeamId = 1, GameScore = "8-2"},
                new Game{HomeTeamId = 3, AwayTeamId = 2, GameScore = "0-1"},

            };
            game.ForEach(oc => context.Games.AddOrUpdate(o => o.HomeTeamId, oc));
            context.SaveChanges();
        }
    }
}
