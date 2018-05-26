using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AvMauASP.Models
{
    public class Korisnik
    {
        static Int32 globalId = 0;

      
     //   Int32 userId;

        [Key]
        public int UserId { get; set; }

        String imeKorisnika;
        String prezimeKorisnika;
        long jmbgKorisnika;
        String usernameKorisnika;
        String passwordKorisnika;
        String emailKorisnika;

        public Korisnik() { }

        public Korisnik(string imeKorisnika, string prezimeKorisnika,long jmbgKorisnika, string usernameKorisnika, string passwordKorisnika, string emailKorisnika)
        {
            globalId++;
            this.UserId = globalId;
            this.prezimeKorisnika = prezimeKorisnika;
            this.imeKorisnika = imeKorisnika;
            this.jmbgKorisnika = jmbgKorisnika;
            this.usernameKorisnika = usernameKorisnika;
            this.passwordKorisnika = passwordKorisnika;
            this.emailKorisnika = emailKorisnika;
        }


        public static int GlobalId { get => globalId; set => globalId = value; }

        [Required(ErrorMessage = "Polje 'ime' je neophodno popuniti.")]
        public string ImeKorisnika { get => imeKorisnika; set => imeKorisnika = value; }

        [Required(ErrorMessage = "Polje 'prezime' je neophodno popuniti.")]
        public string PrezimeKorisnika { get => prezimeKorisnika; set => prezimeKorisnika = value; }

        public long JmbgKorisnika { get => jmbgKorisnika; set => jmbgKorisnika = value; }

        [Required(ErrorMessage = "Polje 'username' je neophodno popuniti.")]
        public string UsernameKorisnika { get => usernameKorisnika; set => usernameKorisnika = value; }

        [Required(ErrorMessage = "Polje 'password' je neophodno popuniti.")]
        [DataType(DataType.Password)]
        public string PasswordKorisnika { get => passwordKorisnika; set => passwordKorisnika = value; }

        [Required(ErrorMessage = "Polje 'e-mail' je neophodno popuniti.")]
        [RegularExpression(@"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$")]
        public string EmailKorisnika { get => emailKorisnika; set => emailKorisnika = value; }

    
        


    }
}