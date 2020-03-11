using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;
using SQLite;
using SQLitePCL;
using Xamarin.Forms;
using PAPvolley.Droid;

[assembly: Dependency(typeof(SQLite_Android))]
namespace PAPvolley.Droid
{
    public class SQLite_Android : ISQLite
    {
        
        public SQLite.Net.SQLiteConnection GetConnection()
        {
            var filename = "Team.db3";
            var documentspath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentspath, filename);

            var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var connection = new SQLite.Net.SQLiteConnection(platform, path);
            return connection;
        }
    }
}