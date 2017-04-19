using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TIYSportsPage.Models;
using TIYSportsPage.Services;
using TIYSportsPage.ViewModel;

namespace TIYSportsPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var vm = new HomePage();
            vm.Sports = new IndexServices().GetAllSports();
            vm.Games = new IndexServices().GetAllGames();
            vm.HomeTeams = new IndexServices().GetAllHomeTeams();
            vm.AwayTeams = new IndexServices().GetAllAwayTeams();
            return View(vm);

        }


    }
}