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
    public partial class ComponentesPrimeiro : ContentPage
    {
        public ComponentesPrimeiro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Articular, Melhorar Conhecimentos De Computação",

                    AtribuicoesResponsabilidades = "• Otimiza a qualidade de interpretação de computação, • Como simples coisas como atalhos, ou dicas de programação",
                    ValoresAtitudes = "Incentivar o diálogo e a interlocução. • Responsabilizar-se pela produção, utilização e divulgação de informações. • Estimular a proatividade. ",
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
                    Nome = "Programação e Algoritmos",
                    AtribuicoesResponsabilidades = "• Implementar algoritmos em linguagem de programação, utilizando ambientes de desenvolvimento de acordo com as necessidades.  ",
                    ValoresAtitudes = "• Estimular a organização. • Incentivar atitudes de autonomia. • Fortalecer a persistência e o interesse na resolução de situações-problema.  "
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
                    Nome = "Banco de Dados I",
                    AtribuicoesResponsabilidades = "Modelar banco de dados ",
                    ValoresAtitudes = "Estimular a organização. • Fortalecer a persistência e o interesse na resolução de situações-problema. • Promover ações que considerem o respeito às normas estabelecidas."
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
                    Nome = "Análise e Projeto de Sistemas",
                    AtribuicoesResponsabilidades = "Elaborar projetos de sistema de informação.  ",
                    ValoresAtitudes = "Estimular a organização. • Incentivar a criatividade. • Fortalecer a persistência e o interesse na resolução de situações-problema.  "
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
                    Nome = "Design Digital",
                    AtribuicoesResponsabilidades = "Desenvolver elementos gráficos para aplicativos e sites.  ",
                    ValoresAtitudes = "Incentivar a criatividade. • Respeitar as manifestações culturais de outros povos. • Incentivar ações que promovam a cooperação. "
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
                    Nome = "Programação Web I",
                    AtribuicoesResponsabilidades = "Desenvolver sites para Web ",
                    ValoresAtitudes = "Incentivar a criatividade. • Estimular a organização. • Fortalecer a persistência e o interesse na resolução de situações-problema.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Fundamentos da Informática",
                    AtribuicoesResponsabilidades = "Operar sistemas computacionais.  ",
                    ValoresAtitudes = "Desenvolver a criticidade. • Incentivar comportamentos éticos. • Promover ações que considerem o respeito às normas estabelecidas.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }

        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Técnicas de Programação",
                    AtribuicoesResponsabilidades = "Desenvolver programas de computador, utilizando princípios de boas práticas. • Realizar versionamento no desenvolvimento de programas.  • Verificar usabilidade no desenvolvimento de programas.  ",
                    ValoresAtitudes = "Incentivar a criatividade. • Incentivar comportamentos éticos. • Fortalecer a persistência e o interesse na resolução de situações-problema. "
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

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = ""
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

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = ""
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

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = ""
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void artes_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Artes",

                    AtribuicoesResponsabilidades = "Pesquisar sobre a influência das novas tecnologias" +
                    "nas produções artísticas e culturais",

                    ValoresAtitudes = "~ Incentivar a criatividade\n" +
                    " ~ Respeitar as manifestações culturais de outors povos\n" +
                    "~ Estimular o interesse na resolução de situações-problema"
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