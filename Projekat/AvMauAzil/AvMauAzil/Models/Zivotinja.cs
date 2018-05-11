using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvMauAzil.Models
{
    public abstract class Zivotinja
    {
        static Int32 globalAnimalId = 0;
        Int32 animalId;
        String imeZivotinje;
        Int32 tezinaZivotinje;
        Boolean udomljenaZivotinja;

        public Zivotinja(string imeZivotinje, int tezinaZivotinje, bool udomljenaZivotinja = false)
        {
            globalAnimalId++;
            this.animalId = globalAnimalId;
            this.imeZivotinje = imeZivotinje;
            this.tezinaZivotinje = tezinaZivotinje;
            this.udomljenaZivotinja = udomljenaZivotinja;
        }

        public int AnimalId { get => animalId; }
        public string ImeZivotinje { get => imeZivotinje; set => imeZivotinje = value; }
        public int TezinaZivotinje { get => tezinaZivotinje; set => tezinaZivotinje = value; }
        public bool UdomljenaZivotinja { get => udomljenaZivotinja; set => udomljenaZivotinja = value; }
    }
}
