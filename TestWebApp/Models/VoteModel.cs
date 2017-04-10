using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestWebApp.Models
{
    public class Vote
    {
        public int ID { get; set; }
        public int NominationID { get; set; }
        public int UserID { get; set; }
        public DateTime VoteTime { get; set; }
    }

    public class VoteModel : DbContext
    {
        public DbSet<Vote> Votes { get; set; }
    }
}