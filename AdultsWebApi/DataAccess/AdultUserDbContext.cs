using AdultsWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Models;

namespace AdultsWebApi.DataAccess
{
    public class AdultUserDbContext :DbContext
    {
        public DbSet<Adult> Adults { get;  set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = AdultUser.db");
        }
    }
}