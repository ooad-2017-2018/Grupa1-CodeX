using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AvMauASP.Models
{
    public class Korisnik
    {
        static Int32 globalId = 0;
        Int32 userId;
        String imeKorisnika;
        long jmbgKorisnika;
        String usernameKorisnika;
        String passwordKorisnika;
        String emailKorisnika;

        public Korisnik(string imeKorisnika, long jmbgKorisnika, string usernameKorisnika, string passwordKorisnika, string emailKorisnika)
        {
            globalId++;
            this.userId = globalId;
            this.imeKorisnika = imeKorisnika;
            this.jmbgKorisnika = jmbgKorisnika;
            this.usernameKorisnika = usernameKorisnika;
            this.passwordKorisnika = passwordKorisnika;
            this.emailKorisnika = emailKorisnika;
        }

        public static int GlobalId { get => globalId; set => globalId = value; }
        public string ImeKorisnika { get => imeKorisnika; set => imeKorisnika = value; }
        public long JmbgKorisnika { get => jmbgKorisnika; set => jmbgKorisnika = value; }
        public string UsernameKorisnika { get => usernameKorisnika; set => usernameKorisnika = value; }
        public string PasswordKorisnika { get => passwordKorisnika; set => passwordKorisnika = value; }
        public string EmailKorisnika { get => emailKorisnika; set => emailKorisnika = value; }
        public int EmployeeId { get => userId; }
        


    }
}