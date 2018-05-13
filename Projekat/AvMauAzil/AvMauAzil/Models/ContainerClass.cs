using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvMauAzil.Models
{
    public static class ContainerClass
    {
        // ovo ce da bude kao Organization, direktorij Klase kao Models


        // ovdje ce da se izvuce iz baze sta
        static List<Uposlenik> listaUposlenika = new List<Uposlenik> {
            new Veterinar("MC Seki", 2101993172238, "mcseki", "mcseki", "mcseki@gmail.com"),
            new Dreser("Solomun", 1203991174441, "solomun", "solomun", "solomun@gmail.com"),
            new Direktor("Mico Micic", 1111966151008, "micomicic", "micomicic", "micomicic@gmail.com"),
            new Upravitelj("Dino Merlin", 2401961170011, "dinomerlin", "dinomerlin", "dinomerlin@gmail.com"),
            new OstaloOsoblje("Cleaning Lady", "Raza", 1008975176774, "raza", "raza", "raza@gmail.com"),
            new Vozac("Bule", 1204958170212, "bule", "bule", "bule@gmail.com")
        };
        static List<Zivotinja> listaZivotinja = new List<Zivotinja> {
            new Macka("Persian", "Mersiha", 4),
            new Macka("Ulicar", "Miki", 3),
            new Pas("Ulicar", "Nerko", 7),
            new Pas("Rott", "Milica", 6)
        };

        public static void dodajUposlenika(Uposlenik u)
        {
            listaUposlenika.Add(u);
            // upis u bazu
        }

        public static void dodajZivotinju(Zivotinja z)
        {
            listaZivotinja.Add(z);
            // upis u bazu
        }

        public static void brisiUposlenika(long jmbg)
        {
            for(int i = 0; i < listaUposlenika.Count; i++)
            {
                if(listaUposlenika[i].JmbgUposlenika == jmbg)
                {
                    listaUposlenika.RemoveAt(i);
                    break;
                }
            }
            //baza
        }

        public static void brisiZivotinju(int id)
        {
            for (int i = 0; i < listaZivotinja.Count; i++)
            {
                if (listaZivotinja[i].AnimalId == id)
                {
                    listaZivotinja.RemoveAt(i);
                    break;
                }
            }
            //baza
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
