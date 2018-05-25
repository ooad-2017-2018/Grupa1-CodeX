using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AvMauASP.Models;
using AvMauAzil.Models;

namespace AvMauASP.Controllers
{
    public class ZivotinjeController : Controller
    {
        // GET: Zivotinje/Random
        public ActionResult Random()
        {
            var zivotinja = new Zivotinja() { Rasa = "Jazavicar", ImeZivotinje = "Mozart", TezinaZivotinje = 3, UdomljenaZivotinja = false, VrstaZivotinje= false };
            //var macka = new Macka() { Rasa = "Domaca", ImeZivotinje = "Pufna", TezinaZivotinje = 1, UdomljenaZivotinja = false };
            return View(zivotinja);
                   //  return View(macka);
        }
    }
}