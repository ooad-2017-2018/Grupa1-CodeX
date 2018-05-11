using AvMauAzil.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



        ObservableCollection<Uposlenik> kolekcijaUposlenika;
        Uposlenik selektovaniUposlenik;
        //Treba ono ICommand za brisanje, i za dodavanje uraditi, azuriranje cao

        public ObservableCollection<Uposlenik> KolekcijaUposlenika
        {
            get { return kolekcijaUposlenika; }
            set { kolekcijaUposlenika = value; OnPropertyChanged("KolekcijaUposlenika"); }
        }
        public Uposlenik SelektovaniUposlenik
        {
            get { return selektovaniUposlenik; }
            set { selektovaniUposlenik = value; OnPropertyChanged("SelektovaniUposlenik"); }
        }

        public AdminPageViewModel()
        {
            kolekcijaUposlenika = new ObservableCollection<Uposlenik>(ContainerClass.dajListuUposlenika() as List<Uposlenik>);
        }

    }
}
