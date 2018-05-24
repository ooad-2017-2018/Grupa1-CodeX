using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvMauAzil.Models
{
    public class Direktor : Uprava
    {
        public Direktor(string imeUposlenika, long jmbgUposlenika, string usernameUposlenika, string passwordUposlenika, string emailUposlenika)
            : base(imeUposlenika, jmbgUposlenika, usernameUposlenika, passwordUposlenika, emailUposlenika) { }

        public override string dajVrstuPosla()
        {
            return "Direktor";
        }

    }
}
