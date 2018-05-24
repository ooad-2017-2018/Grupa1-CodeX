using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvMauAzil.Models
{
    public class Veterinar : Uposlenik
    {
        Int32 brojPregledanih;

        public Veterinar(string imeUposlenika, long jmbgUposlenika, string usernameUposlenika, string passwordUposlenika, string emailUposlenika)
            : base(imeUposlenika, jmbgUposlenika, usernameUposlenika, passwordUposlenika, emailUposlenika)
        {
            this.brojPregledanih = 0;
        }

        public int BrojPregledanih { get => brojPregledanih; set => brojPregledanih = value; }

        public override string dajVrstuPosla()
        {
            return "Veterinar";
        }
    }
}
