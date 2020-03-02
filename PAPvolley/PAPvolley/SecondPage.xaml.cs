using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PAPvolley
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }
        private async void Onbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ThirdPage());
        }
        private async void OnRedo_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert ("Alert", "You're a fag", "OK");
        }
    }
}