using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TIYSportsPage.Models
{
    public class Sport
    {
        public int Id { get; set; }
        public int SportName { get; set; }
        public string Url { get; set; }
        public string SportImage { get; set; }


    }
}