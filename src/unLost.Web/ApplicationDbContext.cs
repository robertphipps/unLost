using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace unLost.Web
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public DbSet<Models.Item> Items { get; set; }
        public DbSet<Models.Pupil> Pupils { get; set; }
        public DbSet<Models.TutorGp> TutorGps { get; set; }

    }
}
