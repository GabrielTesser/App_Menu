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
            logo_etec.Source = ImageSource.FromResource("sanduiche.imagens.etec-2022.png");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Analise de Sistemas",
                    AtribuicaoRespobilidade = "Elabora Projetos de Sistema de Informatica",
                    ValoresAtitudes = "Estimular a Organização, * Incentivar a Criatividade, * Fortalecer a Percistencia e o Interesse por Situações Problemas",
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
                    Nome = "Banco de Dados I",
                    AtribuicaoRespobilidade = "Modelar Banco de Dados",
                    ValoresAtitudes = "Estimular a Organização, * Fortalecer a Percistencia e o Interesse por Situações Problemas, * Promover Ações que Considerem o Respeito as Normas Estabelecidas",
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
                    Nome = "Design Digital",
                    AtribuicaoRespobilidade = "Desenvolver Elementos Gráficos para Aplicativos e Sites",
                    ValoresAtitudes = " Incentivar a Criatividade, * Respeitar Manifestações Culturais de Outros Povos, * Incentivar Acções que Promovam a Cooperação",
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
                    Nome = "Fundamentos da Informatica",
                    AtribuicaoRespobilidade = "Operara Sistemas Computacionais",
                    ValoresAtitudes = "Desenvolver a Criticidade, * Incentivar Comportamatos Éticos, * Promover Ações que Considerem o Respeito as Normas Estabelecidas",
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
                    Nome = "Programação Web I",
                    AtribuicaoRespobilidade = "Desenvolver Sites para Web",
                    ValoresAtitudes = "Incentivar a Criatividade,*Estimular a Organização, * Fortalecer a Percistencia e o Interesse por Situações Problemas",
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("OPS!", ex.Message, "OK");
            }

        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação de Algoritimo ",
                    AtribuicaoRespobilidade = "Implementar Algoritimos em Liguagem de Programação, Utilizando Ambiente de Desenvolvimento de Acordo com Necessidade ",
                    ValoresAtitudes = "Estimular a Organização, * Incentivar Atitudes Autonomas, * Fortalecer a Percistencia e o Interesse por Situações Problemas",
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