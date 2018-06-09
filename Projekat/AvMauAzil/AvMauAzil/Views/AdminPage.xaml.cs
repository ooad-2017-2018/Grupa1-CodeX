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

using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage.Pickers;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.Storage.Streams;
//using AvMauAzil.Views;
using Microsoft.WindowsAzure.MobileServices;
using Windows.Media.Capture;
using Windows.Storage;
using Windows.Media.Capture;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.Graphics.Imaging;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AvMauAzil
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminPage : Page
    {

        public AdminPage()
        {
            this.InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRegistriraj_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private async void Uslikaj_kamerom(object sender, RoutedEventArgs e)
        {
            try
            {
                //
                var UslikajUI = new CameraCaptureUI();
                UslikajUI.PhotoSettings.Format = CameraCaptureUIPhotoFormat.Jpeg;
                UslikajUI.PhotoSettings.CroppedSizeInPixels = new Size(200, 200);
                StorageFile slika = await UslikajUI.CaptureFileAsync(CameraCaptureUIMode.Photo);


                IRandomAccessStream stream = await slika.OpenAsync(FileAccessMode.Read);
                BitmapDecoder decoder = await BitmapDecoder.CreateAsync(stream);
                SoftwareBitmap softwareBitmap = await decoder.GetSoftwareBitmapAsync();

                SoftwareBitmap softwareBitmapBGR8 = SoftwareBitmap.Convert(softwareBitmap,
                BitmapPixelFormat.Bgra8,
                BitmapAlphaMode.Premultiplied);

                SoftwareBitmapSource bitmapSource = new SoftwareBitmapSource();
                await bitmapSource.SetBitmapAsync(softwareBitmapBGR8);

                polje_za_sliku.Source = bitmapSource;
            }
            catch { }

        }
       /* private void UslikajButton_Click(object sender, RoutedEventArgs e)
        {
            Uslikaj_kamerom(sender, e);
        }*/
            private void btnRegistriraj_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void myListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_UnesiSliku_Click(object sender, RoutedEventArgs e)
        {
            Uslikaj_kamerom(sender, e);
        }
    }
}
