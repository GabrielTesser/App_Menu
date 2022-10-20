using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sanduiche.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vestibulinho : ContentPage
    {
        public Vestibulinho()
        {
            InitializeComponent();
            logo_etec.Source = ImageSource.FromResource("sanduiche.imagens.etec-2022.png");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try 
            {
                Device.OpenUri(new Uri("http://www.etecjau.com.br/etecjau/"));
            }
            catch(Exception ex)
            {
                await DisplayAlert("ops!", ex.Message, "OK");
            }
        }
    }
}