﻿using AvMauAzil.ViewModels;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AvMauAzil
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e) { }
        

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            if ((txtKorisnik.Text == "Ajna" && txtSifra.Password == "ajna") || (txtKorisnik.Text == "Avda" && txtSifra.Password == "avda") || (txtKorisnik.Text == "Edo" && txtSifra.Password == "edo"))
            {
                this.Frame.Navigate(typeof(AdminPage));
            }
       
        }

        private void txtKorisnik_TextChanged(object sender, TextChangedEventArgs e) { }
        

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e) { }
        

        private void TextBlock_SelectionChanged_1(object sender, RoutedEventArgs e) { }
       

        private void TextBlock_SelectionChanged_2(object sender, RoutedEventArgs e) { }
        

        private void TextBlock_SelectionChanged_3(object sender, RoutedEventArgs e) { }
        

        private void TextBlock_SelectionChanged_4(object sender, RoutedEventArgs e) { }
       
    }
}
