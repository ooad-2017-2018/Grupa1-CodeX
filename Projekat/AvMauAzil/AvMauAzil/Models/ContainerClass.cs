using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvMauAzil.Azure;
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;
using System.Diagnostics;


namespace AvMauAzil.Models
{
    public static class ContainerClass
    {
        // ovo ce da bude kao Organization, direktorij Klase kao Models


        static IMobileServiceTable<uposlenici> userTableObj = App.MobileService.GetTable<uposlenici>();



        // ovdje ce da se izvuce iz baze sta

        //static List<uposlenici> listaUposlenikaTabela = new List<uposlenici>();


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
            try
            {
                uposlenici obj = new uposlenici();
                obj.id = u.EmployeeId.ToString();
                obj.ime_prezime = u.ImeUposlenika;
                obj.jmbg = u.JmbgUposlenika.ToString();
                obj.naziv_posla = u.VrstaPosla;
                obj.user_pass = u.UsernameUposlenika;
                userTableObj.InsertAsync(obj);
                Debug.WriteLine("Uspjesno unesen uposlenik.");
            }
            catch(Exception)
            {
                Debug.WriteLine("Neuspjesno unesen uposlenik.");
            }
            
        }

        public static void dodajZivotinju(Zivotinja z)
        {
            listaZivotinja.Add(z);
            // upis u bazu
            
        }

        public static bool containsId(Int32 id)
        {
            foreach(Uposlenik u in listaUposlenika)
            {
                if (u.EmployeeId == id) return true;
            }
            return false;
        }

        public static int brojUposlenih()
        {
            return listaUposlenika.Count;
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

        async private static Task getData()
        {
            var listaTabela = await userTableObj.ToListAsync();
            Debug.WriteLine(listaTabela.Count + "  ..");
            foreach (uposlenici up in listaTabela)
            {
                Debug.WriteLine(listaTabela.Count + "  ..");
                string vrstaP = up.naziv_posla;
                if (vrstaP.Equals("Veterinar")) listaUposlenika.Add(new Veterinar(up.ime_prezime, long.Parse(up.jmbg), up.user_pass, up.user_pass, up.user_pass + "@gmail.com"));
                else if (vrstaP.Equals("Dreser")) listaUposlenika.Add(new Dreser(up.ime_prezime, long.Parse(up.jmbg), up.user_pass, up.user_pass, up.user_pass + "@gmail.com"));
                else if (vrstaP.Equals("Direktor")) listaUposlenika.Add(new Direktor(up.ime_prezime, long.Parse(up.jmbg), up.user_pass, up.user_pass, up.user_pass + "@gmail.com"));
                else if (vrstaP.Equals("Upravitelj")) listaUposlenika.Add(new Upravitelj(up.ime_prezime, long.Parse(up.jmbg), up.user_pass, up.user_pass, up.user_pass + "@gmail.com"));
                else if (vrstaP.Equals("Vozač")) listaUposlenika.Add(new Vozac(up.ime_prezime, long.Parse(up.jmbg), up.user_pass, up.user_pass, up.user_pass + "@gmail.com"));
                else listaUposlenika.Add(new OstaloOsoblje("Higijeničar", up.ime_prezime, long.Parse(up.jmbg), up.user_pass, up.user_pass, up.user_pass + "@gmail.com"));

            }
        }

        async public static void loadData()
        {
            await getData();
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
