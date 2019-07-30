using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Economy.Models
{
    public class Economy_Context : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<RealPerson> RealPersons { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(true).UseSqlServer("Data Source=.;Initial Catalog=Economy;Persist Security Info=True;User ID=sa;Password=1371");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
