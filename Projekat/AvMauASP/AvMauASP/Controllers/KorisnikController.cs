using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AvMauAzil.Models;
using AvMauASP.Models;

namespace AvMauASP.Controllers
{
    public class KorisnikController : Controller
    {
        // GET: Korisnik
        public ActionResult Index()
        {
            using (OurDBContext db = new OurDBContext())
            {
                return View(db.korisnik.ToList());
            }
               
        }


        //Registracija
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Korisnik account)
        {
            if (ModelState.IsValid)
            {
                ContainerClass.dodajKorisnika(account); // dodavanje

                using(OurDBContext db = new OurDBContext())
                {
                    db.korisnik.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.ImeKorisnika + " " + account.PrezimeKorisnika + " uspjesno registriran.";
            }
            return View();
        }



        //Login
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(Korisnik user)
        {
            
            using (OurDBContext db = new OurDBContext())
            {
                var usr = db.korisnik.Single(u => u.UsernameKorisnika == user.UsernameKorisnika && u.PasswordKorisnika == user.PasswordKorisnika);
                if (usr != null)
                {
                    //
                    ContainerClass.LoggedInKorisnik = usr;
                    //
                    Session["UserId"] = usr.UserId.ToString();
                    Session["UsernameKorisnika"] = usr.UsernameKorisnika.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Username ili Password je pogresan.");

                }
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if(Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logoff()
        {
            ContainerClass.LoggedInKorisnik = null;
            Session["UserId"] = null;
            Session["UsernameKorisnika"] = null;

            return RedirectToAction("Login");
        }

    }
}