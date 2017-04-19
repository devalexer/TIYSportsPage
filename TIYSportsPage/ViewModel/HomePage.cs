using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TIYSportsPage.ViewModel
{
    public class HomePage
    {

        public int SportId { get; set; }
        public int SportName { get; set; }
        public string Url { get; set; }
        public string SportImage { get; set; }


        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string TeamDescription { get; set; }
        public int NumOfPlayers { get; set; }
        public string TeamImage { get; set; }


        public int GamesId { get; set; }
        public string GameScore { get; set; }


    }
}