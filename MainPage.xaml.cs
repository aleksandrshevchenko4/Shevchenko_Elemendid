using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace _1Variant
{
    public partial class MainPage : ContentPage
    {
        private Picker stol;
        private void Stol_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public MainPage()
        {
            Picker picker;
            Entry entry;
            Image img;
            {
                Grid gr = new Grid
                {
                    RowDefinitions =
                    {
                        new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                        new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    },
                    ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                    }
                };
                picker = new Picker
                {
                    Title = "Eesti maakonnad"
                };
                picker.Items.Add("Harju maakond");
                picker.Items.Add("Tartu maakond");
                picker.Items.Add("Ida-Viru maakond");
                picker.Items.Add("Pärnu maakond");
                picker.Items.Add("Lääne-Viru maakond");
                picker.Items.Add("Viljandi maakond");
                picker.Items.Add("Rapla maakond");
                picker.Items.Add("Võru maakond");
                picker.Items.Add("Saare maakond");
                picker.Items.Add("Jõgeva maakond");
                picker.Items.Add("Järva maakond");
                picker.Items.Add("Lääne maakond");
                picker.Items.Add("Põlva maakond");
                picker.Items.Add("Hiiu maakond");                
                gr.Children.Add(picker, 0, 0);
                picker.SelectedIndexChanged += Picker_SelectedIndexChanged;

                stol = new Picker
                {
                    Title = "Maakonnakeskused"
                };
                stol.Items.Add("Valga");
                stol.Items.Add("Tartu");
                stol.Items.Add("Jõhvi");
                stol.Items.Add("Pärnu");
                stol.Items.Add("Rakvere");
                stol.Items.Add("Viljandi");
                stol.Items.Add("Rapla");
                stol.Items.Add("Võru");
                stol.Items.Add("Hiiu");
                stol.Items.Add("Jõgeva");
                stol.Items.Add("Paide");
                stol.Items.Add("Haapsalu");
                stol.Items.Add("Põlva");
                stol.Items.Add("Tallinn");
                stol.Items.Add("Kärdla");
                gr.Children.Add(stol, 0, 0);

                stol.SelectedIndexChanged += Stol_SelectedIndexChanged;


                entry = new Entry
                {
                    Text = "Уезд"
                };
                gr.Children.Add(entry, 1, 1);

                img = new Image
                {
                    Source = "harju.png"
                };
                {
                    if (stol.SelectedIndex == 0)
                    {
                        img.Source = "valga.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 1)
                    {
                        img.Source = "viljandi.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 2)
                    {
                        img.Source = "võru.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 3)
                    {
                        img.Source = "ida.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 4)
                    {
                        img.Source = "jõgeva.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 5)
                    {
                        img.Source = "lääne.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 6)
                    {
                        img.Source = "laanemaa.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 7)
                    {
                        img.Source = "põlva.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 8)
                    {
                        img.Source = "pärnu.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 9)
                    {
                        img.Source = "rapla.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 10)
                    {
                        img.Source = "saaremaa.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 11)
                    {
                        img.Source = "tartu.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 12)
                    {
                        img.Source = "harju.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 13)
                    {
                        img.Source = "hiiu.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 14)
                    {
                        img.Source = "jaarvamaa.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                }
                {
                    if (picker.SelectedIndex == 0)
                    {
                        img.Source = "valga.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Valga maakond ehk Valgamaa on 1. järgu haldusüksus Eestis. Hõlmab enamiku Valga rajooni alast. Maakonnalinn ja ühtlasi suurim asula on Valga linn, sellele järgnevad rahvaarvult Tõrva ja Otepää.";
                    }
                    else if (picker.SelectedIndex == 11)
                    {
                        img.Source = "tartu.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Tartu maakond ehk Tartumaa on 1. järgu haldusüksus Eestis. Hõlmab ajaloolise (18.-19. sajandi) Tartumaa tuumikala koos Tartu linnaga.";
                    }
                    else if (picker.SelectedIndex == 3)
                    {
                        img.Source = "ida.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Ida-Viru maakond ehk Ida-Virumaa on 1. järgu haldusüksus Eesti kirdeosas. Hõlmab ajaloolise Virumaa idaosa.";
                    }
                    else if (picker.SelectedIndex == 8)
                    {
                        img.Source = "pärnu.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Pärnu maakond ehk Pärnumaa on Eesti 1. järgu haldusüksus. Pärnu maakond hõlmab enamiku ajaloolise Pärnumaa alasid ning osa vanast Läänemaast.";
                    }
                    else if (picker.SelectedIndex == 5)
                    {
                        img.Source = "lääne.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Lääne-Viru maakond ehk Lääne-Virumaa on 1. järgu haldusüksus Eestis. Lääne - Viru maakond asub Põhja - Eestis.Lääne - Virumaa piirneb idas Ida - Viru, lõunas Jõgeva, ning läänes Järva ja Harju maakonnaga.";
                    }
                    else if (picker.SelectedIndex == 1)
                    {
                        img.Source = "viljandi.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Viljandi maakond ehk Viljandimaa on maakond Eesti lõunaosas.";
                    }
                    else if (picker.SelectedIndex == 9)
                    {
                        img.Source = "rapla.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Rapla maakond ehk Raplamaa on 1. järgu haldusüksus Eestis. Hõlmab enamiku nõukogudeaegse Rapla rajooni alast, mis moodustati ajaloolise Harjumaa lõunaosast, Läänemaa idaosast, Järvamaa edelaosast ja väiksemast Pärnumaa alast.";
                    }
                    else if (picker.SelectedIndex == 2)
                    {
                        img.Source = "võru.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Võru maakond ehk Võrumaa (võru keeles Võro maakund, Võromaa) on 1. järgu haldusüksus Eesti kaguosas. See hõlmab ajaloolist Võrumaa lõunaosa ning Eesti piires olevat tükki Setumaast.";
                    }
                    else if (picker.SelectedIndex == 10)
                    {
                        img.Source = "saaremaa.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Saare maakond ehk Saaremaa on 1. järgu haldusüksus Lääne-Eestis. Saare maakonna naabermaakonnad on põhjas Hiiu, kirdes Lääne ja idas Pärnu maakond. Maakonnalinn on Kuressaare.";
                    }
                    else if (picker.SelectedIndex == 4)
                    {
                        img.Source = "jõgeva.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Jõgeva maakond ehk Jõgevamaa on 1. järgu haldusüksus Eestis. See hõlmab endise Jõgeva rajooni ala.";
                    }
                    else if (picker.SelectedIndex == 14)
                    {
                        img.Source = "jaarvamaa.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Järva maakond ehk Järvamaa on 1. järgu haldusüksus Eestis. Maakond asub Eesti keskosas ning piirneb läänes Harju ja Rapla, põhjas ja kirdes Lääne - Viru, kagus Jõgeva, lõunas Viljandi ning edelas Pärnu maakonnaga.";
                    }
                    else if (picker.SelectedIndex == 6)
                    {
                        img.Source = "laanemaa.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Lääne maakond ehk Läänemaa on 1. järgu haldusüksus Eesti lääneosas. Hõlmab ajaloolise Läänemaa põhjaosa.";
                    }
                    else if (picker.SelectedIndex == 7)
                    {
                        img.Source = "põlva.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Põlva maakond ehk Põlvamaa 1. järgu haldusüksus Eestis. Hõlmab suurema osa endise Põlva rajooni alast.";
                    }
                    else if (picker.SelectedIndex == 12)
                    {
                        img.Source = "harju.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Harju maakond ehk Harjumaa on 1. järgu haldusüksus Põhja-Eestis.";
                    }
                    else if (picker.SelectedIndex == 13)
                    {
                        img.Source = "hiiu.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Hiiu maakond ehk Hiiumaa on 1. järgu haldusüksus Eestis. Hõlmab endise Hiiumaa rajooni ala.";
                    }
                }
                {
                }
            }
        }

    }
}