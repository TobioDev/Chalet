using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace provabarcode
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            titolo.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

            //Aggiunta azione Label passDimenticata
            var tapGestureRecognizerPass = new TapGestureRecognizer();
            tapGestureRecognizerPass.Tapped += (s, e) =>
            {
                //VaiPassDimenticata();
            };
            passDimenticata.GestureRecognizers.Add(tapGestureRecognizerPass);

            //Aggiunta azione Label registrazione
            var tapGestureRecognizerReg = new TapGestureRecognizer();
            tapGestureRecognizerPass.Tapped += (s, e) =>
            {
                //VaiRegistrazione();
            };
            registrazione.GestureRecognizers.Add(tapGestureRecognizerReg);
        }

        private void VaiPassDimenticata() { }

        private void VaiRegistrazione() { }

        //Logica click bottone Login
        private async void Autorizza(object sender, EventArgs e)
        {
            //Connettore connettore = new Connettore();
            //if (connettore.Login(username.Text, password.Text) != "-1")
            //{
            //    await Navigation.PushAsync(new Scan());
            //}
            //else
            //{
            //    DisplayAlert("Errore", "Username e/o Password errati.", "OK");
            //}

            if (username.Text == "prova" && password.Text == "prova")
            {
                await Navigation.PushModalAsync(new Dashboard());
            }
        }

    }
}
