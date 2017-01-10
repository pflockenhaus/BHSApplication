using System;
using Xamarin.Forms;

namespace BHSApplication
{
    public partial class NotRelevant : ContentPage
    {
        public NotRelevant()
        {
            InitializeComponent();
        }

        async void OnHomePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BHSHomePage());
        }

        async void OnContact(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BHSContactUs());
        }
    }
}
