using CentricTeam9MIS4200.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CentricTeam9MIS4200.DAL
{
    public class CentricContext : DbContext
    {
        public CentricContext() : base("name=DefaultConnection")
        {

        }
        public DbSet<Profile> profile { get; set; }
    }
}