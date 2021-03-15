using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentricTeam9MIS4200.Models
{
    public class Profile
    {
        public int profileID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int points { get; set; }
    }
}