using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Cats.Views
{
    public partial class CatsPage : ContentPage
    {
        public CatsPage()
        {
            InitializeComponent();
            Listener();
        }

        private void Listener()
        {
            ListViewCats.ItemSelected += ListViewCats_SelectedItens;
        }

        private async void ListViewCats_SelectedItens(object sender, SelectedItemChangedEventArgs e)
        {
            var SelectedCat = e.SelectedItem as Models.Cat;
            if (SelectedCat != null)
            {
                await Navigation.PushAsync(new Views.DetailsPage(SelectedCat));
                ListViewCats.SelectedItem = null;
            }
        }
    }
}
