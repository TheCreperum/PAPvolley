using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace PAPvolley
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        TeamDB db;
        ListView lstData;
        List<Team> lstSource = new List<Team>();
        public SecondPage()
        {
            InitializeComponent();

            db = new TeamDB();
            db.createDataBase();
            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            
            
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