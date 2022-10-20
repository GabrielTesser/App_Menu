using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sanduiche
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicial : ContentPage
    {
        public Inicial()
        {
            InitializeComponent();

            logo_ds.Source = ImageSource.FromResource("sanduiche.imagens.download.jpg");
            logo_etec.Source = ImageSource.FromResource("sanduiche.imagens.etec-2022.png");
        }
    }
}