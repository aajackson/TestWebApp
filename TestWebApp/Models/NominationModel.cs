using System;
using System.Data.Entity;

namespace TestWebApp.Models
{
    public class Nomination
    {
        public int ID { get; set; }
        public int GameID { get; set; }
        public DateTime NominationTime { get; set; }
        public int DiscussionID { get; set; }
        public virtual Discussion Discussion { get; set; }
        public int UserID { get; set; }
    }

    public class NominationModel : DbContext
    {
        public  DbSet<Nomination> Nominations { get; set; }
    }
}