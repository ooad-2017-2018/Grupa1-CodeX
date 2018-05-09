using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvMauAzil.Klase
{
    public static class ContainerClass
    {
        // ovo ce da bude kao Organization, direktorij Klase kao Models

        static List<Uposlenik> listaUposlenika = new List<Uposlenik>();
        static List<Zivotinja> listaZivotinja = new List<Zivotinja>();

        public static void dodajUposlenika(Uposlenik u)
        {
            listaUposlenika.Add(u);
        }

        public static void dodajZivotinju(Zivotinja z)
        {
            listaZivotinja.Add(z);
        }

        public static List<Uposlenik> dajListuUposlenika()
        {
            return listaUposlenika;
        }
        
        public static List<Zivotinja> dajListuZivotinja()
        {
            return listaZivotinja;
        }
        
    }
}
