using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace PAPvolley
{
    class Team
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string TeamName { get; set; }

    }
}
