using AvMauAzil.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using AvMauAzil.Models;
using System.Threading.Tasks;
using System.Diagnostics;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AvMauAzil
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Task taskA;
        public MainPage()
        {
            this.InitializeComponent();
            taskA =  ContainerClass.getData();
            
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            if ((txtKorisnik.Text == "Admin" && txtSifra.Password == "admin") || (txtKorisnik.Text == "Avda" && txtSifra.Password == "avda") || (txtKorisnik.Text == "Edo" && txtSifra.Password == "edo"))
            {
                if (taskA.IsCompleted)
                    this.Frame.Navigate(typeof(AdminPage));
                else
                    Debug.WriteLine("Belaj sa loadData.");
            }
       
        }  
    }
}
