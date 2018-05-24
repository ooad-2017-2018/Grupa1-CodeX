using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvMauAzil.Models
{
    public class Macka : Zivotinja
    {
        String rasa;

        public Macka(string rasa, string imeZivotinje, int tezinaZivotinje, bool udomljenaZivotinja = false)
            : base(imeZivotinje, tezinaZivotinje, udomljenaZivotinja)
        {
            this.rasa = rasa;
        }

        public string Rasa { get => rasa; set => rasa = value; }
    }
}
