using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AvMauAzil.Models;

namespace AvMauASP.Controllers
{
    public class PasController : Controller
    {
        // GET: Pas/RandomPas
        public ActionResult RandomPas()
        {
            /*
            var pas = new Pas() { Pasmina = "Jazavicar", ImeZivotinje = "Mozart", TezinaZivotinje = 3, UdomljenaZivotinja = false };*/
            return View();
        }
    }
}