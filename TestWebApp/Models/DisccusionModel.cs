using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestWebApp.Models
{
    public class Discussion
    {
        public int ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime NominationDeadline { get; set; }
        public DateTime VotesDeadline { get; set; }
        public DateTime DiscussionDeadline { get; set; }

        public int VotedGameID { get; set; }
        public virtual Game VotedGame { get; set; }
    }

    public class DiscussionModel : DbContext
    {
        public DbSet<Discussion> Discussions { get; set; }
    }
}