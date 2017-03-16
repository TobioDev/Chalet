using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace provabarcode
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void AvviaScan(object sender, EventArgs e)
        {
            var scanResult = await Acr.BarCodes.BarCodes.Instance.Read();
            if (!scanResult.Success)
            {
                await this.DisplayAlert("Attenzione! ", "Nessun codice riconosciuto", "OK");
            }
            else
            {
                //await this.DisplayAlert("Scan Successful !", String.Format("Barcode Format : {0} \n Barcode Value : {1}", scanResult.Format, scanResult.Code), "OK");
                await Navigation.PushModalAsync(new Entrata());
            }

        }

        private async void Login (object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Login());
        }
    }
}
