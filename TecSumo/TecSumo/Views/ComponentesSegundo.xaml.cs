using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TecSumo.Models;

namespace TecSumo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesSegundo : ContentPage
    {
        public ComponentesSegundo()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Inglês Instrumental",
                    AtribuicoesResponsabilidades = "Comunicar-se em língua estrangeira – inglês, utilizando o vocabulário e a terminologia da área.  ",
                    ValoresAtitudes = "Respeitar as manifestações culturais de outros povos. • Estimular a comunicação nas relações interpessoais. • Socializar os saberes.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Desenvolvimento de Sistemas",
                    AtribuicoesResponsabilidades = "Analisar e projetar sistemas de informação, selecionando linguagens de programação e ambientes de desenvolvimento de acordo com as especificidades do projeto. • Codificar e depurar programas. ",
                    ValoresAtitudes = "Fortalecer a persistência e o interesse na resolução de situações-problema. • Incentivar ações que promovam a cooperação. • Desenvolver a criatividade. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Banco de Dados II ",
                    AtribuicoesResponsabilidades = "Implementar banco de dados. ",
                    ValoresAtitudes = "Incentivar a criatividade. • Desenvolver a criticidade. • Fortalecer a persistência e o interesse na resolução de situações-problema "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Internet e Protocolos ",
                    AtribuicoesResponsabilidades = "Utilizar protocolos de redes e internet para comunicação de dados.  ",
                    ValoresAtitudes = "Incentivar comportamentos éticos. • Promover ações que considerem o respeito às normas estabelecidas. • Fortalecer a persistência e o interesse na resolução de situações-problema.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação de Aplicativos Mobile I ",
                    AtribuicoesResponsabilidades = "Elaborar projetos de aplicativos para plataformas móveis. ",
                    ValoresAtitudes = "Incentivar a criatividade. • Responsabilizar-se pela produção, utilização e divulgação de informações. • Estimular a organização.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web II",
                    AtribuicoesResponsabilidades = "Planejar projetos de sistemas de informação para web ",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. • Fortalecer a persistência e o interesse na resolução de situações-problema. • Incentivar a criatividade.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }


        private async void embarcado_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Sistemas Embarcados",

                    AtribuicoesResponsabilidades = "Desenvolver sistemas embarcados",

                    ValoresAtitudes = "~ Incentivar a criatividade\n ~ Estimular a organização\n ~ Responsabilizar-se pela produção," +
                    "utilização e divulgação de informações"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void Port_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Língua Portuguesa, Literatura e Comunicação Profissional",

                    AtribuicoesResponsabilidades = "Comunicar-se em língua portuguesa, utilizando a terminologia técnico-científica da área com" +
                    "autonomia, clareza e precisão.",

                    ValoresAtitudes = "~ Incentivar o diálogo e a interlocução \n" +
                    "~ Estimular o interesse na resolução de situações-problema \n" +
                    "~ Responsabilizar-se pela produção, realização e divulgação de informações"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void ingles_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Língua Estrangeira Moderna - Inglês e Comunicação Profissional",

                    AtribuicoesResponsabilidades = "Comunicar-se em língua estrangeira utilizando o vocabulário e a terminologia" +
                    "técnico-cientifica da área",

                    ValoresAtitudes = "~ Incentivar ações que promovam a cooperação\n" +
                    "~ Respeitar as manifestações culturais de outros povos\n" +
                    "~ Estimular o interesse na resolução de situações-problema\n"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void geo_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Geografia",

                    AtribuicoesResponsabilidades = "Os trabalhos de elaboração de mapas, banco de dados geográficos, planejamento de transportes e trânsito, estudos sobre o solo, clima, vegetação, recursos hídricos, densidade de ocupação de um espaço e relevo fazem parte das responsabilidades de um geógrafo.",

                    ValoresAtitudes = "Altitude, latitude e clima"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void mat_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Matemática",

                    AtribuicoesResponsabilidades = "Implementar algoritmos em linguagem de programação" +
                    ", utlizando ambientes de desenvolvimento de acordo com as necessidades",

                    ValoresAtitudes = "~ Socializar os saberes \n ~ Estimular o interesse na resolução" +
                    "de situações-problema\n ~ Responsabilizar-se pela produção, utilização e " +
                    "divulgação de informações"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void bio_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Biologia",

                    AtribuicoesResponsabilidades = "Desenvolver o conhecimento cíentifico, ou seja, a capacidade de compreender " +
                    "e interpretar o mundo, mas também de transformá-lo",

                    ValoresAtitudes = "~ Estimular o interesse pela realidade que nos cerca\n" +
                    "~ Responsabilizar-se pela produção, utilização e divulgação de informações"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void quimica_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Química",

                    AtribuicoesResponsabilidades = "Pesquisar as interações e transformações químicas na natureza dos processos" +
                    "de produção e nas tecnologias",

                    ValoresAtitudes = "~ Estimular o interesse pela realidade que nos cerca\n" +
                    "~ Estimular o interesse na resolução de situações-problema\n" +
                    "~ Promover ações que considerem o respeito às normas estabelecidas"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void hist_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "História",

                    AtribuicoesResponsabilidades = "Pesquisar sobre a influência das tecnologias nos" +
                    "processos sociais e de produção",

                    ValoresAtitudes = "~ Incentivar comportamentos éticos\n" +
                    "~ Respeitar as manifestações culturais de outros povos\n" +
                    "~ Responsabilizar-se pela produção, utilização e divulgação de informações"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void fisica_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Física",

                    AtribuicoesResponsabilidades = "Pesquisar as interações e transformações físicas" +
                    "na natureza dos processos de produção e nas tecnologias",

                    ValoresAtitudes = "~ Estimular o interesse na resolução de situações-problema\n" +
                    "~ Promover ações que considerem o respeito às normas estabelecidas\n" +
                    "~ Responsabilizar-se pela produção, utilização e divulgação de informações"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void filoso_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Filosofia",

                    AtribuicoesResponsabilidades = "Estuda Sobre A Filosofia e Deuses Gregos Que Contribuem, para uma melhor sabedoria sobre conceitos humanos.",

                    ValoresAtitudes = "Melhor Estilo De Vida"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void socio_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Sociologia",

                    AtribuicoesResponsabilidades = "Estudo Sobre A Cidadania",

                    ValoresAtitudes = "Melhora Na Compreensão De Opinoões Diferentes"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void educacao_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Educação Física",

                    AtribuicoesResponsabilidades = "Utilizar técnicas e práticas de atividade física" +
                    "nos contextos de trabalho",

                    ValoresAtitudes = "~ Incentivar atitudes de autonomia\n" +
                    "~ Incentivar ações que promovam a cooperação"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
    }
}