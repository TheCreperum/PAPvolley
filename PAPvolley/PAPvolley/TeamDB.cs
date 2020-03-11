using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using SQLite;
using System.Linq;
namespace PAPvolley
{
    public class TeamDB
    {
        private SQLiteConnection _sqlconnection;

        public TeamDB()
        {
            //Getting conection and Creating table
            _sqlconnection = DependencyService.Get<ISQLite>().GetConnection();
            _sqlconnection.CreateTable<Team>();
        }

        //Get all students
        public IEnumerable<Team> GetTeam()
        {
            return (from t in _sqlconnection.Table<Team>() select t).ToList();
        }

        //Get specific student
        public Team GetTean(int id)
        {
            return _sqlconnection.Table<Team>().FirstOrDefault(t => t.Id == id);
        }

        //Delete specific student
        public void DeleteTeam(int id)
        {
            _sqlconnection.Delete<Team>(id);
        }

        //Add new student to DB
        public void AddTeam(Team team)
        {
            _sqlconnection.Insert(team);
        }
    }
}
