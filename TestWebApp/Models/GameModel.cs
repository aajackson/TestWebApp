using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestWebApp.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string GameTitle { get; set; }
        public string URL { get; set; }
    }

    public class GameModel : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}