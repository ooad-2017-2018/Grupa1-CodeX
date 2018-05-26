using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvMauASP;
using AvMauAzil;

namespace AvMauAzil.Models
{
    public class Zivotinja
    {
        static Int32 globalAnimalId = 0;
        Int32 animalId;
        String imeZivotinje;
        Int32 tezinaZivotinje;
        Boolean udomljenaZivotinja;
        Boolean vrstaZivotinje;
        String rasa;


        public Zivotinja() { }

        public Zivotinja(string rasa, string imeZivotinje, int tezinaZivotinje, bool udomljenaZivotinja = false, bool vrstaZivotinje = false)
        {
            globalAnimalId++;
            this.rasa = rasa;
            this.animalId = globalAnimalId;
            this.imeZivotinje = imeZivotinje;
            this.tezinaZivotinje = tezinaZivotinje;
            this.udomljenaZivotinja = udomljenaZivotinja;
            this.vrstaZivotinje = vrstaZivotinje;
        }

        public int AnimalId { get => animalId; }
        public string ImeZivotinje { get => imeZivotinje; set => imeZivotinje = value; }
        public int TezinaZivotinje { get => tezinaZivotinje; set => tezinaZivotinje = value; }
        public bool UdomljenaZivotinja { get => udomljenaZivotinja; set => udomljenaZivotinja = value; }
        public bool VrstaZivotinje { get => vrstaZivotinje; set => vrstaZivotinje = value; }
        public string Rasa { get => rasa; set => rasa = value; }
    }
}
