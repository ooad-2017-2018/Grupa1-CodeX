using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvMauAzil.Models
{
    public class OstaloOsoblje : Uposlenik
    {
        String opisSporednogPosla;

        public OstaloOsoblje(string opisSporednogPosla, string imeUposlenika, long jmbgUposlenika, string usernameUposlenika, string passwordUposlenika, string emailUposlenika)
            : base(imeUposlenika, jmbgUposlenika, usernameUposlenika, passwordUposlenika, emailUposlenika)
        {
            this.opisSporednogPosla = opisSporednogPosla;
        }

        public string OpisSporednogPosla { get => opisSporednogPosla; set => opisSporednogPosla = value; }

        public override string dajVrstuPosla()
        {
            return OpisSporednogPosla;
        }
    }
}
