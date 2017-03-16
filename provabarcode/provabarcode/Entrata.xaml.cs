using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace provabarcode
{
    public partial class Entrata : ContentPage
    {
        public Entrata()
        {
            InitializeComponent();
            var tapGestureRecognizerOmbrellone = new TapGestureRecognizer();
            tapGestureRecognizerOmbrellone.Tapped += (s, e) =>
            {
                bottoneChiamata.IsVisible = true;
                bottoneChiamata.BackgroundColor = Color.FromHex("E67E22");
                bottoneChiamata.Text = " Chiamata Effettuata. In attesa di risposta. ";
            };
            bottoneOmbrellone.GestureRecognizers.Add(tapGestureRecognizerOmbrellone);

            var tapGestureRecognizerBar = new TapGestureRecognizer();
            tapGestureRecognizerBar.Tapped += (s, e) =>
            {
                bottoneChiamata.IsVisible = true;
                bottoneChiamata.BackgroundColor = Color.FromHex("E67E22");
                bottoneChiamata.Text = " Chiamata Effettuata. In attesa di risposta. ";
            };
            bottoneBar.GestureRecognizers.Add(tapGestureRecognizerBar);

            var tapGestureRecognizerServizi = new TapGestureRecognizer();
            tapGestureRecognizerServizi.Tapped += (s, e) =>
            {
                bottoneChiamata.IsVisible = true;
                bottoneChiamata.BackgroundColor = Color.FromHex("E67E22");
                bottoneChiamata.Text = " Chiamata Effettuata. In attesa di risposta. ";
            };
            bottoneServizi.GestureRecognizers.Add(tapGestureRecognizerServizi);

            var tapGestureRecognizerSos = new TapGestureRecognizer();
            tapGestureRecognizerSos.Tapped += (s, e) =>
            {
                bottoneChiamata.IsVisible = true;
                bottoneChiamata.BackgroundColor = Color.FromHex("E67E22");
                bottoneChiamata.Text = " Chiamata Effettuata. In attesa di risposta. ";
            };
            bottoneSos.GestureRecognizers.Add(tapGestureRecognizerSos);
        }

        private void ChiamataRicevuta(object sender, EventArgs e)
        {
            bottoneChiamata.BackgroundColor = Color.FromHex("2ECC71");
            bottoneChiamata.Text = " Abbiamo ricevuto la Vostra chiamata. Saremo presto da Voi. ";
            bottoneChiamata.TextColor = Color.White;
        }
    }
}
