using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace PAPvolley
{
    public class Team
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string TeamName { get; set; }
        public Team()
        {
        }
    }
}
