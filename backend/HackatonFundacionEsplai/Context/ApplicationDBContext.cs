using HackatonFundacionEsplai.Entities;
using Microsoft.EntityFrameworkCore;

namespace HackatonFundacionEsplai.Context
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Region> Regions { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
    }
}
