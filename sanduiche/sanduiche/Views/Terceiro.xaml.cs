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
    public partial class Terceiro : ContentPage
    {
        public Terceiro()
        {
            InitializeComponent();
            logo_etec.Source = ImageSource.FromResource("sanduiche.imagens.etec-2022.png");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Segurança de Sistemas de Informação",
                    AtribuicaoRespobilidade = "Implementar rotinas de segurança da informação.",
                    ValoresAtitudes = "Estimular atitudes respeitosas.\n• Incentivar comportamentos éticos.\n• Desenvolver a criticidade.",
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("OPS!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação de Aplicativos Mobile II",
                    AtribuicaoRespobilidade = "Documentar, construir e manter sistemas de informação para plataformas móveis.",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações.\n• Incentivar a criatividade.\n• Estimular a organização",
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("OPS!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web III ",
                    AtribuicaoRespobilidade = "Documentar, construir e manter sistemas de informação para web ",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações.\n• Fortalecer a persistência e o interesse na resolução de situações-problema.\n• Incentivar a criatividade.",
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("OPS!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Qualidade e Teste de Software",
                    AtribuicaoRespobilidade = "Testar softwares para melhoria da qualidade de sistemas.\n• Elaborar registros e planilhas de acompanhamento e controle das atividades.",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações.\n• Estimular a proatividade.\n• Desenvolver criticidade.\n• Incentivar comportamentos éticos",
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("OPS!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Desenvolvimento do Trabalho de Conclusão de Curso (TCC)",
                    AtribuicaoRespobilidade = "Planejar e desenvolver projetos de sistemas computacionais",
                    ValoresAtitudes = "Planejar ações mais eficazes no desenvolvimento de sistemas.\n• Demonstrar comprometimento com equipe e o trabalho",
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("OPS!", ex.Message, "OK");
            }
        }
    }
}