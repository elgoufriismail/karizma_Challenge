using Karizma_Challenge.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Karizma_Challenge.Data
{
    public class KarizmaChallengeDbContext : DbContext
    {
        public KarizmaChallengeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Recette> Recettes {  get; set; }
        public DbSet<Ingredient> Ingredients { get; set;}
    }
}
