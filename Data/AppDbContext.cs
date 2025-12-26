using ArabCuisine.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ArabCuisine.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
    }
}
