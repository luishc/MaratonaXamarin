using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Cats.Views
{
    public partial class DetailsPage : ContentPage
    {
        private Models.Cat SelectedCat;

        public DetailsPage(Models.Cat selectedCat)
        {
            InitializeComponent();

            this.SelectedCat = selectedCat;
            BindingContext = this.SelectedCat;

            Listener();
        }

        private void Listener()
        {
            ButtonWebSite.Clicked += ButtonWebSite_Clicked;
        }

        private void ButtonWebSite_Clicked(object sender, EventArgs e)
        {
            if (SelectedCat.WebSite.StartsWith("http"))
            {
                Device.OpenUri(new Uri(SelectedCat.WebSite));
            }
        }
    }
}
