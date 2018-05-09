using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvMauAzil.Klase
{
    public class Pas : Zivotinja
    {
        String pasmina;

        public Pas(string pasmina, string imeZivotinje, int tezinaZivotinje, bool udomljenaZivotinja = false)
            : base(imeZivotinje, tezinaZivotinje, udomljenaZivotinja)
        {
            this.pasmina = pasmina;
        }

        public string Pasmina { get => pasmina; set => pasmina = value; }
    }
}
