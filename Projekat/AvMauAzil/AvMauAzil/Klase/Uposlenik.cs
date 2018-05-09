using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvMauAzil.Klase
{
    public abstract class Uposlenik
    {
        String imeUposlenika;
        Int32 jmbgUposlenika;
        String usernameUposlenika;
        String passwordUposlenika;
        String emailUposlenika;
        //String fotografijaUposlenika;

        protected Uposlenik(string imeUposlenika, int jmbgUposlenika, string usernameUposlenika, string passwordUposlenika, string emailUposlenika)
        {
            this.imeUposlenika = imeUposlenika;
            this.jmbgUposlenika = jmbgUposlenika;
            this.usernameUposlenika = usernameUposlenika;
            this.passwordUposlenika = passwordUposlenika;
            this.emailUposlenika = emailUposlenika;
        }

        public string ImeUposlenika { get => imeUposlenika; set => imeUposlenika = value; }
        public int JmbgUposlenika { get => jmbgUposlenika; set => jmbgUposlenika = value; }
        public string UsernameUposlenika { get => usernameUposlenika; set => usernameUposlenika = value; }
        public string PasswordUposlenika { get => passwordUposlenika; set => passwordUposlenika = value; }
        public string EmailUposlenika { get => emailUposlenika; set => emailUposlenika = value; }
        


    }
}
