using System;
using System.Diagnostics;
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
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AvMauAzil
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UposleniAdminPage : Page
    {
        ObservableCollection<Uposlenik> Uposleni;

        public UposleniAdminPage()
        {
            this.InitializeComponent();


            this.Uposleni = new ObservableCollection<Uposlenik>();
            this.Uposleni.Add(new Veterinar("mujo mujic", 212112, "mm", "asa", "sdasd"));
            Debug.WriteLine(Uposleni.Count + " broj uposlenih");
        }
    }
}
