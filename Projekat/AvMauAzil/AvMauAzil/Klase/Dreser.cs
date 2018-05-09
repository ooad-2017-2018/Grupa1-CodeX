using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvMauAzil.Klase
{
    public class Dreser : Uposlenik
    {
        Int32 brojDresiranih;

        public Dreser(string imeUposlenika, int jmbgUposlenika, string usernameUposlenika, string passwordUposlenika, string emailUposlenika)
            : base(imeUposlenika, jmbgUposlenika, usernameUposlenika, passwordUposlenika, emailUposlenika)
        {
            this.brojDresiranih = 0;
        }

        public int BrojDresiranih { get => brojDresiranih; set => brojDresiranih = value; }
    }
}
