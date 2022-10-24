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
    public partial class Contato : ContentPage
    {
        public Contato()
        {
            InitializeComponent();
            logo_etec.Source = ImageSource.FromResource("sanduiche.imagens.etec-2022.png");
            joaquim.Source = ImageSource.FromResource("sanduiche.imagens.joaquim.jpg");

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel: +55 (14) 3622-3566"));
        }
    }
}