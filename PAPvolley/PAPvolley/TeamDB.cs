﻿using System;
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
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Teams.db")))
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
        public bool insertIntoTablePerson(Team teams)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Teams.db")))
                {
                    connection.Insert(teams);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                string error = ex.Message;
                return false;
            }
        }
        public bool updateTableTeam(Team teams)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Teams.db")))
                {
                    connection.Query<Team>("UPDATE Team set TeamName=?",
                        teams.TeamName);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                string error = ex.Message;
                return false;
            }
        }
        public bool selectQueryTableTeam(int Id)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Teams.db")))
                {
                    connection.Query<Team>("SELECT * FROM Team Where Id=?", Id);
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