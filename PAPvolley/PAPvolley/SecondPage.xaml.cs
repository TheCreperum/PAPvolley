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
        public TeamDB _teamdb;
        public Team team;
        public SecondPage()
        {
            InitializeComponent();
        
        }
        public void adddata(object s, EventArgs args)
        {
            team = new Team();
            _teamdb = new TeamDB();
            team.TeamName = name.Text;
            _teamdb.AddTeam(team);
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