using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using sanduiche.Models;

namespace sanduiche.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Primeiro : ContentPage
    {
        public Primeiro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Analize de Sistemas",
                    AtribuicaoRespobilidade = "Análise de sistemas é a atividade que tem como finalidade a realização de estudos de processos a fim de encontrar o melhor caminho racional para que a informação possa ser processada. Os analistas de sistemas estudam os diversos sistemas existentes entre hardwares, softwares e o usuário final.",
                    ValoresAtitudes = "Estimular a Organização, * Incentivar a Criatividade, * Fortalecer a Percistencia e o Interesse por Situações Problemas",
                };
            }
            catch (Exception ex)
            {
                await DisplayAlert("OPS!", ex.Message, "OK");
            }

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {

        }
    }
}