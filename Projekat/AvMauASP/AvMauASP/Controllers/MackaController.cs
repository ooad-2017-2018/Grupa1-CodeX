using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AvMauAzil.Models;

namespace AvMauASP.Controllers
{
    public class MackaController : Controller
    {
        // GET: Macka/RandomMacka
        public ActionResult RandomMacka()
        {
            /*  var macka = new Macka() { Rasa = "Domaca", ImeZivotinje = "Pufna", TezinaZivotinje = 1, UdomljenaZivotinja = false };*/
            return View();
        }
    }
}