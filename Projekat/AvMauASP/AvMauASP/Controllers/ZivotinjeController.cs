using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AvMauASP.Models;
using AvMauASP.ViewModels;
using AvMauAzil.Models;

namespace AvMauASP.Controllers
{
    public class ZivotinjeController : Controller
    {
        // GET: Zivotinje/Random
        public ActionResult Random()
        {
            var zivotinja = new Zivotinja() { Rasa = "Jazavicar", ImeZivotinje = "Mozart", TezinaZivotinje = 3, UdomljenaZivotinja = false, VrstaZivotinje = false };
            //var macka = new Macka() { Rasa = "Domaca", ImeZivotinje = "Pufna", TezinaZivotinje = 1, UdomljenaZivotinja = false };

            var korisnici = new List<Korisnik>
            {
                new Korisnik { ImeKorisnika = "Avda"},
                new Korisnik { ImeKorisnika = "Edo" }
              
            };

            var viewModel = new RandomZivotinjaViewModel
            {
                Zivotinja = zivotinja,
                Korisnici = korisnici
            };

            return View(viewModel);
            //return View(macka);
            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index","Home", new { page =1, sortBy = "name"});

        }

       // [Route(zivotinje/prispjele/{year}/{month:regex(\\d{4})}")]

        public ActionResult PoDatumuPrispeca(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //kada idemo na petbook
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "ImeZivotinje";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

    }
}