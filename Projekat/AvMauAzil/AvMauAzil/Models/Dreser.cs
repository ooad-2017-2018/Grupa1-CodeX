using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvMauAzil.Models
{
    public class Dreser : Uposlenik
    {
        Int32 brojDresiranih;

        public Dreser(string imeUposlenika, long jmbgUposlenika, string usernameUposlenika, string passwordUposlenika, string emailUposlenika)
            : base(imeUposlenika, jmbgUposlenika, usernameUposlenika, passwordUposlenika, emailUposlenika)
        {
            this.brojDresiranih = 0;
        }

        public int BrojDresiranih { get => brojDresiranih; set => brojDresiranih = value; }

        public override string dajVrstuPosla()
        {
            return "Dreser";
        }
    }
}
