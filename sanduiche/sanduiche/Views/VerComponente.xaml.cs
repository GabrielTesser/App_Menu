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
    public partial class VerComponente : ContentPage
    {
        public VerComponente(Models.Componente c)
        {
            InitializeComponent();
            logo_etec.Source = ImageSource.FromResource("sanduiche.imagens.etec-2022.png");
            BindingContext = c;
        }
    }
}