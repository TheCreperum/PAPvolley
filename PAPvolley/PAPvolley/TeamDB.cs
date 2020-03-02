using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace PAPvolley
{
    class TeamDB
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        public bool createDataBase()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Persons.db")))
                {
                    connection.CreateTable<Team>();
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                string error = ex.Message;
                return false;
            }
        }
        public bool insertIntoTablePerson(Team team)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Teams.db")))
                {
                    connection.Insert(team);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                string error = ex.Message;
                return false;
            }
        }
    }
}
