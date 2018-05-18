using AvMauAzil.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Diagnostics;

namespace AvMauAzil.ViewModels
{
    public class AdminPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        List<String> listaRola = new List<String> { "Veterinar", "Dreser", "Upravitelj", "Direktor", "Vozač", "Higijeničar" };
        ObservableCollection<Uposlenik> kolekcijaUposlenika;
        Uposlenik selektovaniUposlenik;
        ICommand zaBrisanje, zaRegistraciju;
        String selektovanaRola;
        string upisanoIme, upisaniJmbg, prikazUsername;

        
        public string PrikazUsername
        {
            get => prikazUsername;
            set { prikazUsername = value; OnPropertyChanged("PrikazUsername"); }
        }
        public string UpisanoIme
        {
            get => upisanoIme;
            set
            {
                upisanoIme = value;
                PrikazUsername = "Username : ";
                string uname = upisanoIme.ToLower().Trim();
                int idx = uname.IndexOf(' ');
                while(idx != -1)
                {
                    uname = uname.Remove(idx, 1);
                    idx = uname.IndexOf(' ');
                }
                PrikazUsername = string.Concat(PrikazUsername, uname);
                OnPropertyChanged("UpisanoIme");
            }
        }
        public string UpisaniJmbg
        {
            get => upisaniJmbg;
            set { upisaniJmbg = value; OnPropertyChanged("UpisaniJmbg"); }
        }
        public List<string> ListaRola
        {
            get => listaRola;
            set => listaRola = value;
        }
        public string SelektovanaRola
        {
            get => selektovanaRola;
            set { selektovanaRola = value;  OnPropertyChanged("SelektovanaRola"); }
        }
        public ICommand ZaBrisanje
        {
            get => zaBrisanje;
            set => zaBrisanje = value;
        }
        public ICommand ZaRegistraciju
        {
            get => zaRegistraciju;
            set => zaRegistraciju = value;
        }
        public ObservableCollection<Uposlenik> KolekcijaUposlenika
        {
            get { return kolekcijaUposlenika; }
            set { kolekcijaUposlenika = value; OnPropertyChanged("KolekcijaUposlenika"); }
        }
        public Uposlenik SelektovaniUposlenik
        {
            get { return selektovaniUposlenik; }
            set
            {
                selektovaniUposlenik = value;
                OnPropertyChanged("SelektovaniUposlenik");
            }
        }

        

        public AdminPageViewModel()
        {
            UpisaniJmbg = "";
            UpisanoIme = "";
            SelektovanaRola = ListaRola.ElementAt(0);
            ZaRegistraciju = new RelayCommand<object>(funZaRegistraciju, boolFunZaRegistraciju);
            ZaBrisanje = new RelayCommand<object>(funZaBrisanje, boolFunZaBrisanje);
            kolekcijaUposlenika = new ObservableCollection<Uposlenik>(ContainerClass.dajListuUposlenika() as List<Uposlenik>);
        }


        void funZaRegistraciju(object parametar)
        {
            long jmbg;
            bool longPars = long.TryParse(UpisaniJmbg, out jmbg);
            if(UpisanoIme.Length != 0 && longPars)
            {
                Uposlenik novi = null;
                if (SelektovanaRola.Equals("Veterinar")) novi = new Veterinar(UpisanoIme, jmbg, PrikazUsername.Remove(0,11), PrikazUsername.Remove(0, 11), PrikazUsername.Remove(0, 11) + "@gmail.com");
                else if (SelektovanaRola.Equals("Dreser")) novi = new Dreser(UpisanoIme, jmbg, PrikazUsername.Remove(0, 11), PrikazUsername.Remove(0, 11), PrikazUsername.Remove(0, 11) + "@gmail.com");
                else if (SelektovanaRola.Equals("Direktor")) novi = new Direktor(UpisanoIme, jmbg, PrikazUsername.Remove(0, 11), PrikazUsername.Remove(0, 11), PrikazUsername.Remove(0, 11) + "@gmail.com");
                else if (SelektovanaRola.Equals("Upravitelj")) novi = new Upravitelj(UpisanoIme, jmbg, PrikazUsername.Remove(0, 11), PrikazUsername.Remove(0, 11), PrikazUsername.Remove(0, 11) + "@gmail.com");
                else if (SelektovanaRola.Equals("Vozač")) novi = new Vozac(UpisanoIme, jmbg, PrikazUsername.Remove(0, 11), PrikazUsername.Remove(0, 11), PrikazUsername.Remove(0, 11) + "@gmail.com");
                else if (SelektovanaRola.Equals("Higijeničar")) novi = new OstaloOsoblje("Higijeničar", UpisanoIme, jmbg, PrikazUsername.Remove(0, 11), PrikazUsername.Remove(0, 11), PrikazUsername.Remove(0, 11) + "@gmail.com");

                if(novi != null)
                {
                    KolekcijaUposlenika.Add(novi);
                    ContainerClass.dodajUposlenika(novi);
                }
            } 
        }

        bool boolFunZaRegistraciju(object parametar)
        {
            return true;
        }

        void funZaBrisanje(object parametar)
        {
            for (int i = 0; i < KolekcijaUposlenika.Count; i++)
            {
                if (KolekcijaUposlenika[i].JmbgUposlenika == SelektovaniUposlenik.JmbgUposlenika)
                {
                    
                    ContainerClass.brisiUposlenika(KolekcijaUposlenika[i].JmbgUposlenika);
                    KolekcijaUposlenika.RemoveAt(i);
                    break;
                }
            }
        }

        bool boolFunZaBrisanje(object parametar)
        {
            return true;
        }

       
    }
}
